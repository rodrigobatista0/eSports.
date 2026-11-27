namespace eSports
{
    partial class FormMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConvertXmlToJson = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConvertJsonToXml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTournaments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMatches = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.grpChampionships = new System.Windows.Forms.GroupBox();
            this.btnRemoveChampionship = new System.Windows.Forms.Button();
            this.btnEditChampionship = new System.Windows.Forms.Button();
            this.btnAddChampionship = new System.Windows.Forms.Button();
            this.nudChampionshipYear = new System.Windows.Forms.NumericUpDown();
            this.lblChampionshipYear = new System.Windows.Forms.Label();
            this.txtChampionshipName = new System.Windows.Forms.TextBox();
            this.lblChampionshipName = new System.Windows.Forms.Label();
            this.nudChampionshipId = new System.Windows.Forms.NumericUpDown();
            this.lblChampionshipId = new System.Windows.Forms.Label();
            this.dgvChampionships = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTournaments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOpen = new System.Windows.Forms.GroupBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnMatches = new System.Windows.Forms.Button();
            this.btnTournaments = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAutoSave = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalScores = new System.Windows.Forms.Label();
            this.lblTotalTournaments = new System.Windows.Forms.Label();
            this.lblTotalTeams = new System.Windows.Forms.Label();
            this.lblTotalMatches = new System.Windows.Forms.Label();
            this.lblTotalPlayers = new System.Windows.Forms.Label();
            this.lblScoresText = new System.Windows.Forms.Label();
            this.lblTournamentsText = new System.Windows.Forms.Label();
            this.lblTeamsText = new System.Windows.Forms.Label();
            this.lblPlayersText = new System.Windows.Forms.Label();
            this.lblMatchesText = new System.Windows.Forms.Label();
            this.lblTotalChampionships = new System.Windows.Forms.Label();
            this.lblChampionshipsText = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.grpChampionships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChampionshipYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChampionshipId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChampionships)).BeginInit();
            this.grpOpen.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuManage,
            this.ajudaToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(867, 28);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportXml,
            this.mnuImportJson,
            this.toolStripSeparator1,
            this.mnuExportXml,
            this.mnuExportJson,
            this.toolStripSeparator2,
            this.mnuConvertXmlToJson,
            this.mnuConvertJsonToXml,
            this.toolStripSeparator3,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(75, 24);
            this.mnuFile.Text = "Ficheiro";
            // 
            // mnuImportXml
            // 
            this.mnuImportXml.Name = "mnuImportXml";
            this.mnuImportXml.Size = new System.Drawing.Size(254, 26);
            this.mnuImportXml.Text = "Importar XML...";
            this.mnuImportXml.Click += new System.EventHandler(this.mnuImportXml_Click);
            // 
            // mnuImportJson
            // 
            this.mnuImportJson.Name = "mnuImportJson";
            this.mnuImportJson.Size = new System.Drawing.Size(254, 26);
            this.mnuImportJson.Text = "Importar JSON...";
            this.mnuImportJson.Click += new System.EventHandler(this.mnuImportJson_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuExportXml
            // 
            this.mnuExportXml.Name = "mnuExportXml";
            this.mnuExportXml.Size = new System.Drawing.Size(254, 26);
            this.mnuExportXml.Text = "Exportar XML...";
            this.mnuExportXml.Click += new System.EventHandler(this.mnuExportXml_Click);
            // 
            // mnuExportJson
            // 
            this.mnuExportJson.Name = "mnuExportJson";
            this.mnuExportJson.Size = new System.Drawing.Size(254, 26);
            this.mnuExportJson.Text = "\tExportar JSON...";
            this.mnuExportJson.Click += new System.EventHandler(this.mnuExportJson_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuConvertXmlToJson
            // 
            this.mnuConvertXmlToJson.Name = "mnuConvertXmlToJson";
            this.mnuConvertXmlToJson.Size = new System.Drawing.Size(254, 26);
            this.mnuConvertXmlToJson.Text = "Converter XML → JSON...";
            this.mnuConvertXmlToJson.Click += new System.EventHandler(this.mnuConvertXmlToJson_Click);
            // 
            // mnuConvertJsonToXml
            // 
            this.mnuConvertJsonToXml.Name = "mnuConvertJsonToXml";
            this.mnuConvertJsonToXml.Size = new System.Drawing.Size(254, 26);
            this.mnuConvertJsonToXml.Text = "Converter JSON → XML...";
            this.mnuConvertJsonToXml.Click += new System.EventHandler(this.mnuConvertJsonToXml_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(254, 26);
            this.mnuExit.Text = "Sair";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuManage
            // 
            this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTeams,
            this.mnuTournaments,
            this.mnuMatches,
            this.mnuStatistics});
            this.mnuManage.Name = "mnuManage";
            this.mnuManage.Size = new System.Drawing.Size(69, 24);
            this.mnuManage.Text = "Gestão";
            // 
            // mnuTeams
            // 
            this.mnuTeams.Name = "mnuTeams";
            this.mnuTeams.Size = new System.Drawing.Size(228, 26);
            this.mnuTeams.Text = "Equipas e Jogadores";
            this.mnuTeams.Click += new System.EventHandler(this.mnuTeams_Click);
            // 
            // mnuTournaments
            // 
            this.mnuTournaments.Name = "mnuTournaments";
            this.mnuTournaments.Size = new System.Drawing.Size(228, 26);
            this.mnuTournaments.Text = "Torneios";
            this.mnuTournaments.Click += new System.EventHandler(this.mnuTournaments_Click);
            // 
            // mnuMatches
            // 
            this.mnuMatches.Name = "mnuMatches";
            this.mnuMatches.Size = new System.Drawing.Size(228, 26);
            this.mnuMatches.Text = "Partidas";
            this.mnuMatches.Click += new System.EventHandler(this.mnuMatches_Click);
            // 
            // mnuStatistics
            // 
            this.mnuStatistics.Name = "mnuStatistics";
            this.mnuStatistics.Size = new System.Drawing.Size(228, 26);
            this.mnuStatistics.Text = "Estastísticas";
            this.mnuStatistics.Click += new System.EventHandler(this.mnuStatistics_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogs,
            this.toolStripSeparator4,
            this.mnuAbout});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // mnuLogs
            // 
            this.mnuLogs.Name = "mnuLogs";
            this.mnuLogs.Size = new System.Drawing.Size(224, 26);
            this.mnuLogs.Text = "Resgistos / Logs";
            this.mnuLogs.Click += new System.EventHandler(this.mnuLogs_Click);
            // 
            // grpChampionships
            // 
            this.grpChampionships.Controls.Add(this.btnRemoveChampionship);
            this.grpChampionships.Controls.Add(this.btnEditChampionship);
            this.grpChampionships.Controls.Add(this.btnAddChampionship);
            this.grpChampionships.Controls.Add(this.nudChampionshipYear);
            this.grpChampionships.Controls.Add(this.lblChampionshipYear);
            this.grpChampionships.Controls.Add(this.txtChampionshipName);
            this.grpChampionships.Controls.Add(this.lblChampionshipName);
            this.grpChampionships.Controls.Add(this.nudChampionshipId);
            this.grpChampionships.Controls.Add(this.lblChampionshipId);
            this.grpChampionships.Controls.Add(this.dgvChampionships);
            this.grpChampionships.Location = new System.Drawing.Point(12, 36);
            this.grpChampionships.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChampionships.Name = "grpChampionships";
            this.grpChampionships.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChampionships.Size = new System.Drawing.Size(640, 300);
            this.grpChampionships.TabIndex = 1;
            this.grpChampionships.TabStop = false;
            this.grpChampionships.Text = "Campeonatos";
            // 
            // btnRemoveChampionship
            // 
            this.btnRemoveChampionship.Location = new System.Drawing.Point(224, 240);
            this.btnRemoveChampionship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveChampionship.Name = "btnRemoveChampionship";
            this.btnRemoveChampionship.Size = new System.Drawing.Size(100, 27);
            this.btnRemoveChampionship.TabIndex = 9;
            this.btnRemoveChampionship.Text = "Remover";
            this.btnRemoveChampionship.UseVisualStyleBackColor = true;
            this.btnRemoveChampionship.Click += new System.EventHandler(this.btnRemoveChampionship_Click);
            // 
            // btnEditChampionship
            // 
            this.btnEditChampionship.Location = new System.Drawing.Point(117, 240);
            this.btnEditChampionship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditChampionship.Name = "btnEditChampionship";
            this.btnEditChampionship.Size = new System.Drawing.Size(100, 27);
            this.btnEditChampionship.TabIndex = 8;
            this.btnEditChampionship.Text = "Editar";
            this.btnEditChampionship.UseVisualStyleBackColor = true;
            this.btnEditChampionship.Click += new System.EventHandler(this.btnEditChampionship_Click);
            // 
            // btnAddChampionship
            // 
            this.btnAddChampionship.Location = new System.Drawing.Point(12, 240);
            this.btnAddChampionship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddChampionship.Name = "btnAddChampionship";
            this.btnAddChampionship.Size = new System.Drawing.Size(100, 27);
            this.btnAddChampionship.TabIndex = 7;
            this.btnAddChampionship.Text = "Adicionar";
            this.btnAddChampionship.UseVisualStyleBackColor = true;
            this.btnAddChampionship.Click += new System.EventHandler(this.btnAddChampionship_Click);
            // 
            // nudChampionshipYear
            // 
            this.nudChampionshipYear.Location = new System.Drawing.Point(456, 196);
            this.nudChampionshipYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudChampionshipYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudChampionshipYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudChampionshipYear.Name = "nudChampionshipYear";
            this.nudChampionshipYear.Size = new System.Drawing.Size(80, 22);
            this.nudChampionshipYear.TabIndex = 6;
            this.nudChampionshipYear.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // lblChampionshipYear
            // 
            this.lblChampionshipYear.AutoSize = true;
            this.lblChampionshipYear.Location = new System.Drawing.Point(424, 199);
            this.lblChampionshipYear.Name = "lblChampionshipYear";
            this.lblChampionshipYear.Size = new System.Drawing.Size(31, 16);
            this.lblChampionshipYear.TabIndex = 5;
            this.lblChampionshipYear.Text = "Ano";
            // 
            // txtChampionshipName
            // 
            this.txtChampionshipName.Location = new System.Drawing.Point(168, 196);
            this.txtChampionshipName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChampionshipName.MaxLength = 60;
            this.txtChampionshipName.Name = "txtChampionshipName";
            this.txtChampionshipName.Size = new System.Drawing.Size(240, 22);
            this.txtChampionshipName.TabIndex = 4;
            // 
            // lblChampionshipName
            // 
            this.lblChampionshipName.AutoSize = true;
            this.lblChampionshipName.Location = new System.Drawing.Point(124, 199);
            this.lblChampionshipName.Name = "lblChampionshipName";
            this.lblChampionshipName.Size = new System.Drawing.Size(44, 16);
            this.lblChampionshipName.TabIndex = 3;
            this.lblChampionshipName.Text = "Nome";
            // 
            // nudChampionshipId
            // 
            this.nudChampionshipId.Location = new System.Drawing.Point(40, 196);
            this.nudChampionshipId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudChampionshipId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudChampionshipId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChampionshipId.Name = "nudChampionshipId";
            this.nudChampionshipId.Size = new System.Drawing.Size(69, 22);
            this.nudChampionshipId.TabIndex = 2;
            this.nudChampionshipId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblChampionshipId
            // 
            this.lblChampionshipId.AutoSize = true;
            this.lblChampionshipId.Location = new System.Drawing.Point(12, 199);
            this.lblChampionshipId.Name = "lblChampionshipId";
            this.lblChampionshipId.Size = new System.Drawing.Size(18, 16);
            this.lblChampionshipId.TabIndex = 1;
            this.lblChampionshipId.Text = "Id";
            // 
            // dgvChampionships
            // 
            this.dgvChampionships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChampionships.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colYear,
            this.colTournaments,
            this.colTeams});
            this.dgvChampionships.Location = new System.Drawing.Point(12, 22);
            this.dgvChampionships.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChampionships.Name = "dgvChampionships";
            this.dgvChampionships.ReadOnly = true;
            this.dgvChampionships.RowHeadersWidth = 51;
            this.dgvChampionships.RowTemplate.Height = 24;
            this.dgvChampionships.Size = new System.Drawing.Size(616, 160);
            this.dgvChampionships.TabIndex = 0;
            this.dgvChampionships.SelectionChanged += new System.EventHandler(this.dgvChampionships_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nome";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 260;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Ano";
            this.colYear.MinimumWidth = 6;
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.Width = 70;
            // 
            // colTournaments
            // 
            this.colTournaments.HeaderText = "Torneios";
            this.colTournaments.MinimumWidth = 6;
            this.colTournaments.Name = "colTournaments";
            this.colTournaments.ReadOnly = true;
            this.colTournaments.Width = 125;
            // 
            // colTeams
            // 
            this.colTeams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeams.HeaderText = "Equipas";
            this.colTeams.MinimumWidth = 6;
            this.colTeams.Name = "colTeams";
            this.colTeams.ReadOnly = true;
            // 
            // grpOpen
            // 
            this.grpOpen.Controls.Add(this.btnStatistics);
            this.grpOpen.Controls.Add(this.btnMatches);
            this.grpOpen.Controls.Add(this.btnTournaments);
            this.grpOpen.Controls.Add(this.btnTeams);
            this.grpOpen.Location = new System.Drawing.Point(664, 36);
            this.grpOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOpen.Name = "grpOpen";
            this.grpOpen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOpen.Size = new System.Drawing.Size(208, 180);
            this.grpOpen.TabIndex = 10;
            this.grpOpen.TabStop = false;
            this.grpOpen.Text = "Abrir";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(12, 138);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(184, 30);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Estatísticas";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnMatches
            // 
            this.btnMatches.Location = new System.Drawing.Point(12, 100);
            this.btnMatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(184, 30);
            this.btnMatches.TabIndex = 2;
            this.btnMatches.Text = "Partidas";
            this.btnMatches.UseVisualStyleBackColor = true;
            this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);
            // 
            // btnTournaments
            // 
            this.btnTournaments.Location = new System.Drawing.Point(12, 62);
            this.btnTournaments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTournaments.Name = "btnTournaments";
            this.btnTournaments.Size = new System.Drawing.Size(184, 30);
            this.btnTournaments.TabIndex = 1;
            this.btnTournaments.Text = "Torneios";
            this.btnTournaments.UseVisualStyleBackColor = true;
            this.btnTournaments.Click += new System.EventHandler(this.btnTournaments_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Location = new System.Drawing.Point(12, 25);
            this.btnTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(184, 30);
            this.btnTeams.TabIndex = 0;
            this.btnTeams.Text = "Equipas e Jogadores";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.statusMain);
            this.grpSummary.Controls.Add(this.lblTotalScores);
            this.grpSummary.Controls.Add(this.lblTotalTournaments);
            this.grpSummary.Controls.Add(this.lblTotalTeams);
            this.grpSummary.Controls.Add(this.lblTotalMatches);
            this.grpSummary.Controls.Add(this.lblTotalPlayers);
            this.grpSummary.Controls.Add(this.lblScoresText);
            this.grpSummary.Controls.Add(this.lblTournamentsText);
            this.grpSummary.Controls.Add(this.lblTeamsText);
            this.grpSummary.Controls.Add(this.lblPlayersText);
            this.grpSummary.Controls.Add(this.lblMatchesText);
            this.grpSummary.Controls.Add(this.lblTotalChampionships);
            this.grpSummary.Controls.Add(this.lblChampionshipsText);
            this.grpSummary.Location = new System.Drawing.Point(664, 228);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Size = new System.Drawing.Size(208, 190);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Resumo";
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblAutoSave});
            this.statusMain.Location = new System.Drawing.Point(3, 162);
            this.statusMain.Name = "statusMain";
            this.statusMain.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusMain.Size = new System.Drawing.Size(202, 26);
            this.statusMain.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.Text = "Pronto";
            // 
            // lblAutoSave
            // 
            this.lblAutoSave.ForeColor = System.Drawing.Color.DimGray;
            this.lblAutoSave.Name = "lblAutoSave";
            this.lblAutoSave.Size = new System.Drawing.Size(262, 20);
            this.lblAutoSave.Text = "Guardado automaticamente ao fechar";
            // 
            // lblTotalScores
            // 
            this.lblTotalScores.AutoSize = true;
            this.lblTotalScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScores.Location = new System.Drawing.Point(120, 166);
            this.lblTotalScores.Name = "lblTotalScores";
            this.lblTotalScores.Size = new System.Drawing.Size(15, 16);
            this.lblTotalScores.TabIndex = 11;
            this.lblTotalScores.Text = "0";
            // 
            // lblTotalTournaments
            // 
            this.lblTotalTournaments.AutoSize = true;
            this.lblTotalTournaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTournaments.Location = new System.Drawing.Point(120, 54);
            this.lblTotalTournaments.Name = "lblTotalTournaments";
            this.lblTotalTournaments.Size = new System.Drawing.Size(15, 16);
            this.lblTotalTournaments.TabIndex = 10;
            this.lblTotalTournaments.Text = "0";
            // 
            // lblTotalTeams
            // 
            this.lblTotalTeams.AutoSize = true;
            this.lblTotalTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTeams.Location = new System.Drawing.Point(120, 82);
            this.lblTotalTeams.Name = "lblTotalTeams";
            this.lblTotalTeams.Size = new System.Drawing.Size(15, 16);
            this.lblTotalTeams.TabIndex = 9;
            this.lblTotalTeams.Text = "0";
            // 
            // lblTotalMatches
            // 
            this.lblTotalMatches.AutoSize = true;
            this.lblTotalMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMatches.Location = new System.Drawing.Point(120, 138);
            this.lblTotalMatches.Name = "lblTotalMatches";
            this.lblTotalMatches.Size = new System.Drawing.Size(15, 16);
            this.lblTotalMatches.TabIndex = 8;
            this.lblTotalMatches.Text = "0";
            // 
            // lblTotalPlayers
            // 
            this.lblTotalPlayers.AutoSize = true;
            this.lblTotalPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlayers.Location = new System.Drawing.Point(120, 110);
            this.lblTotalPlayers.Name = "lblTotalPlayers";
            this.lblTotalPlayers.Size = new System.Drawing.Size(15, 16);
            this.lblTotalPlayers.TabIndex = 7;
            this.lblTotalPlayers.Text = "0";
            // 
            // lblScoresText
            // 
            this.lblScoresText.AutoSize = true;
            this.lblScoresText.Location = new System.Drawing.Point(12, 166);
            this.lblScoresText.Name = "lblScoresText";
            this.lblScoresText.Size = new System.Drawing.Size(82, 16);
            this.lblScoresText.TabIndex = 6;
            this.lblScoresText.Text = "Pontuações:";
            // 
            // lblTournamentsText
            // 
            this.lblTournamentsText.AutoSize = true;
            this.lblTournamentsText.Location = new System.Drawing.Point(12, 54);
            this.lblTournamentsText.Name = "lblTournamentsText";
            this.lblTournamentsText.Size = new System.Drawing.Size(64, 16);
            this.lblTournamentsText.TabIndex = 5;
            this.lblTournamentsText.Text = "Torneios:";
            // 
            // lblTeamsText
            // 
            this.lblTeamsText.AutoSize = true;
            this.lblTeamsText.Location = new System.Drawing.Point(12, 82);
            this.lblTeamsText.Name = "lblTeamsText";
            this.lblTeamsText.Size = new System.Drawing.Size(60, 16);
            this.lblTeamsText.TabIndex = 4;
            this.lblTeamsText.Text = "Equipas:";
            // 
            // lblPlayersText
            // 
            this.lblPlayersText.AutoSize = true;
            this.lblPlayersText.Location = new System.Drawing.Point(12, 110);
            this.lblPlayersText.Name = "lblPlayersText";
            this.lblPlayersText.Size = new System.Drawing.Size(76, 16);
            this.lblPlayersText.TabIndex = 3;
            this.lblPlayersText.Text = "Jogadores:";
            // 
            // lblMatchesText
            // 
            this.lblMatchesText.AutoSize = true;
            this.lblMatchesText.Location = new System.Drawing.Point(12, 138);
            this.lblMatchesText.Name = "lblMatchesText";
            this.lblMatchesText.Size = new System.Drawing.Size(60, 16);
            this.lblMatchesText.TabIndex = 2;
            this.lblMatchesText.Text = "Partidas:";
            // 
            // lblTotalChampionships
            // 
            this.lblTotalChampionships.AutoSize = true;
            this.lblTotalChampionships.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalChampionships.Location = new System.Drawing.Point(120, 26);
            this.lblTotalChampionships.Name = "lblTotalChampionships";
            this.lblTotalChampionships.Size = new System.Drawing.Size(15, 16);
            this.lblTotalChampionships.TabIndex = 1;
            this.lblTotalChampionships.Text = "0";
            // 
            // lblChampionshipsText
            // 
            this.lblChampionshipsText.AutoSize = true;
            this.lblChampionshipsText.Location = new System.Drawing.Point(12, 26);
            this.lblChampionshipsText.Name = "lblChampionshipsText";
            this.lblChampionshipsText.Size = new System.Drawing.Size(95, 16);
            this.lblChampionshipsText.TabIndex = 0;
            this.lblChampionshipsText.Text = "Campeonatos:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "\"XML (.xml)|.xml|JSON (.json)|.json\"";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"XML (.xml)|.xml|JSON (.json)|.json\"";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(224, 26);
            this.mnuAbout.Text = "Acerca de...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 423);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpOpen);
            this.Controls.Add(this.grpChampionships);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Campeonatos de eSports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpChampionships.ResumeLayout(false);
            this.grpChampionships.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChampionshipYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChampionshipId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChampionships)).EndInit();
            this.grpOpen.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.GroupBox grpChampionships;
        private System.Windows.Forms.Label lblChampionshipId;
        private System.Windows.Forms.DataGridView dgvChampionships;
        private System.Windows.Forms.Label lblChampionshipYear;
        private System.Windows.Forms.TextBox txtChampionshipName;
        private System.Windows.Forms.Label lblChampionshipName;
        private System.Windows.Forms.NumericUpDown nudChampionshipId;
        private System.Windows.Forms.Button btnRemoveChampionship;
        private System.Windows.Forms.Button btnEditChampionship;
        private System.Windows.Forms.Button btnAddChampionship;
        private System.Windows.Forms.NumericUpDown nudChampionshipYear;
        private System.Windows.Forms.GroupBox grpOpen;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.Button btnTournaments;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblChampionshipsText;
        private System.Windows.Forms.Label lblTotalTournaments;
        private System.Windows.Forms.Label lblTotalTeams;
        private System.Windows.Forms.Label lblTotalMatches;
        private System.Windows.Forms.Label lblTotalPlayers;
        private System.Windows.Forms.Label lblScoresText;
        private System.Windows.Forms.Label lblTournamentsText;
        private System.Windows.Forms.Label lblTeamsText;
        private System.Windows.Forms.Label lblPlayersText;
        private System.Windows.Forms.Label lblMatchesText;
        private System.Windows.Forms.Label lblTotalChampionships;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Label lblTotalScores;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblAutoSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuImportXml;
        private System.Windows.Forms.ToolStripMenuItem mnuImportJson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExportXml;
        private System.Windows.Forms.ToolStripMenuItem mnuExportJson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuConvertXmlToJson;
        private System.Windows.Forms.ToolStripMenuItem mnuConvertJsonToXml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuTeams;
        private System.Windows.Forms.ToolStripMenuItem mnuTournaments;
        private System.Windows.Forms.ToolStripMenuItem mnuMatches;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistics;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTournaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeams;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}