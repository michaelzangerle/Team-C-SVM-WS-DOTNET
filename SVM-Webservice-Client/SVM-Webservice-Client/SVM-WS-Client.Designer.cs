namespace SVM_Webservice_Client
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnSearchTeams = new System.Windows.Forms.Button();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvContests = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contestDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.startDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultHomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultAwayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(91, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Suche mit Datum:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(122, 18);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(201, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(345, 15);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDate.TabIndex = 2;
            this.btnSearchDate.Text = "Suchen";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // btnSearchTeams
            // 
            this.btnSearchTeams.Location = new System.Drawing.Point(426, 15);
            this.btnSearchTeams.Name = "btnSearchTeams";
            this.btnSearchTeams.Size = new System.Drawing.Size(103, 23);
            this.btnSearchTeams.TabIndex = 3;
            this.btnSearchTeams.Text = "Teams anzeigen";
            this.btnSearchTeams.UseVisualStyleBackColor = true;
            this.btnSearchTeams.Click += new System.EventHandler(this.btnSearchTeams_Click);
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.AutoGenerateColumns = false;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvTeams.DataSource = this.teamDTOBindingSource;
            this.dgvTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeams.Location = new System.Drawing.Point(3, 3);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.Size = new System.Drawing.Size(790, 338);
            this.dgvTeams.TabIndex = 8;
            this.dgvTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeams_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // teamDTOBindingSource
            // 
            this.teamDTOBindingSource.DataSource = typeof(SVM_Webservice_Client.SVMWebservice.TeamDTO);
            // 
            // dgvContests
            // 
            this.dgvContests.AllowUserToAddRows = false;
            this.dgvContests.AllowUserToDeleteRows = false;
            this.dgvContests.AutoGenerateColumns = false;
            this.dgvContests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.finishedDataGridViewCheckBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn});
            this.dgvContests.DataSource = this.contestDTOBindingSource;
            this.dgvContests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContests.Location = new System.Drawing.Point(3, 3);
            this.dgvContests.Name = "dgvContests";
            this.dgvContests.ReadOnly = true;
            this.dgvContests.Size = new System.Drawing.Size(790, 338);
            this.dgvContests.TabIndex = 9;
            this.dgvContests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContests_CellClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 58;
            // 
            // finishedDataGridViewCheckBoxColumn
            // 
            this.finishedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.finishedDataGridViewCheckBoxColumn.DataPropertyName = "finished";
            this.finishedDataGridViewCheckBoxColumn.HeaderText = "finished";
            this.finishedDataGridViewCheckBoxColumn.Name = "finishedDataGridViewCheckBoxColumn";
            this.finishedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.finishedDataGridViewCheckBoxColumn.Width = 49;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDataGridViewTextBoxColumn.Width = 52;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "end";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDataGridViewTextBoxColumn.Width = 50;
            // 
            // contestDTOBindingSource
            // 
            this.contestDTOBindingSource.DataSource = typeof(SVM_Webservice_Client.SVMWebservice.ContestDTO);
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoGenerateColumns = false;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn2,
            this.resultHomeDataGridViewTextBoxColumn,
            this.resultAwayDataGridViewTextBoxColumn});
            this.dgvMatches.DataSource = this.matchDTOBindingSource;
            this.dgvMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatches.Location = new System.Drawing.Point(3, 3);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.Size = new System.Drawing.Size(790, 338);
            this.dgvMatches.TabIndex = 11;
            // 
            // startDataGridViewTextBoxColumn1
            // 
            this.startDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startDataGridViewTextBoxColumn1.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn1.HeaderText = "start";
            this.startDataGridViewTextBoxColumn1.Name = "startDataGridViewTextBoxColumn1";
            this.startDataGridViewTextBoxColumn1.ReadOnly = true;
            this.startDataGridViewTextBoxColumn1.Width = 52;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Width = 58;
            // 
            // resultHomeDataGridViewTextBoxColumn
            // 
            this.resultHomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.resultHomeDataGridViewTextBoxColumn.DataPropertyName = "resultHome";
            this.resultHomeDataGridViewTextBoxColumn.HeaderText = "resultHome";
            this.resultHomeDataGridViewTextBoxColumn.Name = "resultHomeDataGridViewTextBoxColumn";
            this.resultHomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultHomeDataGridViewTextBoxColumn.Width = 85;
            // 
            // resultAwayDataGridViewTextBoxColumn
            // 
            this.resultAwayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.resultAwayDataGridViewTextBoxColumn.DataPropertyName = "resultAway";
            this.resultAwayDataGridViewTextBoxColumn.HeaderText = "resultAway";
            this.resultAwayDataGridViewTextBoxColumn.Name = "resultAwayDataGridViewTextBoxColumn";
            this.resultAwayDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultAwayDataGridViewTextBoxColumn.Width = 83;
            // 
            // matchDTOBindingSource
            // 
            this.matchDTOBindingSource.DataSource = typeof(SVM_Webservice_Client.SVMWebservice.MatchDTO);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDate);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearchDate);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearchTeams);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(804, 422);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTeams);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teams";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvContests);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvMatches);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(796, 344);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Matches";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "http://localhost:8080/axis2/services/ExportContestService",
            "http://ec2-23-23-240-50.compute-1.amazonaws.com:8080/axis2/services/ExportContest" +
                "Service"});
            this.comboBox1.Location = new System.Drawing.Point(535, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 422);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "SVM-Webservice-Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchDTOBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Button btnSearchTeams;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.BindingSource teamDTOBindingSource;
        private System.Windows.Forms.DataGridView dgvContests;
        private System.Windows.Forms.BindingSource contestDTOBindingSource;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultHomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultAwayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource matchDTOBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

