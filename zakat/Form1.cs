using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace zakat
{
    public partial class Form1 : Form
    {

        MySqlConnection conn = new MySqlConnection("server = localhost; username = root; password = ; database = infaq;");
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }         

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                conn.Open();
                var sql = new MySqlCommand("SELECT * FROM admin WHERE `username` = '" + textBox2.Text + "' AND `password` = '" + textBox1.Text + "' ", conn);

                MySqlDataReader read = sql.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("Berhasil Login");

                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    var ssql = new MySqlCommand("SELECT * FROM user WHERE `username` = '" + textBox2.Text + "' AND `password` = '" + textBox1.Text + "' ", conn);

                    MessageBox.Show("Berhasil Login");

                    Form7 f7 = new Form7();
                    f7.Show();
                    this.Hide();
                }

                conn.Close();
                ClearTextBox();
            }
        }
    }
}
