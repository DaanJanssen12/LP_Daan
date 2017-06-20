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
            foreach(Election election in sql.LoadElections())
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
                clbParties.Items.Add(result.Party, false);
            }
        }

        private void clbParties_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Coalition coalition = new Coalition();
            foreach (object party in clbParties.CheckedItems)
            {
                coalition.Parties.Add((Party)party);
            }
            if (e.NewValue == CheckState.Checked)
                coalition.Parties.Add((Party)clbParties.Items[e.Index]);
            if (coalition.Mayority(results, election) == true)
            {
                lblMayority.Text = "Deze coalitie heeft een meerderheid!";
            }
            else
            {
                lblMayority.Text = "Deze coalitie heeft een minderheid!";
            }
        }
    }
}
