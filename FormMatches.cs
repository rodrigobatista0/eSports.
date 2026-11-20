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
       

       
        private List<string> campeonatos = new List<string>();

       
        private List<string> torneios = new List<string>();
        private List<int> torneioCampeonato = new List<int>();

       
        private List<string> equipas = new List<string>();
        private List<int> equipaTorneio = new List<int>();

        
        private List<int> partidaId = new List<int>();
        private List<int> partidaTorneio = new List<int>();
        private List<DateTime> partidaData = new List<DateTime>();
        private List<int> partidaEquipaA = new List<int>();
        private List<int> partidaEquipaB = new List<int>();
        private List<int> partidaResA = new List<int>();  
        private List<int> partidaResB = new List<int>();

       
        private List<int> torneiosVisiveis = new List<int>();
        private List<int> equipasVisiveis = new List<int>();

        
        private bool loading = false;

        public FormMatches()
        {
            InitializeComponent();
        }

        
       
        private void FormMatches_Load(object sender, EventArgs e)
        {
            
            dgvMatches.AutoGenerateColumns = false;
            dgvMatches.AllowUserToAddRows = false;
            dgvMatches.AllowUserToDeleteRows = false;
            dgvMatches.ReadOnly = true;
            dgvMatches.MultiSelect = false;
            dgvMatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatches.RowHeadersVisible = false;
            colWinner.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtpDate.Format = DateTimePickerFormat.Short;

            LoadData();
            LoadChampionships();
            LoadTournaments();
            LoadMatches();
            LoadTeamCombos();
            ClearScheduleFields();
            ClearResultFields();

           
            cmbchampionship.SelectedIndexChanged += cmbchampionship_SelectedIndexChanged;
            cmbTournament.SelectedIndexChanged += cmbTournament_SelectedIndexChanged;
            dgvMatches.SelectionChanged += dgvMatches_SelectionChanged;
            btnSchedule.Click += btnSchedule_Click;
            btnRemoveMatch.Click += btnRemoveMatch_Click;
            btnSaveResult.Click += btnSaveResult_Click;
        }

        #region Dados de exemplo

        private void LoadData()
        {
            campeonatos.Add("Liga Portuguesa");
            campeonatos.Add("Campeonato Europeu");

            AddTorneio("Torneio de Inverno", 0);
            AddTorneio("Torneio de Verao", 0);
            AddTorneio("Taca Europa", 1);

           
            AddEquipa("Dragons", 0);
            AddEquipa("Wolves", 0);
            AddEquipa("Falcons", 0);
            
            AddEquipa("Tigers", 1);
            AddEquipa("Sharks", 1);
           
            AddEquipa("Titans", 2);
            AddEquipa("Vikings", 2);
            AddEquipa("Knights", 2);
        }

        private void AddTorneio(string nome, int campeonato)
        {
            torneios.Add(nome);
            torneioCampeonato.Add(campeonato);
        }

        private void AddEquipa(string nome, int torneio)
        {
            equipas.Add(nome);
            equipaTorneio.Add(torneio);
        }

        #endregion

        #region Load

       
        private int CurrentTournament()
        {
            if (cmbTournament.SelectedIndex == -1)
                return -1;

            return torneiosVisiveis[cmbTournament.SelectedIndex];
        }

     
        private int SelectedMatch()
        {
            if (dgvMatches.SelectedRows.Count == 0)
                return -1;

            return (int)dgvMatches.SelectedRows[0].Tag;
        }

        private void SelectFirst(ComboBox combo)
        {
            if (combo.Items.Count > 0)
                combo.SelectedIndex = 0;
            else
                combo.SelectedIndex = -1;
        }

        private void LoadChampionships()
        {
            cmbchampionship.Items.Clear();

            for (int i = 0; i < campeonatos.Count; i++)
                cmbchampionship.Items.Add(campeonatos[i]);

            SelectFirst(cmbchampionship);
        }

        private void LoadTournaments()
        {
            cmbTournament.Items.Clear();
            torneiosVisiveis.Clear();

            int campeonato = cmbchampionship.SelectedIndex;

            for (int i = 0; i < torneios.Count; i++)
            {
                if (torneioCampeonato[i] == campeonato)
                {
                    cmbTournament.Items.Add(torneios[i]);
                    torneiosVisiveis.Add(i);
                }
            }

            SelectFirst(cmbTournament);
        }

        private void LoadMatches()
        {
            loading = true;
            dgvMatches.Rows.Clear();

            int torneio = CurrentTournament();

            for (int i = 0; i < partidaId.Count; i++)
            {
                if (partidaTorneio[i] == torneio)
                {
                    int linha = dgvMatches.Rows.Add(
                        partidaId[i],
                        partidaData[i].ToString("dd/MM/yyyy"),
                        equipas[partidaEquipaA[i]],
                        ResultText(i),
                        equipas[partidaEquipaB[i]],
                        WinnerName(i));

                   
                    dgvMatches.Rows[linha].Tag = i;
                }
            }

            dgvMatches.ClearSelection();
            loading = false;
        }

        private void LoadTeamCombos()
        {
            cmbTeamA.Items.Clear();
            cmbTeamB.Items.Clear();
            equipasVisiveis.Clear();

            int torneio = CurrentTournament();

            for (int i = 0; i < equipas.Count; i++)
            {
                if (equipaTorneio[i] == torneio)
                {
                    cmbTeamA.Items.Add(equipas[i]);
                    cmbTeamB.Items.Add(equipas[i]);
                    equipasVisiveis.Add(i);
                }
            }

            SelectFirst(cmbTeamA);

           

            if (cmbTeamB.Items.Count > 1)
                cmbTeamB.SelectedIndex = 1;
            else
                SelectFirst(cmbTeamB);
        }

        private void ClearScheduleFields()
        {
            nudMatchId.Value = NextMatchId(CurrentTournament());
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

      

        private int NextMatchId(int torneio)
        {
            int maior = 0;

            for (int i = 0; i < partidaId.Count; i++)
            {
                if (partidaTorneio[i] == torneio && partidaId[i] > maior)
                    maior = partidaId[i];
            }

            int proximo = maior + 1;

            if (proximo > nudMatchId.Maximum)
                proximo = (int)nudMatchId.Maximum;

            return proximo;
        }

        private string ResultText(int partida)
        {
            if (partidaResA[partida] == -1)
                return "-";

            return partidaResA[partida] + " - " + partidaResB[partida];
        }

        private string WinnerName(int partida)
        {
            if (partidaResA[partida] == -1)
                return "";

            if (partidaResA[partida] > partidaResB[partida])
                return equipas[partidaEquipaA[partida]];

            if (partidaResA[partida] < partidaResB[partida])
                return equipas[partidaEquipaB[partida]];

            return "Empate";
        }

        #endregion

        #region Events

        private void cmbchampionship_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTournaments();

           

            LoadMatches();
            LoadTeamCombos();
            ClearScheduleFields();
            ClearResultFields();
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
            if (loading)
                return;

            int partida = SelectedMatch();

            if (partida == -1)
                return;

            string nomeA = equipas[partidaEquipaA[partida]];
            string nomeB = equipas[partidaEquipaB[partida]];

            lblSelectedMatch.Text = "Partida " + partidaId[partida] + ": " + nomeA + " vs " + nomeB;
            lblScoreTeamA.Text = nomeA;
            lblScoreTeamB.Text = nomeB;

          

            if (partidaResA[partida] == -1)
            {
                nudScoreA.Value = 0;
                nudScoreB.Value = 0;
            }
            else
            {
                nudScoreA.Value = partidaResA[partida];
                nudScoreB.Value = partidaResB[partida];
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            int torneio = CurrentTournament();

            if (torneio == -1)
            {
                ShowError("Escolha um torneio.");
                return;
            }

            if (cmbTeamA.SelectedIndex == -1 || cmbTeamB.SelectedIndex == -1)
            {
                ShowError("Escolha as duas equipas.");
                return;
            }

            int equipaA = equipasVisiveis[cmbTeamA.SelectedIndex];
            int equipaB = equipasVisiveis[cmbTeamB.SelectedIndex];

            if (equipaA == equipaB)
            {
                ShowError("A equipa A nao pode ser igual a equipa B.");
                return;
            }

            int id = (int)nudMatchId.Value;

           

            for (int i = 0; i < partidaId.Count; i++)
            {
                if (partidaTorneio[i] == torneio && partidaId[i] == id)
                {
                    ShowError("Ja existe uma partida com esse ID neste torneio.");
                    return;
                }
            }

            partidaId.Add(id);
            partidaTorneio.Add(torneio);
            partidaData.Add(dtpDate.Value.Date);
            partidaEquipaA.Add(equipaA);
            partidaEquipaB.Add(equipaB);
            partidaResA.Add(-1);
            partidaResB.Add(-1);

            LoadMatches();
            ClearScheduleFields();
        }

        private void btnRemoveMatch_Click(object sender, EventArgs e)
        {
            int partida = SelectedMatch();

            if (partida == -1)
            {
                ShowError("Escolha uma partida na grelha.");
                return;
            }

            if (MessageBox.Show("Remover a partida " + partidaId[partida] + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            partidaId.RemoveAt(partida);
            partidaTorneio.RemoveAt(partida);
            partidaData.RemoveAt(partida);
            partidaEquipaA.RemoveAt(partida);
            partidaEquipaB.RemoveAt(partida);
            partidaResA.RemoveAt(partida);
            partidaResB.RemoveAt(partida);

            LoadMatches();
            ClearScheduleFields();
            ClearResultFields();
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            int partida = SelectedMatch();

            if (partida == -1)
            {
                ShowError("Escolha uma partida na grelha.");
                return;
            }

            partidaResA[partida] = (int)nudScoreA.Value;
            partidaResB[partida] = (int)nudScoreB.Value;

            LoadMatches();
            ClearResultFields();
        }

        #endregion
    }
}