namespace eSports
{
    partial class FormMatches
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
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblMatchId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.lblSelectedMatch = new System.Windows.Forms.Label();
            this.lblScoreTeamA = new System.Windows.Forms.Label();
            this.lblScoreTeamB = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.cmbchampionship = new System.Windows.Forms.ComboBox();
            this.cmbTournament = new System.Windows.Forms.ComboBox();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWinner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.btnRemoveMatch = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.cmbTeamB = new System.Windows.Forms.ComboBox();
            this.cmbTeamA = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudMatchId = new System.Windows.Forms.NumericUpDown();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.nudScoreB = new System.Windows.Forms.NumericUpDown();
            this.nudScoreA = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.grpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatchId)).BeginInit();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChampionship
            // 
            this.lblChampionship.AutoSize = true;
            this.lblChampionship.Location = new System.Drawing.Point(14, 20);
            this.lblChampionship.Name = "lblChampionship";
            this.lblChampionship.Size = new System.Drawing.Size(95, 20);
            this.lblChampionship.TabIndex = 0;
            this.lblChampionship.Text = "Campeonato";
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Location = new System.Drawing.Point(368, 20);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(59, 20);
            this.lblTournament.TabIndex = 1;
            this.lblTournament.Text = "Torneio";
            // 
            // lblMatchId
            // 
            this.lblMatchId.AutoSize = true;
            this.lblMatchId.Location = new System.Drawing.Point(14, 30);
            this.lblMatchId.Name = "lblMatchId";
            this.lblMatchId.Size = new System.Drawing.Size(24, 20);
            this.lblMatchId.TabIndex = 2;
            this.lblMatchId.Text = "\tID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(170, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Dados";
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.Location = new System.Drawing.Point(14, 66);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(69, 20);
            this.lblTeamA.TabIndex = 4;
            this.lblTeamA.Text = "Equipa A";
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Location = new System.Drawing.Point(230, 66);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(22, 20);
            this.lblVs.TabIndex = 5;
            this.lblVs.Text = "vs";
            // 
            // lblSelectedMatch
            // 
            this.lblSelectedMatch.AutoSize = true;
            this.lblSelectedMatch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedMatch.Location = new System.Drawing.Point(14, 30);
            this.lblSelectedMatch.Name = "lblSelectedMatch";
            this.lblSelectedMatch.Size = new System.Drawing.Size(230, 20);
            this.lblSelectedMatch.TabIndex = 6;
            this.lblSelectedMatch.Text = "Partida: (nenhuma selecionada)";
            // 
            // lblScoreTeamA
            // 
            this.lblScoreTeamA.AutoSize = true;
            this.lblScoreTeamA.Location = new System.Drawing.Point(14, 70);
            this.lblScoreTeamA.Name = "lblScoreTeamA";
            this.lblScoreTeamA.Size = new System.Drawing.Size(69, 20);
            this.lblScoreTeamA.TabIndex = 7;
            this.lblScoreTeamA.Text = "Equipa A";
            // 
            // lblScoreTeamB
            // 
            this.lblScoreTeamB.AutoSize = true;
            this.lblScoreTeamB.Location = new System.Drawing.Point(200, 70);
            this.lblScoreTeamB.Name = "lblScoreTeamB";
            this.lblScoreTeamB.Size = new System.Drawing.Size(68, 20);
            this.lblScoreTeamB.TabIndex = 8;
            this.lblScoreTeamB.Text = "Equipa B";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarning.Location = new System.Drawing.Point(12, 406);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(613, 20);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "Só aparecem equipamentos inscritos no torneio. A equipe A não pode ser igual à eq" +
    "uipe B.";
            // 
            // cmbchampionship
            // 
            this.cmbchampionship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbchampionship.FormattingEnabled = true;
            this.cmbchampionship.Location = new System.Drawing.Point(123, 12);
            this.cmbchampionship.Name = "cmbchampionship";
            this.cmbchampionship.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbchampionship.Size = new System.Drawing.Size(210, 28);
            this.cmbchampionship.TabIndex = 10;
            this.cmbchampionship.SelectedIndexChanged += new System.EventHandler(this.cmbchampionship_SelectedIndexChanged);
            // 
            // cmbTournament
            // 
            this.cmbTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTournament.FormattingEnabled = true;
            this.cmbTournament.Location = new System.Drawing.Point(444, 12);
            this.cmbTournament.Name = "cmbTournament";
            this.cmbTournament.Size = new System.Drawing.Size(200, 28);
            this.cmbTournament.TabIndex = 11;
            this.cmbTournament.SelectedIndexChanged += new System.EventHandler(this.cmbchampionship_SelectedIndexChanged);
            // 
            // dgvMatches
            // 
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDate,
            this.colTeamA,
            this.colResult,
            this.colTeamB,
            this.colWinner});
            this.dgvMatches.Location = new System.Drawing.Point(12, 44);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.RowHeadersWidth = 51;
            this.dgvMatches.RowTemplate.Height = 24;
            this.dgvMatches.Size = new System.Drawing.Size(860, 190);
            this.dgvMatches.TabIndex = 12;
            this.dgvMatches.SelectionChanged += new System.EventHandler(this.dgvMatches_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Width = 40;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Data";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.Width = 90;
            // 
            // colTeamA
            // 
            this.colTeamA.HeaderText = "EquipaA";
            this.colTeamA.MinimumWidth = 6;
            this.colTeamA.Name = "colTeamA";
            this.colTeamA.Width = 150;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "Resultado";
            this.colResult.MinimumWidth = 6;
            this.colResult.Name = "colResult";
            this.colResult.Width = 80;
            // 
            // colTeamB
            // 
            this.colTeamB.HeaderText = "EquipaB";
            this.colTeamB.MinimumWidth = 6;
            this.colTeamB.Name = "colTeamB";
            this.colTeamB.Width = 150;
            // 
            // colWinner
            // 
            this.colWinner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colWinner.HeaderText = "Vencedor";
            this.colWinner.MinimumWidth = 6;
            this.colWinner.Name = "colWinner";
            // 
            // grpSchedule
            // 
            this.grpSchedule.Controls.Add(this.btnRemoveMatch);
            this.grpSchedule.Controls.Add(this.btnSchedule);
            this.grpSchedule.Controls.Add(this.cmbTeamB);
            this.grpSchedule.Controls.Add(this.cmbTeamA);
            this.grpSchedule.Controls.Add(this.dtpDate);
            this.grpSchedule.Controls.Add(this.nudMatchId);
            this.grpSchedule.Controls.Add(this.lblMatchId);
            this.grpSchedule.Controls.Add(this.lblDate);
            this.grpSchedule.Controls.Add(this.lblTeamA);
            this.grpSchedule.Controls.Add(this.lblVs);
            this.grpSchedule.Location = new System.Drawing.Point(12, 246);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(420, 150);
            this.grpSchedule.TabIndex = 13;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Agendar partida";
            // 
            // btnRemoveMatch
            // 
            this.btnRemoveMatch.Location = new System.Drawing.Point(130, 106);
            this.btnRemoveMatch.Name = "btnRemoveMatch";
            this.btnRemoveMatch.Size = new System.Drawing.Size(130, 27);
            this.btnRemoveMatch.TabIndex = 9;
            this.btnRemoveMatch.Text = "Remover partida";
            this.btnRemoveMatch.UseVisualStyleBackColor = true;
            this.btnRemoveMatch.Click += new System.EventHandler(this.btnRemoveMatch_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(14, 106);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(110, 27);
            this.btnSchedule.TabIndex = 8;
            this.btnSchedule.Text = "Agenda";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // cmbTeamB
            // 
            this.cmbTeamB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamB.FormattingEnabled = true;
            this.cmbTeamB.Location = new System.Drawing.Point(256, 62);
            this.cmbTeamB.Name = "cmbTeamB";
            this.cmbTeamB.Size = new System.Drawing.Size(140, 28);
            this.cmbTeamB.TabIndex = 7;
            // 
            // cmbTeamA
            // 
            this.cmbTeamA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamA.FormattingEnabled = true;
            this.cmbTeamA.Location = new System.Drawing.Point(80, 62);
            this.cmbTeamA.Name = "cmbTeamA";
            this.cmbTeamA.Size = new System.Drawing.Size(140, 28);
            this.cmbTeamA.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(228, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(130, 27);
            this.dtpDate.TabIndex = 4;
            // 
            // nudMatchId
            // 
            this.nudMatchId.Location = new System.Drawing.Point(80, 26);
            this.nudMatchId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMatchId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMatchId.Name = "nudMatchId";
            this.nudMatchId.Size = new System.Drawing.Size(70, 27);
            this.nudMatchId.TabIndex = 3;
            this.nudMatchId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.btnSaveResult);
            this.grpResult.Controls.Add(this.nudScoreB);
            this.grpResult.Controls.Add(this.nudScoreA);
            this.grpResult.Controls.Add(this.lblSelectedMatch);
            this.grpResult.Controls.Add(this.lblScoreTeamA);
            this.grpResult.Controls.Add(this.lblScoreTeamB);
            this.grpResult.Location = new System.Drawing.Point(446, 246);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(426, 150);
            this.grpResult.TabIndex = 14;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Registrar resultado";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(14, 106);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(150, 27);
            this.btnSaveResult.TabIndex = 11;
            this.btnSaveResult.Text = "Salvar resultado";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // nudScoreB
            // 
            this.nudScoreB.Location = new System.Drawing.Point(286, 66);
            this.nudScoreB.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudScoreB.Name = "nudScoreB";
            this.nudScoreB.Size = new System.Drawing.Size(70, 27);
            this.nudScoreB.TabIndex = 10;
            // 
            // nudScoreA
            // 
            this.nudScoreA.Location = new System.Drawing.Point(100, 66);
            this.nudScoreA.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudScoreA.Name = "nudScoreA";
            this.nudScoreA.Size = new System.Drawing.Size(70, 27);
            this.nudScoreA.TabIndex = 9;
            // 
            // FormMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 486);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.cmbTournament);
            this.Controls.Add(this.cmbchampionship);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblTournament);
            this.Controls.Add(this.lblChampionship);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMatches";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidas";
            this.Load += new System.EventHandler(this.FormMatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatchId)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChampionship;
        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.Label lblMatchId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblSelectedMatch;
        private System.Windows.Forms.Label lblScoreTeamA;
        private System.Windows.Forms.Label lblScoreTeamB;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ComboBox cmbchampionship;
        private System.Windows.Forms.ComboBox cmbTournament;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.NumericUpDown nudMatchId;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnRemoveMatch;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.ComboBox cmbTeamB;
        private System.Windows.Forms.ComboBox cmbTeamA;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.NumericUpDown nudScoreA;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.NumericUpDown nudScoreB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWinner;
    }
}