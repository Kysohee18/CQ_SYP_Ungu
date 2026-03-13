using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO4
{
    public partial class Form1 : Form
        
    {
        SqlConnection conn;
        SqlCommand cmd;
    public Form1()
        {
            InitializeComponent();
        }
        private void koneksi ()
        {
            conn  = new SqlConnection (
                "Data Source=DESKTOP-6V58GOQ\\PUTRASQL; Initial Catalog=DBAkademikADO; Integrated Security=True"
                );

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();
                MessageBox.Show("Koneksi Berhasil");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMhs_Click_1(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();
                string query = "SELECT COUNT(*) FROM Mahasiswa";

                cmd = new SqlCommand (query, conn);
                int jumlah =(int)cmd.ExecuteScalar();
                txtHasil.Text = jumlah.ToString();
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnHitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();
                string query = "SELECT COUNT(*) FROM MataKuliah";
                cmd = new SqlCommand(query, conn);
                int jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = jumlah.ToString();
                conn.Close();
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();
                string query = "UPDATE Mahasiswa SET alamat='yogyakarta' WHERE nim='23110100001'";
                cmd = new SqlCommand(query, conn);
                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show("jumlah data yang terpengaruh: " + hasil);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }
        // tugas 1
        private void btnHitungdsn_Click_1(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();
                string query = "SELECT COUNT(*) FROM Dosen";
               
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
