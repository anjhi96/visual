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
    public partial class Form3 : Form
    {
       MySqlConnection conn = new MySqlConnection("datasource=localhost; UID=root; Pwd=; database=infaq;");
        public Form3()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            try
            {
                conn.Open();
                string query = "Select * from user";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error : " + ex.Message);
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Data Berhasil Ditambahkan");
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into user (id, nama, username, password, alamat) values ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            refresh();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["id"].Value.ToString();
            textBox2.Text = row.Cells["nama"].Value.ToString();
            textBox3.Text = row.Cells["username"].Value.ToString();
            textBox4.Text = row.Cells["password"].Value.ToString();
            textBox5.Text = row.Cells["alamat"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Data Berhasil Diupdate");
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update user set nama='" + textBox2.Text + "',username='" + textBox3.Text + "', password='" + textBox4.Text + "', alamat='" + textBox5.Text + "' where id='" + textBox1.Text + "'");
            cmd.ExecuteNonQuery();  
            conn.Close();
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Data Berhasil Dihapus");
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from user where id = '" + textBox1.Text + "'");
            cmd.ExecuteNonQuery();
            conn.Close();
            refresh();
        }

        

        
    }
}
