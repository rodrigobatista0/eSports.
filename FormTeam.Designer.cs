namespace eSports
{
    partial class FormTeam
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
            this.cmbChamp = new System.Windows.Forms.ComboBox();
            this.lblChamp = new System.Windows.Forms.Label();
            this.lblTournament = new System.Windows.Forms.Label();
            this.cmbTournament = new System.Windows.Forms.ComboBox();
            this.tbcTeamsPlayer = new System.Windows.Forms.TabControl();
            this.tbpTeam = new System.Windows.Forms.TabPage();
            this.grbTeamData = new System.Windows.Forms.GroupBox();
            this.txtCountryTeams = new System.Windows.Forms.TextBox();
            this.txtNameTeam = new System.Windows.Forms.TextBox();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdc = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.tbpPlayers = new System.Windows.Forms.TabPage();
            this.txtSearchNick = new System.Windows.Forms.TextBox();
            this.lblSearchNick = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.grbPlayersData = new System.Windows.Forms.GroupBox();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnRemoveScore = new System.Windows.Forms.Button();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.nudAgePlayer = new System.Windows.Forms.NumericUpDown();
            this.txtNickNamePlayer = new System.Windows.Forms.TextBox();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.nudIdPlayer = new System.Windows.Forms.NumericUpDown();
            this.lblPointsPlayers = new System.Windows.Forms.Label();
            this.lblAgePlayer = new System.Windows.Forms.Label();
            this.lblNicknamePlayer = new System.Windows.Forms.Label();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.lblIdPlayers = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.tbcTeamsPlayer.SuspendLayout();
            this.tbpTeam.SuspendLayout();
            this.grbTeamData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.tbpPlayers.SuspendLayout();
            this.grbPlayersData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChamp
            // 
            this.cmbChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChamp.FormattingEnabled = true;
            this.cmbChamp.Location = new System.Drawing.Point(116, 45);
            this.cmbChamp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbChamp.Name = "cmbChamp";
            this.cmbChamp.Size = new System.Drawing.Size(192, 28);
            this.cmbChamp.TabIndex = 0;
            this.cmbChamp.SelectedIndexChanged += new System.EventHandler(this.cmbChamp_SelectedIndexChanged);
            // 
            // lblChamp
            // 
            this.lblChamp.AutoSize = true;
            this.lblChamp.Location = new System.Drawing.Point(12, 49);
            this.lblChamp.Name = "lblChamp";
            this.lblChamp.Size = new System.Drawing.Size(98, 20);
            this.lblChamp.TabIndex = 1;
            this.lblChamp.Text = "Campeonato:";
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Location = new System.Drawing.Point(338, 49);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(62, 20);
            this.lblTournament.TabIndex = 2;
            this.lblTournament.Text = "Torneio:";
            // 
            // cmbTournament
            // 
            this.cmbTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTournament.FormattingEnabled = true;
            this.cmbTournament.Location = new System.Drawing.Point(401, 45);
            this.cmbTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTournament.Name = "cmbTournament";
            this.cmbTournament.Size = new System.Drawing.Size(195, 28);
            this.cmbTournament.TabIndex = 3;
            this.cmbTournament.SelectedIndexChanged += new System.EventHandler(this.cmbTournament_SelectedIndexChanged);
            // 
            // tbcTeamsPlayer
            // 
            this.tbcTeamsPlayer.Controls.Add(this.tbpTeam);
            this.tbcTeamsPlayer.Controls.Add(this.tbpPlayers);
            this.tbcTeamsPlayer.Location = new System.Drawing.Point(12, 96);
            this.tbcTeamsPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcTeamsPlayer.Name = "tbcTeamsPlayer";
            this.tbcTeamsPlayer.SelectedIndex = 0;
            this.tbcTeamsPlayer.Size = new System.Drawing.Size(905, 418);
            this.tbcTeamsPlayer.TabIndex = 4;
            // 
            // tbpTeam
            // 
            this.tbpTeam.Controls.Add(this.grbTeamData);
            this.tbpTeam.Controls.Add(this.dgvTeams);
            this.tbpTeam.Location = new System.Drawing.Point(4, 29);
            this.tbpTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpTeam.Name = "tbpTeam";
            this.tbpTeam.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpTeam.Size = new System.Drawing.Size(897, 385);
            this.tbpTeam.TabIndex = 1;
            this.tbpTeam.Text = "Equipas";
            this.tbpTeam.UseVisualStyleBackColor = true;
            // 
            // grbTeamData
            // 
            this.grbTeamData.Controls.Add(this.txtCountryTeams);
            this.grbTeamData.Controls.Add(this.txtNameTeam);
            this.grbTeamData.Controls.Add(this.nudID);
            this.grbTeamData.Controls.Add(this.btnClean);
            this.grbTeamData.Controls.Add(this.btnRemove);
            this.grbTeamData.Controls.Add(this.btnEdit);
            this.grbTeamData.Controls.Add(this.btnAdc);
            this.grbTeamData.Controls.Add(this.lblCountry);
            this.grbTeamData.Controls.Add(this.lblName);
            this.grbTeamData.Controls.Add(this.lblId);
            this.grbTeamData.Location = new System.Drawing.Point(600, 8);
            this.grbTeamData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTeamData.Name = "grbTeamData";
            this.grbTeamData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTeamData.Size = new System.Drawing.Size(279, 366);
            this.grbTeamData.TabIndex = 6;
            this.grbTeamData.TabStop = false;
            this.grbTeamData.Text = "Dados da Equipa";
            // 
            // txtCountryTeams
            // 
            this.txtCountryTeams.Location = new System.Drawing.Point(70, 146);
            this.txtCountryTeams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountryTeams.MaxLength = 40;
            this.txtCountryTeams.Name = "txtCountryTeams";
            this.txtCountryTeams.Size = new System.Drawing.Size(198, 27);
            this.txtCountryTeams.TabIndex = 9;
            // 
            // txtNameTeam
            // 
            this.txtNameTeam.Location = new System.Drawing.Point(70, 98);
            this.txtNameTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameTeam.MaxLength = 40;
            this.txtNameTeam.Name = "txtNameTeam";
            this.txtNameTeam.Size = new System.Drawing.Size(198, 27);
            this.txtNameTeam.TabIndex = 8;
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(65, 49);
            this.nudID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(69, 27);
            this.nudID.TabIndex = 7;
            this.nudID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(140, 262);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(128, 29);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(6, 262);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 29);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(140, 198);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 58);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdc
            // 
            this.btnAdc.Location = new System.Drawing.Point(6, 198);
            this.btnAdc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(128, 58);
            this.btnAdc.TabIndex = 3;
            this.btnAdc.Text = "Adicionar";
            this.btnAdc.UseVisualStyleBackColor = true;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(17, 150);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(37, 20);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "País:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // dgvTeams
            // 
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Location = new System.Drawing.Point(6, 4);
            this.dgvTeams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersWidth = 51;
            this.dgvTeams.RowTemplate.Height = 24;
            this.dgvTeams.Size = new System.Drawing.Size(574, 370);
            this.dgvTeams.TabIndex = 5;
            // 
            // tbpPlayers
            // 
            this.tbpPlayers.Controls.Add(this.txtSearchNick);
            this.tbpPlayers.Controls.Add(this.lblSearchNick);
            this.tbpPlayers.Controls.Add(this.cmbTeam);
            this.tbpPlayers.Controls.Add(this.lblTeam);
            this.tbpPlayers.Controls.Add(this.grbPlayersData);
            this.tbpPlayers.Controls.Add(this.dgvPlayers);
            this.tbpPlayers.Location = new System.Drawing.Point(4, 29);
            this.tbpPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpPlayers.Name = "tbpPlayers";
            this.tbpPlayers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpPlayers.Size = new System.Drawing.Size(897, 385);
            this.tbpPlayers.TabIndex = 2;
            this.tbpPlayers.Text = "Jogadores";
            this.tbpPlayers.UseVisualStyleBackColor = true;
            // 
            // txtSearchNick
            // 
            this.txtSearchNick.Location = new System.Drawing.Point(409, 15);
            this.txtSearchNick.Name = "txtSearchNick";
            this.txtSearchNick.Size = new System.Drawing.Size(171, 27);
            this.txtSearchNick.TabIndex = 5;
            // 
            // lblSearchNick
            // 
            this.lblSearchNick.AutoSize = true;
            this.lblSearchNick.Location = new System.Drawing.Point(263, 17);
            this.lblSearchNick.Name = "lblSearchNick";
            this.lblSearchNick.Size = new System.Drawing.Size(140, 20);
            this.lblSearchNick.TabIndex = 4;
            this.lblSearchNick.Text = "Pesquisar nickname:";
            // 
            // cmbTeam
            // 
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(70, 14);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(176, 28);
            this.cmbTeam.TabIndex = 3;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(6, 17);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(58, 20);
            this.lblTeam.TabIndex = 2;
            this.lblTeam.Text = "Equipa:";
            // 
            // grbPlayersData
            // 
            this.grbPlayersData.Controls.Add(this.btnRemovePlayer);
            this.grbPlayersData.Controls.Add(this.btnEditPlayer);
            this.grbPlayersData.Controls.Add(this.btnAddPlayer);
            this.grbPlayersData.Controls.Add(this.btnRemoveScore);
            this.grbPlayersData.Controls.Add(this.btnAddScore);
            this.grbPlayersData.Controls.Add(this.nudScore);
            this.grbPlayersData.Controls.Add(this.lstScores);
            this.grbPlayersData.Controls.Add(this.nudAgePlayer);
            this.grbPlayersData.Controls.Add(this.txtNickNamePlayer);
            this.grbPlayersData.Controls.Add(this.txtNamePlayer);
            this.grbPlayersData.Controls.Add(this.nudIdPlayer);
            this.grbPlayersData.Controls.Add(this.lblPointsPlayers);
            this.grbPlayersData.Controls.Add(this.lblAgePlayer);
            this.grbPlayersData.Controls.Add(this.lblNicknamePlayer);
            this.grbPlayersData.Controls.Add(this.lblNamePlayer);
            this.grbPlayersData.Controls.Add(this.lblIdPlayers);
            this.grbPlayersData.Location = new System.Drawing.Point(600, 8);
            this.grbPlayersData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPlayersData.Name = "grbPlayersData";
            this.grbPlayersData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPlayersData.Size = new System.Drawing.Size(291, 366);
            this.grbPlayersData.TabIndex = 1;
            this.grbPlayersData.TabStop = false;
            this.grbPlayersData.Text = "Dados do Jogador";
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(199, 319);
            this.btnRemovePlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(88, 40);
            this.btnRemovePlayer.TabIndex = 14;
            this.btnRemovePlayer.Text = "Remover";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(111, 319);
            this.btnEditPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(82, 40);
            this.btnEditPlayer.TabIndex = 13;
            this.btnEditPlayer.Text = "Editar";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(11, 319);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(94, 40);
            this.btnAddPlayer.TabIndex = 12;
            this.btnAddPlayer.Text = "Adicionar";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveScore
            // 
            this.btnRemoveScore.Location = new System.Drawing.Point(237, 232);
            this.btnRemoveScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveScore.Name = "btnRemoveScore";
            this.btnRemoveScore.Size = new System.Drawing.Size(48, 50);
            this.btnRemoveScore.TabIndex = 11;
            this.btnRemoveScore.Text = "-";
            this.btnRemoveScore.UseVisualStyleBackColor = true;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(185, 232);
            this.btnAddScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(46, 50);
            this.btnAddScore.TabIndex = 10;
            this.btnAddScore.Text = "+";
            this.btnAddScore.UseVisualStyleBackColor = true;
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(185, 198);
            this.nudScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(100, 27);
            this.nudScore.TabIndex = 2;
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 20;
            this.lstScores.Location = new System.Drawing.Point(107, 198);
            this.lstScores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(72, 84);
            this.lstScores.TabIndex = 9;
            // 
            // nudAgePlayer
            // 
            this.nudAgePlayer.Location = new System.Drawing.Point(111, 154);
            this.nudAgePlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAgePlayer.Name = "nudAgePlayer";
            this.nudAgePlayer.Size = new System.Drawing.Size(120, 27);
            this.nudAgePlayer.TabIndex = 8;
            // 
            // txtNickNamePlayer
            // 
            this.txtNickNamePlayer.Location = new System.Drawing.Point(111, 112);
            this.txtNickNamePlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNickNamePlayer.Name = "txtNickNamePlayer";
            this.txtNickNamePlayer.Size = new System.Drawing.Size(174, 27);
            this.txtNickNamePlayer.TabIndex = 7;
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Location = new System.Drawing.Point(111, 76);
            this.txtNamePlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.Size = new System.Drawing.Size(174, 27);
            this.txtNamePlayer.TabIndex = 6;
            // 
            // nudIdPlayer
            // 
            this.nudIdPlayer.Location = new System.Drawing.Point(111, 39);
            this.nudIdPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudIdPlayer.Name = "nudIdPlayer";
            this.nudIdPlayer.Size = new System.Drawing.Size(120, 27);
            this.nudIdPlayer.TabIndex = 5;
            // 
            // lblPointsPlayers
            // 
            this.lblPointsPlayers.AutoSize = true;
            this.lblPointsPlayers.Location = new System.Drawing.Point(19, 198);
            this.lblPointsPlayers.Name = "lblPointsPlayers";
            this.lblPointsPlayers.Size = new System.Drawing.Size(87, 20);
            this.lblPointsPlayers.TabIndex = 4;
            this.lblPointsPlayers.Text = "Pontuações:";
            // 
            // lblAgePlayer
            // 
            this.lblAgePlayer.AutoSize = true;
            this.lblAgePlayer.Location = new System.Drawing.Point(17, 154);
            this.lblAgePlayer.Name = "lblAgePlayer";
            this.lblAgePlayer.Size = new System.Drawing.Size(50, 20);
            this.lblAgePlayer.TabIndex = 3;
            this.lblAgePlayer.Text = "Idade:";
            // 
            // lblNicknamePlayer
            // 
            this.lblNicknamePlayer.AutoSize = true;
            this.lblNicknamePlayer.Location = new System.Drawing.Point(15, 116);
            this.lblNicknamePlayer.Name = "lblNicknamePlayer";
            this.lblNicknamePlayer.Size = new System.Drawing.Size(78, 20);
            this.lblNicknamePlayer.TabIndex = 2;
            this.lblNicknamePlayer.Text = "Nickname:";
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Location = new System.Drawing.Point(15, 80);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(53, 20);
            this.lblNamePlayer.TabIndex = 1;
            this.lblNamePlayer.Text = "Nome:";
            // 
            // lblIdPlayers
            // 
            this.lblIdPlayers.AutoSize = true;
            this.lblIdPlayers.Location = new System.Drawing.Point(15, 41);
            this.lblIdPlayers.Name = "lblIdPlayers";
            this.lblIdPlayers.Size = new System.Drawing.Size(27, 20);
            this.lblIdPlayers.TabIndex = 0;
            this.lblIdPlayers.Text = "ID:";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(6, 49);
            this.dgvPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.RowTemplate.Height = 24;
            this.dgvPlayers.Size = new System.Drawing.Size(574, 325);
            this.dgvPlayers.TabIndex = 0;
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 529);
            this.Controls.Add(this.tbcTeamsPlayer);
            this.Controls.Add(this.cmbTournament);
            this.Controls.Add(this.lblTournament);
            this.Controls.Add(this.lblChamp);
            this.Controls.Add(this.cmbChamp);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTeam";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipas e Jogadores";
            this.tbcTeamsPlayer.ResumeLayout(false);
            this.tbpTeam.ResumeLayout(false);
            this.grbTeamData.ResumeLayout(false);
            this.grbTeamData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.tbpPlayers.ResumeLayout(false);
            this.tbpPlayers.PerformLayout();
            this.grbPlayersData.ResumeLayout(false);
            this.grbPlayersData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChamp;
        private System.Windows.Forms.Label lblChamp;
        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.ComboBox cmbTournament;
        private System.Windows.Forms.TabControl tbcTeamsPlayer;
        private System.Windows.Forms.TabPage tbpTeam;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.GroupBox grbTeamData;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.TextBox txtCountryTeams;
        private System.Windows.Forms.TextBox txtNameTeam;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.TabPage tbpPlayers;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.GroupBox grbPlayersData;
        private System.Windows.Forms.Label lblPointsPlayers;
        private System.Windows.Forms.Label lblAgePlayer;
        private System.Windows.Forms.Label lblNicknamePlayer;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.Label lblIdPlayers;
        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.NumericUpDown nudAgePlayer;
        private System.Windows.Forms.TextBox txtNickNamePlayer;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.NumericUpDown nudIdPlayer;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnRemoveScore;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.TextBox txtSearchNick;
        private System.Windows.Forms.Label lblSearchNick;
    }
}
