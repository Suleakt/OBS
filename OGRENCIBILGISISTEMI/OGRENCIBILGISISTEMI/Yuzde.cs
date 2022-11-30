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
    public partial class Yuzde : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");
        public string akID = GIRIS.ogrno; //giriş formunda ogrnoya kullanıcı adı atandı

        void spListele()
        {
            baglanti.Open();
            SqlCommand ders = new SqlCommand("spyuzde", baglanti);
            ders.Parameters.AddWithValue("@akademisyenID", (Convert.ToInt32(akID)));
            SqlDataAdapter spadapter = new SqlDataAdapter("spyuzde " + Convert.ToInt32(akID), baglanti);
            DataSet ds = new DataSet();
            spadapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        public Yuzde()
        {
            InitializeComponent();
        }

        private void Yuzde_Load(object sender, EventArgs e)
        {
            spListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update AKADEMISYENDERS set vizeyuzde='" + txtvyuzde.Text + "',finalyuzde='" + txtfyuzde.Text + "',odevyuzde='" + txtoyuzde.Text + "' where akademisyenID=@akdmID";
                cmd.Parameters.AddWithValue("@akdmID", akID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                spListele();//datagrid güncellendi
                MessageBox.Show("Yüzde Düzenleme İşlemi Gerçekleştirilmiştir");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtvyuzde.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtfyuzde.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtoyuzde.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
