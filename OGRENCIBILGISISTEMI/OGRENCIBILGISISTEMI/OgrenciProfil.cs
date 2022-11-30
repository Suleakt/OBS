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

namespace OGRENCIBILGISISTEMI
{
    public partial class OgrenciProfil : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");
        public string ogrno = GIRIS.ogrno;
        public OgrenciProfil()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void OgrenciProfil_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ogrkayit = new SqlCommand("spogrprofil", baglanti);
            ogrkayit.Parameters.AddWithValue("@ogrno", (Convert.ToInt32(ogrno)));
            SqlDataAdapter spda = new SqlDataAdapter("spogrprofil " + Convert.ToInt32(ogrno), baglanti);
            DataSet ds1 = new DataSet();
            spda.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            baglanti.Close();
            lblogrno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblbkod.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lbldanisman.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString() + dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lbldonem.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            lblogrtur.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dataGridView1.Visible = false;
        }
    }
}
