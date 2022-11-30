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
    public partial class AkademisyenListele : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        public AkademisyenListele()
        {
            InitializeComponent();
        }

        private void AkademisyenListele_Load(object sender, EventArgs e)
        {
           //BOŞ
        }

        private void btnara_Click(object sender, EventArgs e)
        {
                //INDEX BURADAKI SAKLI PROSEDUR İÇİN YAZIYOR
            baglanti.Open();
            SqlCommand ogrkayit = new SqlCommand("spakademisyenara", baglanti);
            ogrkayit.Parameters.AddWithValue("@isim", (txtakademisyenad.Text));
            SqlDataAdapter spda = new SqlDataAdapter("spakademisyenara " + txtakademisyenad.Text, baglanti);
            DataSet ds1 = new DataSet();
            spda.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            baglanti.Close();

        }
    }
}
