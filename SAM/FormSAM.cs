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
    public partial class SAM : Form
    {
        public SAM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenPersonal_Click(object sender, EventArgs e)
        {
            Form formPersonal = new FormPersonal();
            formPersonal.Show();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClients = new FormClients();
            formClients.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void buttonOpenSupply_Click(object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenDemand_Click(object sender, EventArgs e)
        {
            Form formDemand = new FormDemand();
            formDemand.Show();
        }

        private void buttonOpenDelivery_Click(object sender, EventArgs e)
        {
            Form formDelivery = new FormDelivery();
            formDelivery.Show();
        }

        private void buttonOpenCatalog_Click(object sender, EventArgs e)
        {
            Form formCatalog = new FormCatalog();
            formCatalog.Show();
        }

        private void buttonOpenStore_Click(object sender, EventArgs e)
        {
            Form formStore = new FormStore();
            formStore.Show();
        }
    }
}
