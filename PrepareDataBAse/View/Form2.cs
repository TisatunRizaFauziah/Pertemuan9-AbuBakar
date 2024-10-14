using PrepareDataBAse.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareDataBAse.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController user = new UserController();
            if ((txtUser.Text == "") || (txtPass.Text == ""))
            {
                MessageBox.Show("Data login harus diisi", "Login salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtUser.Text;
                string pass = txtPass.Text;

                DataTable table = user.getlist(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM users WHERE username = '" + name + "' AND password = '" + pass + "'"));
                if (table.Rows.Count > 0)
                {
                    Form3 form3 = new Form3();
                    this.Hide();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Username dan password tidak ditemukan", "Login salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
