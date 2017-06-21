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
    public partial class ResultWindow : Form
    {
        ISql sql = new Sql();
        Election election = new Election();
        public ResultWindow(Election election)
        {
            InitializeComponent();
            this.election = election;
            lblTitle.Text = election.Name;
            foreach (Party party in election.parties)
            {
                cbParty.Items.Add(party);
            }
            tbDateTime.Visible = false;
            lblDateTime.Visible = false;
            cbElections.Visible = false;
            lblElection.Visible = false;
            Update.Text = "Pas aan";
        }

        public ResultWindow()
        {
            InitializeComponent();
            foreach (Party party in sql.LoadAllParties())
            {
                cbParty.Items.Add(party);
            }
            foreach (Election election in sql.LoadElections())
            {
                cbElections.Items.Add(election);
            }
            lblTitle.Visible = false;
            election.parties = new List<Party>();
            election.results = new List<ElectionResult>();
            tbDateTime.Visible = true;
            lblDateTime.Visible = true;
            Update.Text = "Nieuw resultaat";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int votes;
            if (Update.Text == "Pas aan")
            {               
                if (int.TryParse(tbVotes.Text, out votes) && cbParty.SelectedItem != null)
                {
                    election.ChangeResults(cbParty.SelectedItem.ToString(), votes, sql);
                    MessageBox.Show("De uitslag is succelvol aangepast.");
                }
            }
            else if (Update.Text == "Nieuw resultaat")
            {
                DateTime temp;
                if (DateTime.TryParse(tbDateTime.Text, out temp) && int.TryParse(tbVotes.Text, out votes) && cbParty.SelectedItem != null)
                {
                    election.Name = cbElections.Text;
                    election.AddParty((Party)cbParty.SelectedItem);
                    ElectionResult result = new ElectionResult();
                    election.AddResult(result);
                    result.CalculateSeats(Convert.ToInt32(tbVotes.Text));
                    sql.NewResult(result, election.Name);
                    MessageBox.Show("De uitslag is succelvol opgeslagen.");
                }
            }
            
        }
    }
}
