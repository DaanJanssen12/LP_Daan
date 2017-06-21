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
        Election election;
        public ResultWindow(Election election, bool newResult)
        {
            InitializeComponent();
            this.election = election;
            lblTitle.Text = election.Name;
            if (newResult)
            {
                foreach (Party party in sql.LoadAllParties())
                {
                    cbParty.Items.Add(party);
                }
                election.parties = new List<Party>();
                election.results = new List<ElectionResult>();
                tbDateTime.Visible = true;
                lblDateTime.Visible = true;
                Update.Text = "Nieuw resultaat";
            }
            else
            {
                foreach (Party party in election.parties)
                {
                    cbParty.Items.Add(party);
                }
                tbDateTime.Visible = false;
                lblDateTime.Visible = false;
                Update.Text = "Pas aan";
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            int votes;
            if (Update.Text == "Pas aan")
            {               
                if (int.TryParse(tbVotes.Text, out votes) && cbParty.SelectedItem != null)
                {
                    election.ChangeResults(cbParty.SelectedItem.ToString(), votes, sql);
                }
            }
            else if (Update.Text == "Nieuw Resultaat")
            {
                DateTime temp;
                if (DateTime.TryParse(tbDateTime.Text, out temp) && int.TryParse(tbVotes.Text, out votes) && cbParty.SelectedItem != null)
                {
                    election.AddParty((Party)cbParty.SelectedItem);
                    ElectionResult result = new ElectionResult();
                    election.AddResult(result);
                    result.CalculateSeats(Convert.ToInt32(tbVotes.Text));
                    sql.NewResult(result, election.Name);
                }
            }
            
        }
    }
}
