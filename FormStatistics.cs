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
    public partial class FormStatistics : Form
    {
        private DataService m_service;
        private List<Torneio> m_tournaments;

        public FormStatistics(DataService service)
        {
            InitializeComponent();
            m_service = service;
            m_tournaments = new List<Torneio>();
        }

        #region Eventos

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            if (m_service == null)
                return;

            AddPointsColumn();
            FillTournaments();
        }

        private void cmbTournamentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStatistics();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowStatistics();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Escreva um nickname para pesquisar.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            ShowSearch();
        }

        #endregion

        #region Métodos auxiliares

        // O Designer so tem 6 colunas na classificacao, falta a dos Pontos (fica antes da Media)
        private void AddPointsColumn()
        {
            if (dgvStandings.Columns["colPoints"] != null)
                return;

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "colPoints";
            column.HeaderText = "Pontos";
            column.Width = 70;
            column.ReadOnly = true;
            dgvStandings.Columns.Insert(dgvStandings.Columns.Count - 1, column);
        }

        private void FillTournaments()
        {
            m_tournaments.Clear();
            cmbTournamentFilter.Items.Clear();
            cmbTournamentFilter.Items.Add("Todos os torneios");

            foreach (Campeonato championship in m_service.Data.Campeonatos)
            {
                foreach (Torneio tournament in championship.Torneios)
                {
                    m_tournaments.Add(tournament);
                    cmbTournamentFilter.Items.Add(championship.Nome + " - " + tournament.Nome);
                }
            }

            cmbTournamentFilter.SelectedIndex = 0;
        }

        private List<Torneio> SelectedTournaments()
        {
            if (cmbTournamentFilter.SelectedIndex <= 0)
                return m_tournaments;

            List<Torneio> selected = new List<Torneio>();
            selected.Add(m_tournaments[cmbTournamentFilter.SelectedIndex - 1]);
            return selected;
        }

        private void ShowStatistics()
        {
            ShowStandings();
            ShowTop3();

            if (txtSearch.Text.Trim() != "")
                ShowSearch();
        }

        private void ShowStandings()
        {
            dgvStandings.Rows.Clear();

            foreach (StandingRow row in StatisticsService.GetStandings(SelectedTournaments()))
            {
                dgvStandings.Rows.Add(row.Position, row.Team, row.Played, row.Wins,
                    row.Losses, row.Points, row.Average.ToString("0.00"));
            }
        }

        private void ShowTop3()
        {
            List<Torneio> tournaments = SelectedTournaments();

            dgvTop3.Rows.Clear();

            foreach (PlayerRow row in StatisticsService.GetTop3(tournaments))
            {
                dgvTop3.Rows.Add(row.Position, row.Nickname, row.Name, row.Team,
                    row.Average.ToString("0.00"), row.Total);
            }

            lblOverallAverage.Text = StatisticsService.OverallAverage(tournaments).ToString("0.00");
            lblPlayersCount.Text = StatisticsService.GetPlayers(tournaments).Count.ToString();
        }

        private void ShowSearch()
        {
            List<PlayerRow> results = StatisticsService.SearchNickname(SelectedTournaments(), txtSearch.Text);

            dgvSearchResults.Rows.Clear();

            foreach (PlayerRow row in results)
            {
                dgvSearchResults.Rows.Add(row.Nickname, row.Name, row.Age, row.Team,
                    row.Tournament, row.Average.ToString("0.00"));
            }

            lblResultsCount.Text = results.Count.ToString() + " resultados";
        }

        #endregion
    }
}