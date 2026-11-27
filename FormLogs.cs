using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eSports.Models;
using eSports.Services;

namespace eSports
{
    public partial class FormLogs : Form
    {
        private DataService m_service;

        public FormLogs(DataService service)
        {
            InitializeComponent();

            m_service = service;

            // por defeito mostra a ultima semana
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;
            ShowLogs();

            // O Designer nao tem eventos, por isso ligam-se aqui
            btnSearch.Click += btnSearch_Click;
            btnToday.Click += btnToday_Click;
            btnLast7Days.Click += btnLast7Days_Click;
        }


        #region Show data

        // Mostra na grelha os logs entre a data inicial e a final
        private void ShowLogs()
        {
            try
            {
                List<LogEntry> logs = m_service.Log.GetBetween(dtpFrom.Value, dtpTo.Value);

                dgvLogs.Rows.Clear();

                foreach (LogEntry entry in logs)
                    UiHelper.AddRow(dgvLogs, entry, entry.Date.ToString("dd/MM/yyyy HH:mm:ss"), entry.Action, entry.Details);

                dgvLogs.ClearSelection();
                lblTotal.Text = "Registos encontrados: " + logs.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Buttons

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowLogs();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            ShowLogs();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;
            ShowLogs();
        }

        #endregion
    }
}
