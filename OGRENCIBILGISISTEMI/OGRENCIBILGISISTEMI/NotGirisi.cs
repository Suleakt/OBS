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
   
    public partial class NotGirisi : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        public NotGirisi()
        {
            InitializeComponent();
        }
        public string akademisyenID = GIRIS.ogrno;
        void DataGridListele()
        {
            baglanti.Open();
            SqlCommand ogrderskaydi = new SqlCommand("spnotgiris", baglanti);
            ogrderskaydi.Parameters.AddWithValue("@akademisyenID", (Convert.ToInt32(akademisyenID)));
            SqlDataAdapter spadapter = new SqlDataAdapter("spnotgiris " + Convert.ToInt32(akademisyenID), baglanti);
            DataSet ds = new DataSet();
            spadapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        void DataGridYuzdeListele()
        {
            baglanti.Open();
            SqlCommand ogrderskaydi = new SqlCommand("spyuzde", baglanti);
            ogrderskaydi.Parameters.AddWithValue("@akademisyenID", (Convert.ToInt32(akademisyenID)));
            SqlDataAdapter spadapter = new SqlDataAdapter("spyuzde " + Convert.ToInt32(akademisyenID), baglanti);
            DataSet ds = new DataSet();
            spadapter.Fill(ds);
            dataGridyuzde.DataSource=ds.Tables[0];
            baglanti.Close();
        }
        private void NotGirisi_Load(object sender, EventArgs e)
        {
            DataGridListele();
            DataGridYuzdeListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtogrno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtderskodu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtvize.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtfinal.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtodev.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtdevam.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnortalama_Click(object sender, EventArgs e)
        {
            try
            { //ORTALAMA HESAPLAMA
            int ort, vizeyuzde, finalyuzde, odevyuzde,vnot,fnot,onot;
            vizeyuzde = Convert.ToInt16(dataGridyuzde.CurrentRow.Cells[0].Value.ToString());
            finalyuzde = Convert.ToInt16(dataGridyuzde.CurrentRow.Cells[1].Value.ToString());
            odevyuzde = Convert.ToInt16(dataGridyuzde.CurrentRow.Cells[2].Value.ToString());
            vnot = Convert.ToInt16(txtvize.Text);
            fnot = Convert.ToInt16(txtfinal.Text);
            onot = Convert.ToInt16(txtodev.Text);
            ort = (vnot * vizeyuzde / 100) + (fnot * finalyuzde / 100) + (onot * odevyuzde / 100);
            txtortalama.Text = ort.ToString();
            MessageBox.Show("Ortalama hesaplama başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! DEĞER GİRİNİZ");
            }
           
        }

        private void btnnotekle_Click(object sender, EventArgs e)
        {//NOT EKLER VEYA GÜNCELLER
            try
            {
            baglanti.Open();
            SqlCommand notekle = new SqlCommand("update OGRENCIDERS set vizenot=@vnot,finalnot=@fnot,odevnot=@onot,devamsizlik=@devam,ortalama=@ort where derskodu=@dkodu and ogrno=@ono", baglanti);
            notekle.Parameters.AddWithValue("@vnot", Convert.ToInt16(txtvize.Text));
            notekle.Parameters.AddWithValue("@fnot", Convert.ToInt16(txtfinal.Text));
            notekle.Parameters.AddWithValue("@onot", Convert.ToInt16(txtodev.Text));
            notekle.Parameters.AddWithValue("@devam", Convert.ToInt16(txtdevam.Text));
            notekle.Parameters.AddWithValue("@ort", Convert.ToInt16(txtortalama.Text));
            notekle.Parameters.AddWithValue("@dkodu", txtderskodu.Text);
            notekle.Parameters.AddWithValue("@ono", Convert.ToInt32(txtogrno.Text));
            notekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Not Girişi / Güncellemesi Başarılı");
            DataGridListele();

            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("HATA");
            }
            
        }
    }
}
