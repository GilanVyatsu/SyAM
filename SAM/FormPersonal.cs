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
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
            ShowPersonal();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.FirstName = textBoxFirstName.Text;
            personal.MiddleName = textBoxMiddleName.Text;
            personal.LastName = textBoxLastName.Text;
            Program.sAM.Personal.Add(personal);
            Program.sAM.SaveChanges();
        }
        void ShowPersonal()
        {
            listViewPersonal.Items.Clear();
            foreach (Personal personal in Program.sAM.Personal)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    personal.id.ToString(), personal.FirstName, personal.MiddleName,
                    personal.LastName,
                });
                item.Tag = personal;
                listViewPersonal.Items.Add(item);
            }
            //выравниваем колонки в listView
            listViewPersonal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPersonal.SelectedItems.Count == 1)
            {
                Personal personal = listViewPersonal.SelectedItems[0].Tag as Personal;
                personal.FirstName = textBoxFirstName.Text;
                personal.MiddleName = textBoxMiddleName.Text;
                personal.LastName = textBoxLastName.Text;
                Program.sAM.SaveChanges();
                //отображение в listView
                ShowPersonal();
            }

                }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPersonal.SelectedItems.Count == 1)
                {
                    Personal personal = listViewPersonal.SelectedItems[0].Tag as Personal;
                    Program.sAM.ClientSet.Remove(personal);
                    Program.sAM.SaveChanges();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }

        private void listViewPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPersonal.SelectedItems.Count == 1)
            {
                Personal personal = listViewPersonal.SelectedItems[0].Tag as Personal;
                textBoxFirstName.Text = personal.FirstName;
                textBoxMiddleName.Text = personal.MiddleName;
                textBoxLastName.Text = personal.LastName;
            }

            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
    } 
} 

