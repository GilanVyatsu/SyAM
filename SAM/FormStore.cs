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
    public partial class FormStore : Form
    {
        public FormStore()
        {
            InitializeComponent();
            ShowStore();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Catalog = textBoxCatalogNumber.Text;
            store.Price = textBoxPrice.Text;
            Program.sAM.Store.Add(store);
            Program.sAM.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStore.SelectedItems.Count == 1)
            {
                Store store = listViewStore.SelectedItems[0].Tag as Store;
                store.Catalog = textBoxCatalogNumber.Text;
                store.Price = textBoxPrice.Text;
                Program.sAM.SaveChanges();
                ShowStore();
            }
        }
        void ShowStore()
        {
            listViewStore.Items.Clear();
            foreach (Store store in Program.sAM.Store)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    store.id.ToString(), store.Catalog, store.Price,
                });
                item.Tag = store;
                listViewStore.Items.Add(item);
            }
            listViewStore.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStore.SelectedItems.Count == 1)
                {
                    Store store = listViewStore.SelectedItems[0].Tag as Store;
                    Program.sAM.Store.Remove(store);
                    Program.sAM.SaveChanges();
                }
                textBoxCatalogNumber.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStore.SelectedItems.Count == 1)
            {
                Store store = listViewStore.SelectedItems[0].Tag as Store;
                textBoxCatalogNumber.Text = store.Catalog;
                textBoxPrice.Text = store.Price;
            }

            else
            {
                textBoxCatalogNumber.Text = "";
                textBoxPrice.Text = "";
            }
        }
    }
}
