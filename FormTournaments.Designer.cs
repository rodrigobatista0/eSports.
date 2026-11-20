namespace eSports
{
    partial class FormTournaments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChampionship = new System.Windows.Forms.Label();
            this.cmbChampionship = new System.Windows.Forms.ComboBox();
            this.dgvTournaments = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTournamentData = new System.Windows.Forms.GroupBox();
            this.btnClearTournament = new System.Windows.Forms.Button();
            this.btnRemoveTournament = new System.Windows.Forms.Button();
            this.btnEditTournament = new System.Windows.Forms.Button();
            this.btnAddTournament = new System.Windows.Forms.Button();
            this.lblMinTeams = new System.Windows.Forms.Label();
            this.lblEnrolledTeams = new System.Windows.Forms.Label();
            this.lblEnrolledText = new System.Windows.Forms.Label();
            this.cmbGame = new System.Windows.Forms.ComboBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.nudTournamentId = new System.Windows.Forms.NumericUpDown();
            this.lblTournamentId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTournaments)).BeginInit();
            this.grpTournamentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTournamentId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChampionship
            // 
            this.lblChampionship.AutoSize = true;
            this.lblChampionship.Location = new System.Drawing.Point(12, 15);
            this.lblChampionship.Name = "lblChampionship";
            this.lblChampionship.Size = new System.Drawing.Size(95, 20);
            this.lblChampionship.TabIndex = 0;
            this.lblChampionship.Text = "Campeonato";
            // 
            // cmbChampionship
            // 
            this.cmbChampionship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChampionship.FormattingEnabled = true;
            this.cmbChampionship.Location = new System.Drawing.Point(118, 12);
            this.cmbChampionship.Name = "cmbChampionship";
            this.cmbChampionship.Size = new System.Drawing.Size(220, 28);
            this.cmbChampionship.TabIndex = 1;
            this.cmbChampionship.SelectedIndexChanged += new System.EventHandler(this.cmbChampionship_SelectedIndexChanged);
            // 
            // dgvTournaments
            // 
            this.dgvTournaments.AllowUserToAddRows = false;
            this.dgvTournaments.AllowUserToDeleteRows = false;
            this.dgvTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTournaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colGame,
            this.colTeams,
            this.colMatches});
            this.dgvTournaments.Location = new System.Drawing.Point(16, 46);
            this.dgvTournaments.MultiSelect = false;
            this.dgvTournaments.Name = "dgvTournaments";
            this.dgvTournaments.RowHeadersVisible = false;
            this.dgvTournaments.RowHeadersWidth = 51;
            this.dgvTournaments.RowTemplate.Height = 24;
            this.dgvTournaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTournaments.Size = new System.Drawing.Size(500, 225);
            this.dgvTournaments.TabIndex = 2;
            this.dgvTournaments.SelectionChanged += new System.EventHandler(this.dgvTournaments_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nome";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 160;
            // 
            // colGame
            // 
            this.colGame.HeaderText = "Jogo";
            this.colGame.MinimumWidth = 6;
            this.colGame.Name = "colGame";
            this.colGame.Width = 150;
            // 
            // colTeams
            // 
            this.colTeams.HeaderText = "Equipas";
            this.colTeams.MinimumWidth = 6;
            this.colTeams.Name = "colTeams";
            this.colTeams.Width = 60;
            // 
            // colMatches
            // 
            this.colMatches.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMatches.HeaderText = "Partidas";
            this.colMatches.MinimumWidth = 6;
            this.colMatches.Name = "colMatches";
            // 
            // grpTournamentData
            // 
            this.grpTournamentData.Controls.Add(this.btnClearTournament);
            this.grpTournamentData.Controls.Add(this.btnRemoveTournament);
            this.grpTournamentData.Controls.Add(this.btnEditTournament);
            this.grpTournamentData.Controls.Add(this.btnAddTournament);
            this.grpTournamentData.Controls.Add(this.lblMinTeams);
            this.grpTournamentData.Controls.Add(this.lblEnrolledTeams);
            this.grpTournamentData.Controls.Add(this.lblEnrolledText);
            this.grpTournamentData.Controls.Add(this.cmbGame);
            this.grpTournamentData.Controls.Add(this.lblGame);
            this.grpTournamentData.Controls.Add(this.txtTournamentName);
            this.grpTournamentData.Controls.Add(this.lblTournamentName);
            this.grpTournamentData.Controls.Add(this.nudTournamentId);
            this.grpTournamentData.Controls.Add(this.lblTournamentId);
            this.grpTournamentData.Location = new System.Drawing.Point(535, 15);
            this.grpTournamentData.Name = "grpTournamentData";
            this.grpTournamentData.Size = new System.Drawing.Size(295, 256);
            this.grpTournamentData.TabIndex = 3;
            this.grpTournamentData.TabStop = false;
            this.grpTournamentData.Text = "Dados do torneio";
            // 
            // btnClearTournament
            // 
            this.btnClearTournament.Location = new System.Drawing.Point(149, 223);
            this.btnClearTournament.Name = "btnClearTournament";
            this.btnClearTournament.Size = new System.Drawing.Size(140, 27);
            this.btnClearTournament.TabIndex = 11;
            this.btnClearTournament.Text = "Limpar";
            this.btnClearTournament.UseVisualStyleBackColor = true;
            this.btnClearTournament.Click += new System.EventHandler(this.btnClearTournament_Click);
            // 
            // btnRemoveTournament
            // 
            this.btnRemoveTournament.Location = new System.Drawing.Point(10, 223);
            this.btnRemoveTournament.Name = "btnRemoveTournament";
            this.btnRemoveTournament.Size = new System.Drawing.Size(140, 27);
            this.btnRemoveTournament.TabIndex = 10;
            this.btnRemoveTournament.Text = "Remover";
            this.btnRemoveTournament.UseVisualStyleBackColor = true;
            this.btnRemoveTournament.Click += new System.EventHandler(this.btnRemoveTournament_Click);
            // 
            // btnEditTournament
            // 
            this.btnEditTournament.Location = new System.Drawing.Point(149, 190);
            this.btnEditTournament.Name = "btnEditTournament";
            this.btnEditTournament.Size = new System.Drawing.Size(140, 27);
            this.btnEditTournament.TabIndex = 9;
            this.btnEditTournament.Text = "Editar";
            this.btnEditTournament.UseVisualStyleBackColor = true;
            this.btnEditTournament.Click += new System.EventHandler(this.btnEditTournament_Click);
            // 
            // btnAddTournament
            // 
            this.btnAddTournament.Location = new System.Drawing.Point(10, 190);
            this.btnAddTournament.Name = "btnAddTournament";
            this.btnAddTournament.Size = new System.Drawing.Size(140, 27);
            this.btnAddTournament.TabIndex = 8;
            this.btnAddTournament.Text = "Adicionar";
            this.btnAddTournament.UseVisualStyleBackColor = true;
            this.btnAddTournament.Click += new System.EventHandler(this.btnAddTournament_Click);
            // 
            // lblMinTeams
            // 
            this.lblMinTeams.AutoSize = true;
            this.lblMinTeams.ForeColor = System.Drawing.Color.DimGray;
            this.lblMinTeams.Location = new System.Drawing.Point(157, 164);
            this.lblMinTeams.Name = "lblMinTeams";
            this.lblMinTeams.Size = new System.Drawing.Size(82, 20);
            this.lblMinTeams.TabIndex = 7;
            this.lblMinTeams.Text = "(mínimo 4)";
            // 
            // lblEnrolledTeams
            // 
            this.lblEnrolledTeams.AutoSize = true;
            this.lblEnrolledTeams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolledTeams.Location = new System.Drawing.Point(142, 164);
            this.lblEnrolledTeams.Name = "lblEnrolledTeams";
            this.lblEnrolledTeams.Size = new System.Drawing.Size(18, 20);
            this.lblEnrolledTeams.TabIndex = 6;
            this.lblEnrolledTeams.Text = "0";
            // 
            // lblEnrolledText
            // 
            this.lblEnrolledText.AutoSize = true;
            this.lblEnrolledText.Location = new System.Drawing.Point(15, 164);
            this.lblEnrolledText.Name = "lblEnrolledText";
            this.lblEnrolledText.Size = new System.Drawing.Size(121, 20);
            this.lblEnrolledText.TabIndex = 5;
            this.lblEnrolledText.Text = "Equipas inscritas:";
            // 
            // cmbGame
            // 
            this.cmbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGame.FormattingEnabled = true;
            this.cmbGame.Items.AddRange(new object[] {
            "Counter-Strike 2,",
            "Valorant, ",
            "League of Legends, ",
            "Dota 2, ",
            "Rocket League"});
            this.cmbGame.Location = new System.Drawing.Point(79, 125);
            this.cmbGame.Name = "cmbGame";
            this.cmbGame.Size = new System.Drawing.Size(210, 28);
            this.cmbGame.TabIndex = 4;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(14, 125);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(48, 20);
            this.lblGame.TabIndex = 4;
            this.lblGame.Text = "Game";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(79, 73);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(210, 27);
            this.txtTournamentName.TabIndex = 3;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Location = new System.Drawing.Point(14, 77);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(50, 20);
            this.lblTournamentName.TabIndex = 2;
            this.lblTournamentName.Text = "Nome";
            // 
            // nudTournamentId
            // 
            this.nudTournamentId.Location = new System.Drawing.Point(79, 31);
            this.nudTournamentId.Name = "nudTournamentId";
            this.nudTournamentId.Size = new System.Drawing.Size(80, 27);
            this.nudTournamentId.TabIndex = 1;
            // 
            // lblTournamentId
            // 
            this.lblTournamentId.AutoSize = true;
            this.lblTournamentId.Location = new System.Drawing.Point(14, 30);
            this.lblTournamentId.Name = "lblTournamentId";
            this.lblTournamentId.Size = new System.Drawing.Size(22, 20);
            this.lblTournamentId.TabIndex = 0;
            this.lblTournamentId.Text = "Id";
            // 
            // FormTournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 283);
            this.Controls.Add(this.grpTournamentData);
            this.Controls.Add(this.dgvTournaments);
            this.Controls.Add(this.cmbChampionship);
            this.Controls.Add(this.lblChampionship);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTournaments";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torneios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTournaments)).EndInit();
            this.grpTournamentData.ResumeLayout(false);
            this.grpTournamentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTournamentId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChampionship;
        private System.Windows.Forms.ComboBox cmbChampionship;
        private System.Windows.Forms.DataGridView dgvTournaments;
        private System.Windows.Forms.GroupBox grpTournamentData;
        private System.Windows.Forms.ComboBox cmbGame;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.NumericUpDown nudTournamentId;
        private System.Windows.Forms.Label lblTournamentId;
        private System.Windows.Forms.Button btnClearTournament;
        private System.Windows.Forms.Button btnRemoveTournament;
        private System.Windows.Forms.Button btnEditTournament;
        private System.Windows.Forms.Button btnAddTournament;
        private System.Windows.Forms.Label lblMinTeams;
        private System.Windows.Forms.Label lblEnrolledTeams;
        private System.Windows.Forms.Label lblEnrolledText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatches;
    }
}