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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ShowClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Phone = textBoxPhone.Text;
            client.Email = textBoxEmail.Text;
            Program.sAM.Client.Add(client);
            Program.sAM.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Client client = listViewClient.SelectedItems[0].Tag as Client;
                client.Phone = textBoxPhone.Text;
                client.Email = textBoxEmail.Text;
                Program.sAM.SaveChanges();
                ShowClient();
            }
        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (Client client in Program.sAM.Client)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    client.id.ToString(), client.Phone, client.Email,
                });
                item.Tag = client;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    Client client = listViewClient.SelectedItems[0].Tag as Client;
                    Program.sAM.Client.Remove(client);
                    Program.sAM.SaveChanges();
                }
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Client client = listViewClient.SelectedItems[0].Tag as Client;
                textBoxPhone.Text = client.Phone;
                textBoxEmail.Text = client.Email;
            }
            else
            {
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }
    }
}
