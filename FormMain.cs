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
    public partial class FormMain : Form
    {
        private DataService m_service = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        #region Form

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (m_service.Load() == true)
                    lblStatus.Text = "Dados carregados";
                else
                    lblStatus.Text = "Sem dados. Importe um ficheiro XML ou JSON.";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao carregar o dados.json", ex);
                lblStatus.Text = "Erro ao carregar os dados";
            }

            RefreshAll();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                m_service.Save();
            }
            catch (Exception ex)
            {
                DialogResult res;
                res = MessageBox.Show("Não foi possível guardar os dados.\n" + ex.Message +
                    "\n\nQuer fechar a aplicação mesmo assim?", this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2);
                if (res == DialogResult.No)
                    e.Cancel = true;
            }
        }

        #endregion

        #region Campeonatos

        private void dgvChampionships_SelectionChanged(object sender, EventArgs e)
        {
            Campeonato championship = SelectedChampionship();

            if (championship == null)
                return;

            nudChampionshipId.Value = championship.Id;
            txtChampionshipName.Text = championship.Nome;
            nudChampionshipYear.Value = championship.Ano;
        }

        private void btnAddChampionship_Click(object sender, EventArgs e)
        {
            try
            {
                m_service.AddChampionship(Convert.ToInt32(nudChampionshipId.Value),
                    txtChampionshipName.Text, Convert.ToInt32(nudChampionshipYear.Value));

                RefreshAll();
                lblStatus.Text = "Campeonato adicionado";
            }
            catch (Exception ex)
            {
                ShowError("Adicionar campeonato", ex);
            }
        }

        private void btnEditChampionship_Click(object sender, EventArgs e)
        {
            Campeonato championship = SelectedChampionship();

            if (championship == null)
            {
                MessageBox.Show("Escolha um campeonato na grelha.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                m_service.EditChampionship(championship, Convert.ToInt32(nudChampionshipId.Value),
                    txtChampionshipName.Text, Convert.ToInt32(nudChampionshipYear.Value));

                RefreshAll();
                lblStatus.Text = "Campeonato editado";
            }
            catch (Exception ex)
            {
                ShowError("Editar campeonato", ex);
            }
        }

        private void btnRemoveChampionship_Click(object sender, EventArgs e)
        {
            Campeonato championship = SelectedChampionship();

            if (championship == null)
            {
                MessageBox.Show("Escolha um campeonato na grelha.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res;
            res = MessageBox.Show("Remover o campeonato " + championship.Nome +
                " e todos os seus torneios?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            try
            {
                m_service.RemoveChampionship(championship);

                RefreshAll();
                lblStatus.Text = "Campeonato removido";
            }
            catch (Exception ex)
            {
                ShowError("Remover campeonato", ex);
            }
        }

        #endregion

        #region Abrir os outros forms

        private void btnTeams_Click(object sender, EventArgs e)
        {
            FormTeam childForm = new FormTeam(m_service);
            childForm.ShowDialog();
            RefreshAll();
        }

        private void btnTournaments_Click(object sender, EventArgs e)
        {
            FormTournaments childForm = new FormTournaments(m_service);
            childForm.ShowDialog();
            RefreshAll();
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            FormMatches childForm = new FormMatches(m_service);
            childForm.ShowDialog();
            RefreshAll();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics childForm = new FormStatistics(m_service);
            childForm.ShowDialog();
            RefreshAll();
        }

        private void mnuTeams_Click(object sender, EventArgs e)
        {
            btnTeams_Click(sender, e);
        }

        private void mnuTournaments_Click(object sender, EventArgs e)
        {
            btnTournaments_Click(sender, e);
        }

        private void mnuMatches_Click(object sender, EventArgs e)
        {
            btnMatches_Click(sender, e);
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            btnStatistics_Click(sender, e);
        }

        #endregion

        #region Menu Ficheiro

        private void mnuImportXml_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "XML (*.xml)|*.xml";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            if (ConfirmReplace() == false)
                return;

            try
            {
                m_service.ImportXml(openFileDialog.FileName);

                RefreshAll();
                lblStatus.Text = "XML importado";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao importar o XML", ex);
            }
        }

        private void mnuImportJson_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JSON (*.json)|*.json";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            if (ConfirmReplace() == false)
                return;

            try
            {
                m_service.ImportJson(openFileDialog.FileName);

                RefreshAll();
                lblStatus.Text = "JSON importado";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao importar o JSON", ex);
            }
        }

        private void mnuExportXml_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "XML (*.xml)|*.xml";
            saveFileDialog.FileName = "campeonatos.xml";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                m_service.ExportXml(saveFileDialog.FileName);
                lblStatus.Text = "XML exportado";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao exportar o XML", ex);
            }
        }

        private void mnuExportJson_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JSON (*.json)|*.json";
            saveFileDialog.FileName = "campeonatos.json";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                m_service.ExportJson(saveFileDialog.FileName);
                lblStatus.Text = "JSON exportado";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao exportar o JSON", ex);
            }
        }

        private void mnuConvertXmlToJson_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "XML (*.xml)|*.xml";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            saveFileDialog.Filter = "JSON (*.json)|*.json";
            saveFileDialog.FileName = "convertido.json";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                m_service.ConvertXmlToJson(openFileDialog.FileName, saveFileDialog.FileName);
                lblStatus.Text = "XML convertido para JSON";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao converter XML para JSON", ex);
            }
        }

        private void mnuConvertJsonToXml_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JSON (*.json)|*.json";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            saveFileDialog.Filter = "XML (*.xml)|*.xml";
            saveFileDialog.FileName = "convertido.xml";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                m_service.ConvertJsonToXml(openFileDialog.FileName, saveFileDialog.FileName);
                lblStatus.Text = "JSON convertido para XML";
            }
            catch (Exception ex)
            {
                ShowError("Erro ao converter JSON para XML", ex);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Menu Ajuda

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestão de Campeonatos de eSports\n\n" +
                "Projeto de grupo de PSI - XML e JSON\nINETE, 12.º ano", "Acerca de",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Métodos auxiliares

        private void RefreshAll()
        {
            FillGrid();
            ShowTotals();
            ClearFields();
        }

        private void FillGrid()
        {
            dgvChampionships.Rows.Clear();

            foreach (Campeonato c in m_service.Data.Campeonatos)
            {
                int teams = c.Torneios.Sum(t => t.Equipas.Count);
                int idx = dgvChampionships.Rows.Add(c.Id, c.Nome, c.Ano, c.Torneios.Count, teams);

                dgvChampionships.Rows[idx].Tag = c;
            }
        }

        private void ShowTotals()
        {
            lblTotalChampionships.Text = m_service.Data.Campeonatos.Count.ToString();
            lblTotalTournaments.Text = m_service.TotalTournaments().ToString();
            lblTotalTeams.Text = m_service.TotalTeams().ToString();
            lblTotalPlayers.Text = m_service.TotalPlayers().ToString();
            lblTotalMatches.Text = m_service.TotalMatches().ToString();
            lblTotalScores.Text = m_service.TotalScores().ToString();
        }

        private void ClearFields()
        {
            dgvChampionships.ClearSelection();
            nudChampionshipId.Value = m_service.NextChampionshipId();
            txtChampionshipName.Text = "";
            nudChampionshipYear.Value = DateTime.Today.Year;
            txtChampionshipName.Focus();
        }

        private Campeonato SelectedChampionship()
        {
            if (dgvChampionships.SelectedRows.Count == 0)
                return null;

            return (Campeonato)dgvChampionships.SelectedRows[0].Tag;
        }

        private bool ConfirmReplace()
        {
            if (m_service.Data.Campeonatos.Count == 0)
                return true;

            DialogResult res;
            res = MessageBox.Show("Os dados atuais vão ser substituídos pelos do ficheiro.\nContinuar?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            return res == DialogResult.Yes;
        }

        private void ShowError(string title, Exception ex)
        {
            string text = ex.Message;

            if (ex.InnerException != null)
                text += "\n" + ex.InnerException.Message;

            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
