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
            ShowAgent();
        }

        private void listViewDealShare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                Agent agent = listViewAgent.SelectedItems[0].Tag as Agent;
                agent.Deal = textBoxDeal.Text;
                agent.Share = textBoxShare.Text;
                Program.sAM.SaveChanges();
                ShowAgent();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.Deal = textBoxDeal.Text;
            agent.Share = textBoxShare.Text;
            Program.sAM.Agent.Add(agent);
            Program.sAM.SaveChanges();
        }
        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (Agent agent in Program.sAM.Agent)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agent.id.ToString(), agent.Deal, agent.Share,
                });
                item.Tag = agent;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
