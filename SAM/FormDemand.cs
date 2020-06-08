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
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            ShowDemand();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Demand demand = new Demand();
            demand.Address = textBoxAddress.Text;
            demand.MinPrice = textBoxMinPrice.Text;
            demand.MaxPrice = textBoxMaxPrice.Text;
            demand.Catalog = textBoxCatalog.Text;
            Program.sAM.Demand.Add(demand);
            Program.sAM.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDemand.SelectedItems.Count == 1)
            {
                Demand demand = listViewDemand.SelectedItems[0].Tag as Demand;
                demand.Address = textBoxAddress.Text;
                demand.MinPrice = textBoxMinPrice.Text;
                demand.MaxPrice = textBoxMaxPrice.Text;
                demand.Catalog = textBoxCatalog.Text;
                Program.sAM.SaveChanges();
                ShowDemand();
            }
        }
        void ShowDemand()
        {
            listViewDemand.Items.Clear();
            foreach (Demand demand in Program.sAM.Demand)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    demand.id.ToString(), demand.Address, demand.MinPrice, demand.MaxPrice,
                    demand.Catalog,
                });
                item.Tag = demand;
                listViewDemand.Items.Add(item);
            }
            listViewDemand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDemand.SelectedItems.Count == 1)
                {
                    Demand demand = listViewDemand.SelectedItems[0].Tag as Demand;
                    Program.sAM.Demand.Remove(demand);
                    Program.sAM.SaveChanges();
                }
                textBoxAddress.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxCatalog.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemand.SelectedItems.Count == 1)
            {
                Demand demand = listViewDemand.SelectedItems[0].Tag as Demand;
                textBoxAddress.Text = demand.Address;
                textBoxMinPrice.Text = demand.MinPrice;
                textBoxMaxPrice.Text = demand.MaxPrice;
                textBoxCatalog.Text = demand.Catalog;
            }

            else
            {
                textBoxAddress.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxCatalog.Text = "";
            }
        }
    }
}
