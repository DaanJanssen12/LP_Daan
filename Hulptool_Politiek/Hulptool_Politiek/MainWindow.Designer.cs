namespace Hulptool_Politiek
{
    partial class MainWindow
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
            this.clbParties = new System.Windows.Forms.CheckedListBox();
            this.btnPartyOverview = new System.Windows.Forms.Button();
            this.cbElection = new System.Windows.Forms.ComboBox();
            this.lblMayority = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbParties
            // 
            this.clbParties.FormattingEnabled = true;
            this.clbParties.Location = new System.Drawing.Point(12, 96);
            this.clbParties.Name = "clbParties";
            this.clbParties.Size = new System.Drawing.Size(234, 199);
            this.clbParties.TabIndex = 0;
            this.clbParties.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbParties_ItemCheck);
            // 
            // btnPartyOverview
            // 
            this.btnPartyOverview.Location = new System.Drawing.Point(172, 47);
            this.btnPartyOverview.Name = "btnPartyOverview";
            this.btnPartyOverview.Size = new System.Drawing.Size(74, 23);
            this.btnPartyOverview.TabIndex = 1;
            this.btnPartyOverview.Text = "View";
            this.btnPartyOverview.UseVisualStyleBackColor = true;
            this.btnPartyOverview.Click += new System.EventHandler(this.btnPartyOverview_Click);
            // 
            // cbElection
            // 
            this.cbElection.FormattingEnabled = true;
            this.cbElection.Location = new System.Drawing.Point(12, 49);
            this.cbElection.Name = "cbElection";
            this.cbElection.Size = new System.Drawing.Size(154, 21);
            this.cbElection.TabIndex = 2;
            // 
            // lblMayority
            // 
            this.lblMayority.AutoSize = true;
            this.lblMayority.Location = new System.Drawing.Point(291, 196);
            this.lblMayority.Name = "lblMayority";
            this.lblMayority.Size = new System.Drawing.Size(35, 13);
            this.lblMayority.TabIndex = 3;
            this.lblMayority.Text = "label1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 307);
            this.Controls.Add(this.lblMayority);
            this.Controls.Add(this.cbElection);
            this.Controls.Add(this.btnPartyOverview);
            this.Controls.Add(this.clbParties);
            this.Name = "MainWindow";
            this.Text = "Hulptool Politiek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbParties;
        private System.Windows.Forms.Button btnPartyOverview;
        private System.Windows.Forms.ComboBox cbElection;
        private System.Windows.Forms.Label lblMayority;
    }
}

