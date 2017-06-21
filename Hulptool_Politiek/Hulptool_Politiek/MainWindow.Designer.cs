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
            this.btnMakeCoalition = new System.Windows.Forms.Button();
            this.tbCoalitionName = new System.Windows.Forms.TextBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.lblCoalitionName = new System.Windows.Forms.Label();
            this.btnNewElectionResult = new System.Windows.Forms.Button();
            this.tpCoalition = new System.Windows.Forms.TabPage();
            this.cbCoaltion = new System.Windows.Forms.ComboBox();
            this.lbCoaltionParties = new System.Windows.Forms.ListBox();
            this.btnLoadCoalition = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpResults.SuspendLayout();
            this.tpParties.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.tpCoalition.SuspendLayout();
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
            this.btnPartyOverview.Location = new System.Drawing.Point(229, 33);
            this.btnPartyOverview.Name = "btnPartyOverview";
            this.btnPartyOverview.Size = new System.Drawing.Size(116, 23);
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
            this.cbElection.Size = new System.Drawing.Size(217, 21);
            this.cbElection.TabIndex = 2;
            // 
            // lblMayority
            // 
            this.lblMayority.AutoSize = true;
            this.lblMayority.Location = new System.Drawing.Point(6, 170);
            this.lblMayority.Name = "lblMayority";
            this.lblMayority.Size = new System.Drawing.Size(0, 13);
            this.lblMayority.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpResults);
            this.tabControl.Controls.Add(this.tpParties);
            this.tabControl.Controls.Add(this.tpCoalition);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(594, 293);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.btnNewElectionResult);
            this.tpResults.Controls.Add(this.gbEdit);
            this.tpResults.Controls.Add(this.cbElection);
            this.tpResults.Controls.Add(this.clbParties);
            this.tpResults.Controls.Add(this.btnPartyOverview);
            this.tpResults.Location = new System.Drawing.Point(4, 22);
            this.tpResults.Name = "tpResults";
            this.tpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tpResults.Size = new System.Drawing.Size(586, 267);
            this.tpResults.TabIndex = 0;
            this.tpResults.Text = "Verkiezingsuitslagen";
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
            this.lbParties.Size = new System.Drawing.Size(330, 212);
            this.lbParties.TabIndex = 0;
            this.lbParties.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbParties_MouseDoubleClick);
            // 
            // btnNewParty
            // 
            this.btnNewParty.Location = new System.Drawing.Point(358, 34);
            this.btnNewParty.Name = "btnNewParty";
            this.btnNewParty.Size = new System.Drawing.Size(166, 53);
            this.btnNewParty.TabIndex = 1;
            this.btnNewParty.Text = "Nieuwe Partij";
            this.btnNewParty.UseVisualStyleBackColor = true;
            this.btnNewParty.Click += new System.EventHandler(this.btnNewParty_Click);
            // 
            // btnEditResults
            // 
            this.btnEditResults.Location = new System.Drawing.Point(3, 19);
            this.btnEditResults.Name = "btnEditResults";
            this.btnEditResults.Size = new System.Drawing.Size(200, 23);
            this.btnEditResults.TabIndex = 4;
            this.btnEditResults.Text = "Uitslag aanpassen";
            this.btnEditResults.UseVisualStyleBackColor = true;
            this.btnEditResults.Click += new System.EventHandler(this.btnEditResults_Click);
            // 
            // btnMakeCoalition
            // 
            this.btnMakeCoalition.Location = new System.Drawing.Point(0, 144);
            this.btnMakeCoalition.Name = "btnMakeCoalition";
            this.btnMakeCoalition.Size = new System.Drawing.Size(197, 23);
            this.btnMakeCoalition.TabIndex = 5;
            this.btnMakeCoalition.Text = "Vorm Coalitie";
            this.btnMakeCoalition.UseVisualStyleBackColor = true;
            this.btnMakeCoalition.Click += new System.EventHandler(this.btnMakeCoalition_Click);
            // 
            // tbCoalitionName
            // 
            this.tbCoalitionName.Location = new System.Drawing.Point(50, 118);
            this.tbCoalitionName.Name = "tbCoalitionName";
            this.tbCoalitionName.Size = new System.Drawing.Size(147, 20);
            this.tbCoalitionName.TabIndex = 6;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.lblCoalitionName);
            this.gbEdit.Controls.Add(this.btnEditResults);
            this.gbEdit.Controls.Add(this.tbCoalitionName);
            this.gbEdit.Controls.Add(this.btnMakeCoalition);
            this.gbEdit.Controls.Add(this.lblMayority);
            this.gbEdit.Location = new System.Drawing.Point(351, 64);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(203, 197);
            this.gbEdit.TabIndex = 7;
            this.gbEdit.TabStop = false;
            this.gbEdit.Visible = false;
            // 
            // lblCoalitionName
            // 
            this.lblCoalitionName.AutoSize = true;
            this.lblCoalitionName.Location = new System.Drawing.Point(6, 121);
            this.lblCoalitionName.Name = "lblCoalitionName";
            this.lblCoalitionName.Size = new System.Drawing.Size(38, 13);
            this.lblCoalitionName.TabIndex = 7;
            this.lblCoalitionName.Text = "Naam:";
            // 
            // btnNewElectionResult
            // 
            this.btnNewElectionResult.Location = new System.Drawing.Point(351, 35);
            this.btnNewElectionResult.Name = "btnNewElectionResult";
            this.btnNewElectionResult.Size = new System.Drawing.Size(203, 23);
            this.btnNewElectionResult.TabIndex = 8;
            this.btnNewElectionResult.Text = "Nieuwe uitslag invoeren ";
            this.btnNewElectionResult.UseVisualStyleBackColor = true;
            this.btnNewElectionResult.Click += new System.EventHandler(this.btnNewElectionResult_Click);
            // 
            // tpCoalition
            // 
            this.tpCoalition.Controls.Add(this.btnExport);
            this.tpCoalition.Controls.Add(this.btnLoadCoalition);
            this.tpCoalition.Controls.Add(this.lbCoaltionParties);
            this.tpCoalition.Controls.Add(this.cbCoaltion);
            this.tpCoalition.Location = new System.Drawing.Point(4, 22);
            this.tpCoalition.Name = "tpCoalition";
            this.tpCoalition.Size = new System.Drawing.Size(586, 267);
            this.tpCoalition.TabIndex = 2;
            this.tpCoalition.Text = "Coalities";
            this.tpCoalition.UseVisualStyleBackColor = true;
            // 
            // cbCoaltion
            // 
            this.cbCoaltion.FormattingEnabled = true;
            this.cbCoaltion.Location = new System.Drawing.Point(31, 45);
            this.cbCoaltion.Name = "cbCoaltion";
            this.cbCoaltion.Size = new System.Drawing.Size(172, 21);
            this.cbCoaltion.TabIndex = 0;
            // 
            // lbCoaltionParties
            // 
            this.lbCoaltionParties.FormattingEnabled = true;
            this.lbCoaltionParties.Location = new System.Drawing.Point(31, 97);
            this.lbCoaltionParties.Name = "lbCoaltionParties";
            this.lbCoaltionParties.Size = new System.Drawing.Size(253, 147);
            this.lbCoaltionParties.TabIndex = 1;
            // 
            // btnLoadCoalition
            // 
            this.btnLoadCoalition.Location = new System.Drawing.Point(209, 45);
            this.btnLoadCoalition.Name = "btnLoadCoalition";
            this.btnLoadCoalition.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCoalition.TabIndex = 2;
            this.btnLoadCoalition.Text = "Laad coalitie";
            this.btnLoadCoalition.UseVisualStyleBackColor = true;
            this.btnLoadCoalition.Click += new System.EventHandler(this.btnLoadCoalition_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(320, 44);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exporteer coalitie";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.tpParties.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.tpCoalition.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnMakeCoalition;
        private System.Windows.Forms.TextBox tbCoalitionName;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Label lblCoalitionName;
        private System.Windows.Forms.Button btnNewElectionResult;
        private System.Windows.Forms.TabPage tpCoalition;
        private System.Windows.Forms.Button btnLoadCoalition;
        private System.Windows.Forms.ListBox lbCoaltionParties;
        private System.Windows.Forms.ComboBox cbCoaltion;
        private System.Windows.Forms.Button btnExport;
    }
}

