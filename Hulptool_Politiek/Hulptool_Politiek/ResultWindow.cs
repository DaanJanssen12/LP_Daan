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

namespace Hulptool_Politiek
{
    public partial class ResultWindow : Form
    {
        Election election;
        public ResultWindow(Election election)
        {
            InitializeComponent();
            this.election = election;
            lblTitle.Text = election.Name;
            foreach (Party party in election.parties)
            {
                cbParty.Items.Add(party);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int votes;
            if (int.TryParse(tbVotes.Text, out votes) && cbParty.SelectedItem != null)
            {
                election.ChangeResults(cbParty.SelectedItem.ToString(), votes);
            }
        }
    }
}
