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
    public partial class DersSecme : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        
        public DersSecme()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtogrdersID.Text = "";
            txtderskodu.Text = "";
            txtogrno.Text = "";
        }
        private void DersKaydiListele() {
            //İkinci datagridi doldurma
            baglanti.Open();
            SqlCommand ogrkayit = new SqlCommand("spogrderskaydi", baglanti);
            ogrkayit.Parameters.AddWithValue("@ogrno", (Convert.ToInt32(ogrno)));
            SqlDataAdapter spda = new SqlDataAdapter("spogrderskaydi " + Convert.ToInt32(ogrno), baglanti);
            DataSet ds1 = new DataSet();
            spda.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
            baglanti.Close();

        } 
        //PUBLIC DEGISKEN
        public string ogrno = GIRIS.ogrno;
        private void DersSecme_Load(object sender, EventArgs e)
        {      
            //İlk datagridi doldurma
            baglanti.Open();
            SqlCommand ders = new SqlCommand("spdersgoruntuleme", baglanti);
            ders.Parameters.AddWithValue("@ogrno", (Convert.ToInt32(ogrno)));
            SqlDataAdapter spadapter = new SqlDataAdapter("spdersgoruntuleme " + Convert.ToInt32(ogrno), baglanti);
            DataSet ds = new DataSet();
            spadapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            //İkinci datagridi doldurma
            DersKaydiListele();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtderskod.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
           
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string ogrno = GIRIS.ogrno;
                SqlCommand kontrol = new SqlCommand("select ogrno,derskodu from OGRENCIDERS where ogrno=@ono and derskodu=@dk", baglanti);
                kontrol.Parameters.AddWithValue("@ono", Convert.ToInt32(ogrno));
                kontrol.Parameters.AddWithValue("@dk", txtderskod.Text);
                kontrol.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(kontrol);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("AYNI KAYDI EKLEYEMEZSİNİZ");
                    baglanti.Close();
                }
                else
                {
                    SqlCommand kayitekle = new SqlCommand("insert into OGRENCIDERS(ogrno,derskodu) values (@ogrno,@dkodu)", baglanti);
                    kayitekle.Parameters.AddWithValue("@ogrno", Convert.ToInt32(ogrno));
                    kayitekle.Parameters.AddWithValue("@dkodu", txtderskod.Text);
                    kayitekle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ders Ekleme İşlemi Başarılı");
                    DersKaydiListele();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!");
            }
           

                
                
        }

        private void btnkayitsil_Click(object sender, EventArgs e)
        {
            try
            {
            baglanti.Open();
            string ogrno = GIRIS.ogrno;
            SqlCommand kayitsil = new SqlCommand("delete from OGRENCIDERS where ogrencıdersID=@ogrdersID", baglanti);
            kayitsil.Parameters.AddWithValue("@ogrdersID",Convert.ToInt16(txtogrdersID.Text));
            kayitsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Kaydı Silme Başarılı");
            DersKaydiListele();
            temizle();

            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Hatalı İşlem");
            }
           
       
        }

        //private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            

        //}

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {string odid, ono, dk;
            odid = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ono = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            dk = dataGridView2.CurrentRow.Cells[2].Value.ToString();
           txtogrdersID.Text = odid;
           txtogrno.Text = ono;
           txtderskodu.Text = dk;

        }

       
    }
}
