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
    public partial class FormTournaments : Form
    {
        private DataService m_service;
        private bool m_loading = false;
        public FormTournaments(DataService service)
        {
            InitializeComponent();
            m_service = service;

            LoadChampionships();
            LoadTournaments();
            ClearFields();
        }

        #region Load
        private Campeonato CurrentChampionship()
        {
            return cmbChampionship.SelectedItem as Campeonato;
        }
        private void LoadChampionships()
        {
            cmbChampionship.Items.Clear();
            foreach (Campeonato championship in m_service.Data.Campeonatos)
            {
                cmbChampionship.Items.Add(championship);
            }
            UiHelper.SelectFirst(cmbChampionship);
        }
        private void LoadTournaments()
        {
            m_loading = true;
            dgvTournaments.Rows.Clear();

            Campeonato championship = CurrentChampionship();

            if (championship != null)
            {
                foreach (Torneio tournament in championship.Torneios)
                {
                    UiHelper.AddRow(dgvTournaments, tournament, tournament.Id, tournament.Nome, tournament.Jogo, tournament.Equipas.Count, tournament.Partidas.Count);
                }
            }

            dgvTournaments.ClearSelection();
            m_loading = false;
        }
        private void ShowEnrolled(Torneio tournament)
        {
            if (tournament == null)
            {
                lblEnrolledTeams.Text = "0";
                lblEnrolledTeams.ForeColor = Color.DimGray;
                return;
            }
            else
                lblEnrolledTeams.Text = tournament.Equipas.Count.ToString();

            if (tournament.Equipas.Count >= Validations.MinTeams)
                lblEnrolledTeams.ForeColor = Color.Green;
            else
                lblEnrolledTeams.ForeColor = Color.Firebrick;
        }
        private void ClearFields()
        {
            UiHelper.SetNumber(nudTournamentId, m_service.NextTournamentId(CurrentChampionship()));
            txtTournamentName.Clear();
            UiHelper.SelectFirst(cmbGame);
            ShowEnrolled(null);
        }
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Events
        private void cmbChampionship_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTournaments();
            ClearFields();
        }

        private void dgvTournaments_SelectionChanged(object sender, EventArgs e)
        {
            if (m_loading)
                return;

            Torneio tournament = UiHelper.SelectedTag(dgvTournaments) as Torneio;

            if (tournament == null)
                return;

            UiHelper.SetNumber(nudTournamentId, tournament.Id);
            txtTournamentName.Text = tournament.Nome;

            if (!string.IsNullOrEmpty(tournament.Jogo))
            {
                if (!cmbGame.Items.Contains(tournament.Jogo))
                    cmbGame.Items.Add(tournament.Jogo);

                cmbGame.SelectedItem = tournament.Jogo;
            }

            ShowEnrolled(tournament);
        }

        private void btnAddTournament_Click(object sender, EventArgs e)
        {
            try
            {
                m_service.AddTournament(CurrentChampionship(), (int)nudTournamentId.Value, txtTournamentName.Text, cmbGame.Text);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            LoadTournaments();
            ClearFields();
        }

        private void btnEditTournament_Click(object sender, EventArgs e)
        {
            Torneio tournament = UiHelper.SelectedTag(dgvTournaments) as Torneio;

            try
            {
                m_service.EditTournament(CurrentChampionship(), tournament, (int)nudTournamentId.Value, txtTournamentName.Text, cmbGame.Text);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            LoadTournaments();
            ClearFields();
        }

        private void btnRemoveTournament_Click(object sender, EventArgs e)
        {
            Torneio tournament = UiHelper.SelectedTag(dgvTournaments) as Torneio;

            if (tournament == null)
            {
                ShowError("Escolha um torneio na grelha.");
                return;
            }

            string question = "Remover o torneio " + tournament.Nome + " com " + tournament.Equipas.Count + " equipa(s) e " + tournament.Partidas.Count + " partida(s)?";

            if (MessageBox.Show(question, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                m_service.RemoveTournament(CurrentChampionship(), tournament);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            LoadTournaments();
            ClearFields();
        }

        private void btnClearTournament_Click(object sender, EventArgs e)
        {
            dgvTournaments.ClearSelection();
            ClearFields();
        }
        #endregion
    }
}
