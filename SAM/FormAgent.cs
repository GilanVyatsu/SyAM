using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAM
{
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
        }

        private void listViewDealShare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.DealShare = textBoxDealShare.Text;
            Program.sAM.Agent.Add(agent);
            Program.sAM.SaveChanges();
        }
    }
}
