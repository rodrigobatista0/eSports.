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
    public partial class FormMatches : Form
    {
        private DataService m_service;

        
        private bool m_loading = false;

        public FormMatches(DataService service)
        {
            InitializeComponent();

            m_service = service;

            LoadChampionships();
            LoadTournaments();
            LoadMatches();
            LoadTeamCombos();
            ClearScheduleFields();
            ClearResultFields();
        }

        
        private Torneio CurrentTournament()
        {
            return cmbTournament.SelectedItem as Torneio;
        }

        private void LoadChampionships()
        {
            cmbchampionship.Items.Clear();

            foreach (Campeonato championship in m_service.Data.Campeonatos)
            {
                cmbchampionship.Items.Add(championship);
            }

            UiHelper.SelectFirst(cmbchampionship);
        }

        private void LoadTournaments()
        {
            cmbTournament.Items.Clear();

            Campeonato championship = cmbchampionship.SelectedItem as Campeonato;

            if (championship != null)
            {
                foreach (Torneio tournament in championship.Torneios)
                {
                    cmbTournament.Items.Add(tournament);
                }
            }

            UiHelper.SelectFirst(cmbTournament);
        }

        private void LoadMatches()
        {
            m_loading = true;
            dgvMatches.Rows.Clear();

            Torneio tournament = CurrentTournament();

            if (tournament != null)
            {
                foreach (Partida match in tournament.Partidas)
                {
                    UiHelper.AddRow(dgvMatches, match,
                        match.Id,
                        match.Data.ToString("dd/MM/yyyy"),
                        m_service.TeamName(tournament, match.IdEquipaA),
                        m_service.ResultText(match),
                        m_service.TeamName(tournament, match.IdEquipaB),
                        m_service.WinnerName(tournament, match));
                }
            }

            dgvMatches.ClearSelection();
            m_loading = false;
        }

        
        private void LoadTeamCombos()
        {
            cmbTeamA.Items.Clear();
            cmbTeamB.Items.Clear();

            Torneio tournament = CurrentTournament();

            if (tournament != null)
            {
                foreach (Equipa team in tournament.Equipas)
                {
                    cmbTeamA.Items.Add(team);
                    cmbTeamB.Items.Add(team);
                }
            }

            UiHelper.SelectFirst(cmbTeamA);

            
            if (cmbTeamB.Items.Count > 1)
            {
                cmbTeamB.SelectedIndex = 1;
            }
            else
            {
                UiHelper.SelectFirst(cmbTeamB);
            }
        }

        private void ClearScheduleFields()
        {
            UiHelper.SetNumber(nudMatchId, m_service.NextMatchId(CurrentTournament()));
            dtpDate.Value = DateTime.Today;
        }

        private void ClearResultFields()
        {
            lblSelectedMatch.Text = "Partida: (nenhuma selecionada)";
            lblScoreTeamA.Text = "Equipa A";
            lblScoreTeamB.Text = "Equipa B";
            nudScoreA.Value = 0;
            nudScoreB.Value = 0;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        

        private void FormMatches_Load(object sender, EventArgs e)
        {

        }


        private void cmbchampionship_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == cmbTournament)
            {
                cmbTournament_SelectedIndexChanged(sender, e);
                return;
            }

            LoadTournaments();
        }

        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatches();
            LoadTeamCombos();
            ClearScheduleFields();
            ClearResultFields();
        }

        private void dgvMatches_SelectionChanged(object sender, EventArgs e)
        {
            if (m_loading)
            {
                return;
            }

            Partida match = UiHelper.SelectedTag(dgvMatches) as Partida;
            Torneio tournament = CurrentTournament();

            if (match == null || tournament == null)
            {
                return;
            }

            string nameA = m_service.TeamName(tournament, match.IdEquipaA);
            string nameB = m_service.TeamName(tournament, match.IdEquipaB);

            lblSelectedMatch.Text = "Partida " + match.Id + ": " + nameA + " vs " + nameB;
            lblScoreTeamA.Text = nameA;
            lblScoreTeamB.Text = nameB;

            
            UiHelper.SetNumber(nudScoreA, match.ResultadoA.GetValueOrDefault());
            UiHelper.SetNumber(nudScoreB, match.ResultadoB.GetValueOrDefault());
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                m_service.ScheduleMatch(CurrentTournament(), (int)nudMatchId.Value, dtpDate.Value,
                    cmbTeamA.SelectedItem as Equipa, cmbTeamB.SelectedItem as Equipa);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            LoadMatches();
            ClearScheduleFields();
        }

        private void btnRemoveMatch_Click(object sender, EventArgs e)
        {
            Partida match = UiHelper.SelectedTag(dgvMatches) as Partida;

            if (match == null)
            {
                ShowError("Escolha uma partida na grelha.");
                return;
            }

            DialogResult answer = MessageBox.Show("Remover a partida " + match.Id + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                m_service.RemoveMatch(CurrentTournament(), match);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            LoadMatches();
            ClearScheduleFields();
            ClearResultFields();
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            Partida match = UiHelper.SelectedTag(dgvMatches) as Partida;

            try
            {
                m_service.SaveResult(match, (int)nudScoreA.Value, (int)nudScoreB.Value);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            LoadMatches();
            ClearResultFields();
        }
    }
}