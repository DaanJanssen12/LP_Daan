using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hulptool_Politiek.Models;
using Hulptool_Politiek.DAL;

namespace Hulptool_Politiek
{
    public partial class PartyView : Form
    {
        Party party;
        ISql sql = new Sql();

        public PartyView(Object aParty)
        {
            InitializeComponent();
            party = (Party)aParty;
            tbPartyName.ReadOnly = true;
            tbPartyName.Text = party.Name;
            tbAbbreviation.ReadOnly = true;
            tbAbbreviation.Text = party.Abbreviation;
            cbLeadCandidate.Text = party.LeadCandidate.Name;
        }

        public PartyView()
        {
            InitializeComponent();
            tbPartyName.ReadOnly = false;
            tbAbbreviation.ReadOnly = false;
            btnEdit.Enabled = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnSave.Enabled = true;
            foreach (Politician politician in sql.LoadAllPoliticians())
            {
                cbLeadCandidate.Items.Add(politician);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbPartyName.ReadOnly = false;
            tbAbbreviation.ReadOnly = false;
            btnSave.Visible = true;
            btnSave.Enabled = true;
            foreach(Politician politician in sql.LoadAllPoliticians())
            {
                cbLeadCandidate.Items.Add(politician);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldParty;
            if (party != null)
            {
                oldParty = party.Abbreviation;
            }
            else
            {
                oldParty = tbAbbreviation.Text;
            }
            party = new Party(tbPartyName.Text, tbAbbreviation.Text, (Politician)cbLeadCandidate.SelectedItem, 0);
            sql.UpdateParty(party, oldParty);
            MessageBox.Show("De partij is succesvol opgeslagen.");
            this.Close();
        }
    }
}
