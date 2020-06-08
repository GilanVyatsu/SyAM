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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowSupply();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Supply supply = new Supply();
            supply.Price = textBoxPrice.Text;
            supply.AgentId = textBoxAgentid.Text;
            Program.sAM.Supply.Add(supply);
            Program.sAM.SaveChanges();
        }
        void ShowSupply()
        {
            listViewSupply.Items.Clear();
            foreach (Supply supply in Program.sAM.Supply)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.id.ToString(), supply.Price, supply.AgentId,
                });
                item.Tag = supply;
                listViewSupply.Items.Add(item);
            }
            listViewSupply.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupply.SelectedItems.Count == 1)
            {
                Supply supply = listViewSupply.SelectedItems[0].Tag as Supply;
                supply.Price = textBoxPrice.Text;
                supply.AgentId = textBoxAgentid.Text;
                Program.sAM.SaveChanges();
                ShowSupply();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupply.SelectedItems.Count == 1)
                {
                    Supply supply = listViewSupply.SelectedItems[0].Tag as Supply;
                    Program.sAM.Supply.Remove(supply);
                    Program.sAM.SaveChanges();
                }
                textBoxPrice.Text = "";
                textBoxAgentid.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupply.SelectedItems.Count == 1)
            {
                Supply supply = listViewSupply.SelectedItems[0].Tag as Supply;
                textBoxPrice.Text = supply.Price;
                textBoxAgentid.Text = supply.AgentId;
            }

            else
            {
                textBoxPrice.Text = "";
                textBoxAgentid.Text = "";
            }
        }
    }
}
