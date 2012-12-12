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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnSearchTeams = new System.Windows.Forms.Button();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(27, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(91, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Suche mit Datum:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(137, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(201, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(360, 28);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDate.TabIndex = 2;
            this.btnSearchDate.Text = "Suchen";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // btnSearchTeams
            // 
            this.btnSearchTeams.Location = new System.Drawing.Point(484, 26);
            this.btnSearchTeams.Name = "btnSearchTeams";
            this.btnSearchTeams.Size = new System.Drawing.Size(103, 26);
            this.btnSearchTeams.TabIndex = 3;
            this.btnSearchTeams.Text = "Teams anzeigen";
            this.btnSearchTeams.UseVisualStyleBackColor = true;
            this.btnSearchTeams.Click += new System.EventHandler(this.btnSearchTeams_Click);
            // 
            // lbxResults
            // 
            this.lbxResults.AllowDrop = true;
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.Location = new System.Drawing.Point(30, 108);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(552, 511);
            this.lbxResults.TabIndex = 6;
            this.lbxResults.SelectedIndexChanged += new System.EventHandler(this.lbxResults_SelectedIndexChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(27, 81);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(101, 13);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Verfügbare Einträge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 631);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.btnSearchTeams);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Name = "Form1";
            this.Text = "SVM-Webservice-Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Button btnSearchTeams;
        private System.Windows.Forms.ListBox lbxResults;
        private System.Windows.Forms.Label lblResults;
    }
}

