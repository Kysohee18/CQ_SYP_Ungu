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
            
        }

        private void btnHitungMhs_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHitungMK_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
