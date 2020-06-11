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
    public struct personal
    {
        public string Login;
        public string Password;
        public string Type;
    }

    public partial class FormLogin : Form
    {
        public static Login login = new Login();
        public FormLogin()
        {
            InitializeComponent();
            if (FormLogin.login.Login1 == "personal") buttonLogin.Enabled = false;
            labelHello.Text = "Добро пожаловать, Семпаай!^^" + FormLogin.login.Login1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                bool key = false;
                {
                    if (textBoxLogin.Text == login.Login1 && textBoxPassword.Text == login.Password)
                    {
                        key = true;
                        login.Login1 = login.Login1;
                        login.Password = login.Password;
                        login.Type = login.Type;
                    }
                    if (!key)
                    {
                        MessageBox.Show("Проверьте данные", "Пользователь не найдем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxLogin.Text = " ";
                        textBoxPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Данные введены верно", "Пользователь найдем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SAM formSAM = new SAM();
                        formSAM.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
