using eSports.Models;
using eSports.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSports
{
    public partial class FormTeam : Form
    {
        private DataService m_service;
        private bool m_loading = false;
        public FormTeam(DataService service)
        {
            InitializeComponent();
            m_service = service;

            LoadChampionships();
            ClearTeamFields();
            ClearPlayerFields();
        }
        #region  Loads
        private Torneio CurrentTournament()
        {
            return cmbTournament.SelectedItem as Torneio;
        }
        private Equipa CurrentTeam()
        {
            return cmbTeam.SelectedItem as Equipa;
        }
        private void LoadChampionships()
        {
            cmbChampionships.Items.Clear();

            foreach (Campeonato championship in m_service.Data.Campeonatos)
                cmbChampionships.Items.Add(championship);

            UiHelper.SelectFirst(cmbChampionships);
        }
        private void LoadTournaments()
        {
            cmbTournament.Items.Clear();

            Campeonato championship = cmbChampionships.SelectedItem as Campeonato;

            if (championship != null)
            {
                foreach (Torneio tournament in championship.Torneios)
                    cmbTournament.Items.Add(tournament);
            }

            UiHelper.SelectFirst(cmbTournament);
        }
        private void LoadTeams()
        {
            m_loading = true;
            dgvTeams.Rows.Clear();

            Torneio tournament = CurrentTournament();

            if (tournament != null)
            {
                foreach (Equipa team in tournament.Equipas)
                    UiHelper.AddRow(dgvTeams, team, team.Id, team.Nome, team.Pais, team.Jogadores.Count);
            }

            dgvTeams.ClearSelection();
            m_loading = false;
        }
        private void LoadTeamCombo()
        {
            Equipa previous = cmbTeam.SelectedItem as Equipa;

            cmbTeam.Items.Clear();

            Torneio tournament = CurrentTournament();

            if (tournament != null)
            {
                foreach (Equipa team in tournament.Equipas)
                    cmbTeam.Items.Add(team);
            }

            if (previous != null && cmbTeam.Items.Contains(previous))
                cmbTeam.SelectedItem = previous;
            else
                UiHelper.SelectFirst(cmbTeam);
        }
        private void LoadPlayers()
        {
            m_loading = true;
            dgvPlayers.Rows.Clear();

            Equipa team = CurrentTeam();

            if (team != null)
            {
                string search = txtSearchNick.Text.Trim().ToLower();

                foreach (Jogador player in team.Jogadores.Where(p => p.Nickname.ToLower().Contains(search)))
                {
                    string average = "-";

                    if (player.Pontuacoes.Count > 0)
                        average = player.Pontuacoes.Average().ToString("0.0");

                    UiHelper.AddRow(dgvPlayers, player, player.Id, player.Nome, player.Nickname, player.Idade, average);
                }
            }

            dgvPlayers.ClearSelection();
            m_loading = false;
        }
        private void ClearTeamFields()
        {
            UiHelper.SetNumber(nudID, m_service.NextTeamId(CurrentTournament()));
            txtNameTeam.Clear();
            txtCountryTeams.Clear();
        }
        private void ClearPlayerFields()
        {
            UiHelper.SetNumber(nudIdPlayer, m_service.NextPlayerId(CurrentTeam()));
            txtNamePlayer.Clear();
            txtNickNamePlayer.Clear();
            UiHelper.SetNumber(nudAgePlayer, 18);
            lstScores.Items.Clear();
            UiHelper.SetNumber(nudScore, 0);
        }
        private void AfterTeamChange()
        {
            LoadTeams();
            LoadTeamCombo();
            LoadPlayers();
            ClearTeamFields();
            ClearPlayerFields();
        }
        private void AfterPlayerChange()
        {
            LoadPlayers();
            LoadTeams();
            ClearPlayerFields();
        }
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Choose championship / tournament / team
        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTeams();
            LoadTeamCombo();
            LoadPlayers();
            ClearTeamFields();
            ClearPlayerFields();
        }
        private void cmbChampionships_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTournaments();

        }
        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayers();
            ClearPlayerFields();
        }
        #endregion

        #region Equipas
        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            if (m_loading)
                return;

            Equipa team = UiHelper.SelectedTag(dgvTeams) as Equipa;

            if (team == null)
                return;

            UiHelper.SetNumber(nudID, team.Id);
            txtNameTeam.Text = team.Nome;
            txtCountryTeams.Text = team.Pais;
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            try
            {
                m_service.AddTeam(CurrentTournament(), (int)nudID.Value, txtNameTeam.Text, txtCountryTeams.Text);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            AfterTeamChange();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Equipa team = UiHelper.SelectedTag(dgvTeams) as Equipa;

            try
            {
                m_service.EditTeam(CurrentTournament(), team, (int)nudID.Value, txtNameTeam.Text, txtCountryTeams.Text);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            AfterTeamChange();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Equipa team = UiHelper.SelectedTag(dgvTeams) as Equipa;

            if (team == null)
            {
                ShowError("Escolha uma equipa na grelha.");
                return;
            }

            if (MessageBox.Show("Remover a equipa " + team.Nome + " e os seus jogadores?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                m_service.RemoveTeam(CurrentTournament(), team);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            AfterTeamChange();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            dgvTeams.ClearSelection();
            ClearTeamFields();
        }
        #endregion

        #region Players
        private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (m_loading)
                return;

            Jogador player = UiHelper.SelectedTag(dgvPlayers) as Jogador;

            if (player == null)
                return;

            UiHelper.SetNumber(nudIdPlayer, player.Id);
            txtNamePlayer.Text = player.Nome;
            txtNickNamePlayer.Text = player.Nickname;
            UiHelper.SetNumber(nudAgePlayer, player.Idade);

            lstScores.Items.Clear();

            foreach (int score in player.Pontuacoes)
                lstScores.Items.Add(score);
        }

        private void txtSearchNick_TextChanged(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                m_service.AddPlayer(CurrentTeam(), (int)nudIdPlayer.Value, txtNamePlayer.Text, txtNickNamePlayer.Text, (int)nudAgePlayer.Value, GetScores());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            AfterPlayerChange();

        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            Jogador player = UiHelper.SelectedTag(dgvPlayers) as Jogador;

            try
            {
                m_service.EditPlayer(CurrentTeam(), player, (int)nudIdPlayer.Value, txtNamePlayer.Text, txtNickNamePlayer.Text, (int)nudAgePlayer.Value, GetScores());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            AfterPlayerChange();
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            Jogador player = UiHelper.SelectedTag(dgvPlayers) as Jogador;

            if (player == null)
            {
                ShowError("Escolha um jogador na grelha.");
                return;
            }

            if (MessageBox.Show("Remover o jogador " + player.Nickname + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                m_service.RemovePlayer(CurrentTeam(), player);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            AfterPlayerChange();
        }

        private List<int> GetScores()
        {
            List<int> scores = new List<int>();

            foreach (object item in lstScores.Items)
                scores.Add((int)item);

            return scores;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            lstScores.Items.Add((int)nudScore.Value);

        }

        private void btnRemoveScore_Click(object sender, EventArgs e)
        {
            if (lstScores.SelectedIndex < 0)
            {
                ShowError("Escolha uma pontuação na lista.");
                return;
            }

            lstScores.Items.RemoveAt(lstScores.SelectedIndex);
        }
    }
    #endregion
}