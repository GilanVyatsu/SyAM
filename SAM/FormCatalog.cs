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
    public partial class FormCatalog : Form
    {
        public FormCatalog()
        {
            InitializeComponent();
            ShowCatalog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Name = textBoxName.Text;
            catalog.Price = textBoxPrice.Text;
            Program.sAM.Catalog.Add(catalog);
            Program.sAM.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCatalog.SelectedItems.Count == 1)
            {
                Catalog catalog = listViewCatalog.SelectedItems[0].Tag as Catalog;
                catalog.Name = textBoxName.Text;
                catalog.Price = textBoxName.Text;
                Program.sAM.SaveChanges();
                ShowCatalog();
            }
        }
        void ShowCatalog()
        {
            listViewCatalog.Items.Clear();
            foreach (Catalog catalog in Program.sAM.Catalog)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    catalog.id.ToString(), catalog.Name, catalog.Price,
                });
                item.Tag = catalog;
                listViewCatalog.Items.Add(item);
            }
            listViewCatalog.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCatalog.SelectedItems.Count == 1)
                {
                    Catalog catalog = listViewCatalog.SelectedItems[0].Tag as Catalog;
                    Program.sAM.Catalog.Remove(catalog);
                    Program.sAM.SaveChanges();
                }
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCatalog.SelectedItems.Count == 1)
            {
                Catalog catalog = listViewCatalog.SelectedItems[0].Tag as Catalog;
                textBoxName.Text = catalog.Name;
                textBoxPrice.Text = catalog.Price;
            }

            else
            {
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
        }
    }
}
