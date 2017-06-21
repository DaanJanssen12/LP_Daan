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
using System.IO;

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
            gbEdit.Visible = true;
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
                coalition.Parties.Add(res);
            }
            if (e.NewValue == CheckState.Checked)
            {
                ElectionResult result = (ElectionResult)clbParties.Items[e.Index];
                coalition.Parties.Add(result);
            }               
            if (coalition.aMayority(results, election) == true)
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
            else if (tabControl.SelectedTab == tabControl.TabPages["tpCoalition"])
            {
                foreach (Coalition coalition in sql.LoadAllCoalitions())
                {
                    cbCoaltion.Items.Add(coalition);
                }
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
            ResultWindow result = new ResultWindow(election, false);
            result.ShowDialog();
        }

        private void btnMakeCoalition_Click(object sender, EventArgs e)
        {           
            if (tbCoalitionName.Text != null && clbParties.CheckedItems.Count > 1)
            {
                List<ElectionResult> parties = new List<ElectionResult>();
                foreach (object result in clbParties.CheckedItems)
                {
                    ElectionResult res = (ElectionResult)result;
                    parties.Add(res);
                }

                Coalition coalition = new Coalition(tbCoalitionName.Text, parties);
                coalition.aMayority(parties, election);
                sql.NewCoalition(coalition);
            }
            
        }

        private void btnNewElectionResult_Click(object sender, EventArgs e)
        {
            ResultWindow newResult = new ResultWindow(election, true);
            newResult.ShowDialog();
        }

        private void btnLoadCoalition_Click(object sender, EventArgs e)
        {
            Coalition coalition = (Coalition)cbCoaltion.SelectedItem;
            foreach (ElectionResult party in coalition.Parties)
            {
                lbCoaltionParties.Items.Add(party);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Coalition coalition = (Coalition)cbCoaltion.SelectedItem;
            string path = "test.txt";

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("Coalitie voorstel "+coalition.ElectionName);
                streamWriter.WriteLine("==============================================================");
                streamWriter.WriteLine("Aan: Willempie");
                streamWriter.WriteLine(" ");
                streamWriter.WriteLine("Partij\t\tZetels\t\tLijsttrekker");
                streamWriter.WriteLine(" ");
                int totalSeats = 0;
                foreach (ElectionResult res in coalition.Parties)
                {
                    totalSeats = totalSeats + res.Seats;
                    streamWriter.WriteLine(res.Party.Abbreviation + "\t\t" + res.Seats.ToString() + "\t\t" + res.Party.LeadCandidate.Name);
                }
                streamWriter.WriteLine("==============================================================");
                streamWriter.WriteLine("Totaal:\t\t"+totalSeats.ToString()+"\t\tPremier: "+coalition.Premier.Name);
            }
        }
    }
}
