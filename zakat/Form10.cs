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
    public partial class Form10 : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; username = root; password = ; database = infaq;");
        public Form10()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string nama = textBox1.Text;
            string jumlah = textBox2.Text;
            int acak = rnd.Next(1000, 9999); // inisialisai variable acak diisi dengan nomber acak dari 1000-9999
            try
            {

                conn.Open();
                string query = "INSERT INTO data_zakat (id_transaksi,nama,jumlah) values( '" + acak + "' , '" + nama + "','" + jumlah + "' )";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                // Menampilkan data transaksi ke messagebox
                StringBuilder struk = new StringBuilder();
                struk.Append("Transaksi Berhasil !\n");
                struk.Append("ID transaksi : ");
                struk.Append(acak.ToString());
                struk.Append("\n");
                struk.Append("Nama : ");
                struk.Append(nama);
                struk.Append("\n");
                struk.Append("Jumlah Zakat Fitrah : ");
                struk.Append(jumlah);
                MessageBox.Show(struk.ToString());

                while (reader.Read())
                {

                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Transaksi Gagal");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }
    }
}
