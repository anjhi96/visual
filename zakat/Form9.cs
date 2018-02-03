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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string massage = "ZAKAT FITRAH\n\n";
            massage += "Harga per-kilo beras Rp 10.000,- \n";
            massage += "Satu Jiwa = 2,5Kg atau Rp 25.000,- \n";
            massage += "================================\n\n";
            massage += "Jumlah Jiwa  = " + textBox1.Text + " jiwa \n";
            massage += "Total zakat yang harus dikeluarkan  = Rp " + Convert.ToInt32(textBox1.Text) * 25000 + ",-\n";

            MessageBox.Show(massage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }
    }
}
