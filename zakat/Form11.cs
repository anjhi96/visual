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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string massage = "ZAKAT PENGHASILAN\n\n";
            massage += "Wajib mengeluarkan 2,5% dari penghasilannya \n";

            massage += "================================\n\n";
            massage += "Penghasilan perbulan  = Rp " + textBox1.Text + " \n";
            massage += "Total zakat yang harus dikeluarkan  = Rp " + Convert.ToDouble(textBox1.Text) * 25 / 1000 + ",- perbulan\n";
            massage += "Total zakat yang harus dikeluarkan  = Rp " + Convert.ToDouble(textBox1.Text) * 25 / 1000 * 12 + ",- pertahun\n";

            MessageBox.Show(massage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
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
