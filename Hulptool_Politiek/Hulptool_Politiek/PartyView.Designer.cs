namespace Hulptool_Politiek
{
    partial class PartyView
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
            this.lblPartyName = new System.Windows.Forms.Label();
            this.lblAbbreviation = new System.Windows.Forms.Label();
            this.lblLeadCandidate = new System.Windows.Forms.Label();
            this.tbPartyName = new System.Windows.Forms.TextBox();
            this.tbAbbreviation = new System.Windows.Forms.TextBox();
            this.cbLeadCandidate = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Location = new System.Drawing.Point(121, 36);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(64, 13);
            this.lblPartyName.TabIndex = 0;
            this.lblPartyName.Text = "Partij Naam:";
            // 
            // lblAbbreviation
            // 
            this.lblAbbreviation.AutoSize = true;
            this.lblAbbreviation.Location = new System.Drawing.Point(121, 71);
            this.lblAbbreviation.Name = "lblAbbreviation";
            this.lblAbbreviation.Size = new System.Drawing.Size(52, 13);
            this.lblAbbreviation.TabIndex = 1;
            this.lblAbbreviation.Text = "Afkorting:";
            // 
            // lblLeadCandidate
            // 
            this.lblLeadCandidate.AutoSize = true;
            this.lblLeadCandidate.Location = new System.Drawing.Point(121, 114);
            this.lblLeadCandidate.Name = "lblLeadCandidate";
            this.lblLeadCandidate.Size = new System.Drawing.Size(61, 13);
            this.lblLeadCandidate.TabIndex = 2;
            this.lblLeadCandidate.Text = "Lijsttrekker:";
            // 
            // tbPartyName
            // 
            this.tbPartyName.Location = new System.Drawing.Point(247, 36);
            this.tbPartyName.Name = "tbPartyName";
            this.tbPartyName.Size = new System.Drawing.Size(277, 20);
            this.tbPartyName.TabIndex = 3;
            // 
            // tbAbbreviation
            // 
            this.tbAbbreviation.Location = new System.Drawing.Point(247, 71);
            this.tbAbbreviation.Name = "tbAbbreviation";
            this.tbAbbreviation.Size = new System.Drawing.Size(277, 20);
            this.tbAbbreviation.TabIndex = 4;
            // 
            // cbLeadCandidate
            // 
            this.cbLeadCandidate.FormattingEnabled = true;
            this.cbLeadCandidate.Location = new System.Drawing.Point(247, 114);
            this.cbLeadCandidate.Name = "cbLeadCandidate";
            this.cbLeadCandidate.Size = new System.Drawing.Size(277, 21);
            this.cbLeadCandidate.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 31);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Aanpassen";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(124, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(400, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Sla op";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PartyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 276);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbLeadCandidate);
            this.Controls.Add(this.tbAbbreviation);
            this.Controls.Add(this.tbPartyName);
            this.Controls.Add(this.lblLeadCandidate);
            this.Controls.Add(this.lblAbbreviation);
            this.Controls.Add(this.lblPartyName);
            this.Name = "PartyView";
            this.Text = "PartyView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.Label lblAbbreviation;
        private System.Windows.Forms.Label lblLeadCandidate;
        private System.Windows.Forms.TextBox tbPartyName;
        private System.Windows.Forms.TextBox tbAbbreviation;
        private System.Windows.Forms.ComboBox cbLeadCandidate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}