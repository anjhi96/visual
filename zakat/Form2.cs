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
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; UID=root; Pwd=; database=infaq;");
        public Form2()
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
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error : " + ex.Message);
            }

            conn.Close();
        }

        private void registrasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void daftarUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newMDIChild = new Form4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void saldoZakatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newMDIChild = new Form5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void saldoInfaqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newMDIChild = new Form6();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void saldoZakatPenghasilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 newMDIChild = new Form15();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void saldoZakatMaalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 newMDIChild = new Form16();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void penyaluranZakatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 newMDIChild = new Form17();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
