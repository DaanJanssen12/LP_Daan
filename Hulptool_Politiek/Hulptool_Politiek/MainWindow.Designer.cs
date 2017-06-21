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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpResults = new System.Windows.Forms.TabPage();
            this.tpParties = new System.Windows.Forms.TabPage();
            this.lbParties = new System.Windows.Forms.ListBox();
            this.btnNewParty = new System.Windows.Forms.Button();
            this.btnEditResults = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpResults.SuspendLayout();
            this.tpParties.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbParties
            // 
            this.clbParties.FormattingEnabled = true;
            this.clbParties.Location = new System.Drawing.Point(6, 62);
            this.clbParties.Name = "clbParties";
            this.clbParties.Size = new System.Drawing.Size(339, 199);
            this.clbParties.TabIndex = 0;
            this.clbParties.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbParties_ItemCheck);
            // 
            // btnPartyOverview
            // 
            this.btnPartyOverview.Location = new System.Drawing.Point(351, 35);
            this.btnPartyOverview.Name = "btnPartyOverview";
            this.btnPartyOverview.Size = new System.Drawing.Size(200, 23);
            this.btnPartyOverview.TabIndex = 1;
            this.btnPartyOverview.Text = "View";
            this.btnPartyOverview.UseVisualStyleBackColor = true;
            this.btnPartyOverview.Click += new System.EventHandler(this.btnPartyOverview_Click);
            // 
            // cbElection
            // 
            this.cbElection.FormattingEnabled = true;
            this.cbElection.Location = new System.Drawing.Point(6, 35);
            this.cbElection.Name = "cbElection";
            this.cbElection.Size = new System.Drawing.Size(339, 21);
            this.cbElection.TabIndex = 2;
            // 
            // lblMayority
            // 
            this.lblMayority.AutoSize = true;
            this.lblMayority.Location = new System.Drawing.Point(516, 122);
            this.lblMayority.Name = "lblMayority";
            this.lblMayority.Size = new System.Drawing.Size(35, 13);
            this.lblMayority.TabIndex = 3;
            this.lblMayority.Text = "label1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpResults);
            this.tabControl.Controls.Add(this.tpParties);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(594, 293);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.btnEditResults);
            this.tpResults.Controls.Add(this.cbElection);
            this.tpResults.Controls.Add(this.clbParties);
            this.tpResults.Controls.Add(this.btnPartyOverview);
            this.tpResults.Controls.Add(this.lblMayority);
            this.tpResults.Location = new System.Drawing.Point(4, 22);
            this.tpResults.Name = "tpResults";
            this.tpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tpResults.Size = new System.Drawing.Size(586, 267);
            this.tpResults.TabIndex = 0;
            this.tpResults.Text = "Uitslagen";
            this.tpResults.UseVisualStyleBackColor = true;
            // 
            // tpParties
            // 
            this.tpParties.Controls.Add(this.btnNewParty);
            this.tpParties.Controls.Add(this.lbParties);
            this.tpParties.Location = new System.Drawing.Point(4, 22);
            this.tpParties.Name = "tpParties";
            this.tpParties.Padding = new System.Windows.Forms.Padding(3);
            this.tpParties.Size = new System.Drawing.Size(586, 267);
            this.tpParties.TabIndex = 1;
            this.tpParties.Text = "Partijen";
            this.tpParties.UseVisualStyleBackColor = true;
            // 
            // lbParties
            // 
            this.lbParties.FormattingEnabled = true;
            this.lbParties.Location = new System.Drawing.Point(22, 34);
            this.lbParties.Name = "lbParties";
            this.lbParties.Size = new System.Drawing.Size(166, 212);
            this.lbParties.TabIndex = 0;
            this.lbParties.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbParties_MouseDoubleClick);
            // 
            // btnNewParty
            // 
            this.btnNewParty.Location = new System.Drawing.Point(263, 34);
            this.btnNewParty.Name = "btnNewParty";
            this.btnNewParty.Size = new System.Drawing.Size(91, 35);
            this.btnNewParty.TabIndex = 1;
            this.btnNewParty.Text = "Nieuwe Partij";
            this.btnNewParty.UseVisualStyleBackColor = true;
            this.btnNewParty.Click += new System.EventHandler(this.btnNewParty_Click);
            // 
            // btnEditResults
            // 
            this.btnEditResults.Location = new System.Drawing.Point(351, 73);
            this.btnEditResults.Name = "btnEditResults";
            this.btnEditResults.Size = new System.Drawing.Size(200, 23);
            this.btnEditResults.TabIndex = 4;
            this.btnEditResults.Text = "Uitslag aanpassen";
            this.btnEditResults.UseVisualStyleBackColor = true;
            this.btnEditResults.Click += new System.EventHandler(this.btnEditResults_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 307);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "Hulptool Politiek";
            this.tabControl.ResumeLayout(false);
            this.tpResults.ResumeLayout(false);
            this.tpResults.PerformLayout();
            this.tpParties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbParties;
        private System.Windows.Forms.Button btnPartyOverview;
        private System.Windows.Forms.ComboBox cbElection;
        private System.Windows.Forms.Label lblMayority;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpResults;
        private System.Windows.Forms.TabPage tpParties;
        private System.Windows.Forms.ListBox lbParties;
        private System.Windows.Forms.Button btnNewParty;
        private System.Windows.Forms.Button btnEditResults;
    }
}

