namespace Hulptool_Politiek
{
    partial class ResultWindow
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
            this.cbParty = new System.Windows.Forms.ComboBox();
            this.lblParty = new System.Windows.Forms.Label();
            this.tbVotes = new System.Windows.Forms.TextBox();
            this.lblVotes = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblElection = new System.Windows.Forms.Label();
            this.cbElections = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbParty
            // 
            this.cbParty.FormattingEnabled = true;
            this.cbParty.Location = new System.Drawing.Point(108, 55);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(188, 21);
            this.cbParty.TabIndex = 0;
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Location = new System.Drawing.Point(12, 58);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(33, 13);
            this.lblParty.TabIndex = 1;
            this.lblParty.Text = "Partij:";
            // 
            // tbVotes
            // 
            this.tbVotes.Location = new System.Drawing.Point(387, 58);
            this.tbVotes.Name = "tbVotes";
            this.tbVotes.Size = new System.Drawing.Size(121, 20);
            this.tbVotes.TabIndex = 2;
            // 
            // lblVotes
            // 
            this.lblVotes.AutoSize = true;
            this.lblVotes.Location = new System.Drawing.Point(320, 61);
            this.lblVotes.Name = "lblVotes";
            this.lblVotes.Size = new System.Drawing.Size(54, 13);
            this.lblVotes.TabIndex = 3;
            this.lblVotes.Text = "Stemmen:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(234, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Titel";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(193, 147);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(121, 35);
            this.Update.TabIndex = 5;
            this.Update.Text = "Pas aan";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // tbDateTime
            // 
            this.tbDateTime.Location = new System.Drawing.Point(387, 101);
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.Size = new System.Drawing.Size(121, 20);
            this.tbDateTime.TabIndex = 6;
            this.tbDateTime.Text = "DD-MM-YYYY";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(320, 101);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(41, 13);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.Text = "Datum:";
            // 
            // lblElection
            // 
            this.lblElection.AutoSize = true;
            this.lblElection.Location = new System.Drawing.Point(12, 97);
            this.lblElection.Name = "lblElection";
            this.lblElection.Size = new System.Drawing.Size(59, 13);
            this.lblElection.TabIndex = 8;
            this.lblElection.Text = "Verkiezing:";
            // 
            // cbElections
            // 
            this.cbElections.FormattingEnabled = true;
            this.cbElections.Location = new System.Drawing.Point(108, 97);
            this.cbElections.Name = "cbElections";
            this.cbElections.Size = new System.Drawing.Size(188, 21);
            this.cbElections.TabIndex = 9;
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 209);
            this.Controls.Add(this.cbElections);
            this.Controls.Add(this.lblElection);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.tbDateTime);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVotes);
            this.Controls.Add(this.tbVotes);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.cbParty);
            this.Name = "ResultWindow";
            this.Text = "ResultWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbParty;
        private System.Windows.Forms.Label lblParty;
        private System.Windows.Forms.TextBox tbVotes;
        private System.Windows.Forms.Label lblVotes;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox tbDateTime;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblElection;
        private System.Windows.Forms.ComboBox cbElections;
    }
}