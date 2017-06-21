using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hulptool_Politiek.DAL;
using Hulptool_Politiek.Models;

namespace Hulptool_Politiek
{
    public partial class MainWindow : Form
    {
        ISql sql = new Sql();
        Election election;
        List<ElectionResult> results;

        public MainWindow()
        {
            InitializeComponent();
            foreach (Election election in sql.LoadElections())
            {
                cbElection.Items.Add(election);
            }
        }

        private void btnPartyOverview_Click(object sender, EventArgs e)
        {
            election = (Election)cbElection.SelectedItem;
            results = sql.LoadResultsForElection(election);
            foreach (ElectionResult result in results)
            {
                election.AddResult(result);
                election.AddParty(result.Party);
                clbParties.Items.Add(result, false);
            }
        }

        private void clbParties_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Coalition coalition = new Coalition();
            foreach (object result in clbParties.CheckedItems)
            {
                ElectionResult res = (ElectionResult)result;
                coalition.Parties.Add(res.Party);
            }
            if (e.NewValue == CheckState.Checked)
            {
                ElectionResult result = (ElectionResult)clbParties.Items[e.Index];
                coalition.Parties.Add(result.Party);
            }               
            if (coalition.Mayority(results, election) == true)
            {
                lblMayority.Text = "Deze coalitie heeft een meerderheid!";
            }
            else
            {
                lblMayority.Text = "Deze coalitie heeft een minderheid!";
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["tpParties"])
            {
                lbParties.Items.Clear();
                foreach (Party party in sql.LoadAllParties())
                {
                    lbParties.Items.Add(party);
                }
            }
            else if (tabControl.SelectedTab == tabControl.TabPages["tpResults"])
            {

            }
        }

        private void lbParties_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbParties.SelectedItem != null)
            {
                PartyView view = new PartyView(lbParties.SelectedItem);
                view.ShowDialog();
            }
        }

        private void btnNewParty_Click(object sender, EventArgs e)
        {
            PartyView view = new PartyView();
            view.ShowDialog();
        }

        private void btnEditResults_Click(object sender, EventArgs e)
        {
            ResultWindow result = new ResultWindow(election);
            result.ShowDialog();
        }
    }
}
