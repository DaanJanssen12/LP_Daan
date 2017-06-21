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
            this.SuspendLayout();
            // 
            // cbParty
            // 
            this.cbParty.FormattingEnabled = true;
            this.cbParty.Location = new System.Drawing.Point(234, 44);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(121, 21);
            this.cbParty.TabIndex = 0;
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Location = new System.Drawing.Point(80, 47);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(33, 13);
            this.lblParty.TabIndex = 1;
            this.lblParty.Text = "Partij:";
            // 
            // tbVotes
            // 
            this.tbVotes.Location = new System.Drawing.Point(234, 93);
            this.tbVotes.Name = "tbVotes";
            this.tbVotes.Size = new System.Drawing.Size(121, 20);
            this.tbVotes.TabIndex = 2;
            // 
            // lblVotes
            // 
            this.lblVotes.AutoSize = true;
            this.lblVotes.Location = new System.Drawing.Point(80, 93);
            this.lblVotes.Name = "lblVotes";
            this.lblVotes.Size = new System.Drawing.Size(54, 13);
            this.lblVotes.TabIndex = 3;
            this.lblVotes.Text = "Stemmen:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(219, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Titel";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(234, 141);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(121, 35);
            this.Update.TabIndex = 5;
            this.Update.Text = "Pas aan";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 273);
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
    }
}