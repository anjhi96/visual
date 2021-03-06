﻿using System;
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
    public partial class Form16 : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; UID=root; Pwd=; database=infaq;");
        public Form16()
        {
            InitializeComponent();
        }

        public class KONEKSI
        {
            string alamat = "server=localhost; database=infaq; uid=root; pwd=''";
            public MySqlConnection koneksi;

            //buka koneksi ke database
            public void buka()
            {
                koneksi = new MySqlConnection(alamat);
                koneksi.Open();
            }
            //tutup koneksi ke database
            public void tutup()
            {
                koneksi = new MySqlConnection(alamat);
                koneksi.Close();
            }
        }

        public class BACA
        {
            MySqlCommand komando;
            KONEKSI claskoneksi;
            MySqlDataAdapter adapter;
            string sql;
            DataTable tabel;

            // membaca semua field di database 
            public DataTable bacasemua()
            {
                claskoneksi = new KONEKSI();
                sql = "SELECT * FROM data_zakat_maal";
                tabel = new DataTable();

                try
                {
                    claskoneksi.buka();
                    komando = new MySqlCommand(sql, claskoneksi.koneksi);
                    adapter = new MySqlDataAdapter(komando);
                    komando.ExecuteNonQuery();
                    adapter.Fill(tabel);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                claskoneksi.tutup();
                return tabel;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BACA moco = new BACA();
            DataTable tabel = new DataTable();
            tabel = moco.bacasemua();
            dataGridView1.DataSource = tabel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            MessageBox.Show("Saldo Zakat Maal Saat ini adalah sebesar Rp. " + sum.ToString());
        }
    }
}
