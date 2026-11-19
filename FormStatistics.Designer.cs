namespace eSports
{
    partial class FormStatistics
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
            this.lblTournamentFilter = new System.Windows.Forms.Label();
            this.cmbTournamentFilter = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpStandings = new System.Windows.Forms.TabPage();
            this.tpTop3 = new System.Windows.Forms.TabPage();
            this.dgvStandings = new System.Windows.Forms.DataGridView();
            this.lblStandingsHint = new System.Windows.Forms.Label();
            this.lblOverallAverageText = new System.Windows.Forms.Label();
            this.lblOverallAverage = new System.Windows.Forms.Label();
            this.lblPlayersCountText = new System.Windows.Forms.Label();
            this.lblPlayersCount = new System.Windows.Forms.Label();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResultsCount = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLosses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTop3 = new System.Windows.Forms.DataGridView();
            this.colNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTournament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverage1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMain.SuspendLayout();
            this.tpStandings.SuspendLayout();
            this.tpTop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).BeginInit();
            this.tpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTournamentFilter
            // 
            this.lblTournamentFilter.AutoSize = true;
            this.lblTournamentFilter.Location = new System.Drawing.Point(12, 11);
            this.lblTournamentFilter.Name = "lblTournamentFilter";
            this.lblTournamentFilter.Size = new System.Drawing.Size(126, 20);
            this.lblTournamentFilter.TabIndex = 0;
            this.lblTournamentFilter.Text = "\tFiltrar por torneio";
            // 
            // cmbTournamentFilter
            // 
            this.cmbTournamentFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTournamentFilter.FormattingEnabled = true;
            this.cmbTournamentFilter.Location = new System.Drawing.Point(144, 8);
            this.cmbTournamentFilter.Name = "cmbTournamentFilter";
            this.cmbTournamentFilter.Size = new System.Drawing.Size(220, 28);
            this.cmbTournamentFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(370, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 27);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpStandings);
            this.tabMain.Controls.Add(this.tpTop3);
            this.tabMain.Controls.Add(this.tpSearch);
            this.tabMain.Location = new System.Drawing.Point(16, 42);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(814, 329);
            this.tabMain.TabIndex = 3;
            // 
            // tpStandings
            // 
            this.tpStandings.Controls.Add(this.lblStandingsHint);
            this.tpStandings.Controls.Add(this.dgvStandings);
            this.tpStandings.Location = new System.Drawing.Point(4, 29);
            this.tpStandings.Name = "tpStandings";
            this.tpStandings.Padding = new System.Windows.Forms.Padding(3);
            this.tpStandings.Size = new System.Drawing.Size(806, 296);
            this.tpStandings.TabIndex = 0;
            this.tpStandings.Text = "Classificação";
            this.tpStandings.UseVisualStyleBackColor = true;
            // 
            // tpTop3
            // 
            this.tpTop3.Controls.Add(this.dgvTop3);
            this.tpTop3.Controls.Add(this.lblPlayersCount);
            this.tpTop3.Controls.Add(this.lblPlayersCountText);
            this.tpTop3.Controls.Add(this.lblOverallAverage);
            this.tpTop3.Controls.Add(this.lblOverallAverageText);
            this.tpTop3.Location = new System.Drawing.Point(4, 29);
            this.tpTop3.Name = "tpTop3";
            this.tpTop3.Padding = new System.Windows.Forms.Padding(3);
            this.tpTop3.Size = new System.Drawing.Size(806, 296);
            this.tpTop3.TabIndex = 1;
            this.tpTop3.Text = "Top 3 jogadores";
            this.tpTop3.UseVisualStyleBackColor = true;
            // 
            // dgvStandings
            // 
            this.dgvStandings.AllowUserToAddRows = false;
            this.dgvStandings.AllowUserToDeleteRows = false;
            this.dgvStandings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPosition,
            this.colTeam,
            this.colPlayed,
            this.colWins,
            this.colLosses,
            this.colAverage});
            this.dgvStandings.Location = new System.Drawing.Point(6, 6);
            this.dgvStandings.MultiSelect = false;
            this.dgvStandings.Name = "dgvStandings";
            this.dgvStandings.ReadOnly = true;
            this.dgvStandings.RowHeadersVisible = false;
            this.dgvStandings.RowHeadersWidth = 51;
            this.dgvStandings.RowTemplate.Height = 24;
            this.dgvStandings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStandings.Size = new System.Drawing.Size(794, 258);
            this.dgvStandings.TabIndex = 0;
            // 
            // lblStandingsHint
            // 
            this.lblStandingsHint.AutoSize = true;
            this.lblStandingsHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblStandingsHint.Location = new System.Drawing.Point(6, 267);
            this.lblStandingsHint.Name = "lblStandingsHint";
            this.lblStandingsHint.Size = new System.Drawing.Size(214, 20);
            this.lblStandingsHint.TabIndex = 4;
            this.lblStandingsHint.Text = "Vitória = 3 pontos, derrota = 0.";
            // 
            // lblOverallAverageText
            // 
            this.lblOverallAverageText.AutoSize = true;
            this.lblOverallAverageText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOverallAverageText.Location = new System.Drawing.Point(6, 269);
            this.lblOverallAverageText.Name = "lblOverallAverageText";
            this.lblOverallAverageText.Size = new System.Drawing.Size(194, 20);
            this.lblOverallAverageText.TabIndex = 6;
            this.lblOverallAverageText.Text = "Média geral de pontuações:";
            // 
            // lblOverallAverage
            // 
            this.lblOverallAverage.AutoSize = true;
            this.lblOverallAverage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallAverage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOverallAverage.Location = new System.Drawing.Point(206, 269);
            this.lblOverallAverage.Name = "lblOverallAverage";
            this.lblOverallAverage.Size = new System.Drawing.Size(18, 20);
            this.lblOverallAverage.TabIndex = 7;
            this.lblOverallAverage.Text = "0";
            // 
            // lblPlayersCountText
            // 
            this.lblPlayersCountText.AutoSize = true;
            this.lblPlayersCountText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayersCountText.Location = new System.Drawing.Point(230, 269);
            this.lblPlayersCountText.Name = "lblPlayersCountText";
            this.lblPlayersCountText.Size = new System.Drawing.Size(80, 20);
            this.lblPlayersCountText.TabIndex = 8;
            this.lblPlayersCountText.Text = "Jogadores:";
            // 
            // lblPlayersCount
            // 
            this.lblPlayersCount.AutoSize = true;
            this.lblPlayersCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayersCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayersCount.Location = new System.Drawing.Point(316, 269);
            this.lblPlayersCount.Name = "lblPlayersCount";
            this.lblPlayersCount.Size = new System.Drawing.Size(18, 20);
            this.lblPlayersCount.TabIndex = 9;
            this.lblPlayersCount.Text = "0";
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.dgvSearchResults);
            this.tpSearch.Controls.Add(this.lblResultsCount);
            this.tpSearch.Controls.Add(this.btnSearch);
            this.tpSearch.Controls.Add(this.txtSearch);
            this.tpSearch.Controls.Add(this.lblSearch);
            this.tpSearch.Location = new System.Drawing.Point(4, 29);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(806, 296);
            this.tpSearch.TabIndex = 2;
            this.tpSearch.Text = "Pesquisar nickname";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 20);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Nickname";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(87, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(293, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblResultsCount
            // 
            this.lblResultsCount.AutoSize = true;
            this.lblResultsCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblResultsCount.Location = new System.Drawing.Point(394, 12);
            this.lblResultsCount.Name = "lblResultsCount";
            this.lblResultsCount.Size = new System.Drawing.Size(89, 20);
            this.lblResultsCount.TabIndex = 6;
            this.lblResultsCount.Text = "0 resultados";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(6, 42);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.RowTemplate.Height = 24;
            this.dgvSearchResults.Size = new System.Drawing.Size(794, 248);
            this.dgvSearchResults.TabIndex = 7;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Pos.";
            this.colPosition.MinimumWidth = 6;
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.Width = 50;
            // 
            // colTeam
            // 
            this.colTeam.HeaderText = "Equipa";
            this.colTeam.MinimumWidth = 6;
            this.colTeam.Name = "colTeam";
            this.colTeam.ReadOnly = true;
            this.colTeam.Width = 200;
            // 
            // colPlayed
            // 
            this.colPlayed.HeaderText = "Jogos";
            this.colPlayed.MinimumWidth = 6;
            this.colPlayed.Name = "colPlayed";
            this.colPlayed.ReadOnly = true;
            this.colPlayed.Width = 70;
            // 
            // colWins
            // 
            this.colWins.HeaderText = "Vitórias";
            this.colWins.MinimumWidth = 6;
            this.colWins.Name = "colWins";
            this.colWins.ReadOnly = true;
            this.colWins.Width = 80;
            // 
            // colLosses
            // 
            this.colLosses.HeaderText = "Derrotas";
            this.colLosses.MinimumWidth = 6;
            this.colLosses.Name = "colLosses";
            this.colLosses.ReadOnly = true;
            this.colLosses.Width = 80;
            // 
            // colAverage
            // 
            this.colAverage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAverage.HeaderText = "Média rondas";
            this.colAverage.MinimumWidth = 6;
            this.colAverage.Name = "colAverage";
            this.colAverage.ReadOnly = true;
            // 
            // dgvTop3
            // 
            this.dgvTop3.AllowUserToAddRows = false;
            this.dgvTop3.AllowUserToDeleteRows = false;
            this.dgvTop3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNickname,
            this.colName,
            this.colAge,
            this.colTeam1,
            this.colTournament,
            this.colAverage1});
            this.dgvTop3.Location = new System.Drawing.Point(6, 8);
            this.dgvTop3.MultiSelect = false;
            this.dgvTop3.Name = "dgvTop3";
            this.dgvTop3.ReadOnly = true;
            this.dgvTop3.RowHeadersVisible = false;
            this.dgvTop3.RowHeadersWidth = 51;
            this.dgvTop3.RowTemplate.Height = 24;
            this.dgvTop3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTop3.Size = new System.Drawing.Size(794, 258);
            this.dgvTop3.TabIndex = 10;
            // 
            // colNickname
            // 
            this.colNickname.HeaderText = "Nickname";
            this.colNickname.MinimumWidth = 6;
            this.colNickname.Name = "colNickname";
            this.colNickname.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nome";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 140;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Idade";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            this.colAge.Width = 50;
            // 
            // colTeam1
            // 
            this.colTeam1.HeaderText = "Equipa";
            this.colTeam1.MinimumWidth = 6;
            this.colTeam1.Name = "colTeam1";
            this.colTeam1.ReadOnly = true;
            this.colTeam1.Width = 110;
            // 
            // colTournament
            // 
            this.colTournament.HeaderText = "Torneio";
            this.colTournament.MinimumWidth = 6;
            this.colTournament.Name = "colTournament";
            this.colTournament.ReadOnly = true;
            this.colTournament.Width = 130;
            // 
            // colAverage1
            // 
            this.colAverage1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAverage1.HeaderText = "Média";
            this.colAverage1.MinimumWidth = 6;
            this.colAverage1.Name = "colAverage1";
            this.colAverage1.ReadOnly = true;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 383);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbTournamentFilter);
            this.Controls.Add(this.lblTournamentFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatistics";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStatistics";
            this.tabMain.ResumeLayout(false);
            this.tpStandings.ResumeLayout(false);
            this.tpStandings.PerformLayout();
            this.tpTop3.ResumeLayout(false);
            this.tpTop3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).EndInit();
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournamentFilter;
        private System.Windows.Forms.ComboBox cmbTournamentFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpStandings;
        private System.Windows.Forms.DataGridView dgvStandings;
        private System.Windows.Forms.TabPage tpTop3;
        private System.Windows.Forms.Label lblStandingsHint;
        private System.Windows.Forms.Label lblOverallAverage;
        private System.Windows.Forms.Label lblOverallAverageText;
        private System.Windows.Forms.Label lblPlayersCount;
        private System.Windows.Forms.Label lblPlayersCountText;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Label lblResultsCount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLosses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverage;
        private System.Windows.Forms.DataGridView dgvTop3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTournament;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverage1;
    }
}