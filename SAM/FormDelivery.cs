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
    public partial class FormDelivery : Form
    {
        public FormDelivery()
        {
            InitializeComponent();
            ShowDelivery();
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.price = textBoxPrice.Text;
            delivery.time = textBoxTime.Text;
            delivery.list = textBoxList.Text;
            Program.sAM.Delivery.Add(delivery);
            Program.sAM.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDelivery.SelectedItems.Count == 1)
            {
                Delivery delivery = listViewDelivery.SelectedItems[0].Tag as Delivery;
                delivery.price = textBoxPrice.Text;
                delivery.time = textBoxTime.Text;
                delivery.list = textBoxList.Text;
                Program.sAM.SaveChanges();
                ShowDelivery();
            }
        }
        void ShowDelivery()
        {
            listViewDelivery.Items.Clear();
            foreach (Delivery delivery in Program.sAM.Delivery)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    delivery.id.ToString(), delivery.price, delivery.time,
                    delivery.list,
                });
                item.Tag = delivery;
                listViewDelivery.Items.Add(item);
            }
            listViewDelivery.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

            private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDelivery.SelectedItems.Count == 1)
                {
                    Delivery delivery = listViewDelivery.SelectedItems[0].Tag as Delivery;
                    Program.sAM.Delivery.Remove(delivery);
                    Program.sAM.SaveChanges();
                }
                textBoxPrice.Text = "";
                textBoxTime.Text = "";
                textBoxList.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDelivery.SelectedItems.Count == 1)
            {
                Delivery delivery = listViewDelivery.SelectedItems[0].Tag as Delivery;
                textBoxPrice.Text = delivery.price;
                textBoxTime.Text = delivery.time;
                textBoxList.Text = delivery.list;
            }

            else
            {
                textBoxPrice.Text = "";
                textBoxTime.Text = "";
                textBoxList.Text = "";
            }

            }
        }
    }

