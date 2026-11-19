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
            cmbChamp.Items.Clear();

            foreach (Campeonato championship in m_service.Data.Campeonatos)
                cmbChamp.Items.Add(championship);

            UiHelper.SelectFirst(cmbChamp);
        }
        private void LoadTournaments()
        {
            cmbTournament.Items.Clear();

            Campeonato championship = cmbChamp.SelectedItem as Campeonato;

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

        #endregion

        private void cmbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTournaments();
        }

        private void cmbTournemant_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTournaments();
        }

        private void cmbChamp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
