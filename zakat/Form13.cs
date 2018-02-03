using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakat
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string massage = "ZAKAT EMAS, NIAGA & TABUNGAN\n\n";
            massage += "Wajib mengeluarkan 2,5% dari nilai harga benda > Rp 4.250.000,- \n";
            massage += "================================================\n\n";
            massage += "Nilai Harga Benda = Rp " + textBox1.Text + " \n";
            massage += "Total zakat yang harus dikeluarkan  = Rp " + Convert.ToDouble(textBox1.Text) * 25 / 1000 * 12 + ",- pertahun\n";

            if (Convert.ToDouble (textBox1.Text) < 4250000)
            {
                MessageBox.Show("Anda tidak wajib membayar zakat");
            }
            else
            {
                MessageBox.Show("Total zakat yang harus dikeluarkan  = Rp " + Convert.ToDouble(textBox1.Text) * 25 / 1000 * 12 + ",- pertahun\n");
            }
            MessageBox.Show(massage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }
        }
    }

