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
   
    public partial class OgrenciDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        public OgrenciDuzenle()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txttelno.Text = "";
            cmbbolumkod.Text = "";
            cmbdanisman.Text = "";
            mtxttarih.Text = "";
            cmbdonem.Text = "";
            cmbogrenımdurum.Text = "";
        }
        private void OgrenciDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oGRBILGISISTEMIDataSet9.OGRENCI' table. You can move, or remove it, as needed.
            this.oGRENCITableAdapter1.Fill(this.oGRBILGISISTEMIDataSet9.OGRENCI);
            //COMBOBOX DOLDURMA
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select bolumkodu from bolum", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbbolumkod.Items.Add(oku[0].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select akademisyenID from AKADEMISYEN", baglanti);
            SqlDataReader oku1 = cmd1.ExecuteReader();
            while (oku1.Read())
            {
                cmbdanisman.Items.Add(oku1[0].ToString());
            }
            baglanti.Close();

            // TODO: This line of code loads data into the 'oGRBILGISISTEMIDataSet1.OGRENCI' table. You can move, or remove it, as needed.
            //this.oGRENCITableAdapter.Fill(this.oGRBILGISISTEMIDataSet1.OGRENCI);

        }
        //GUNCELLEME
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE OGRENCI SET ograd=@oad, ogrsoyad=@osoyad, telno=@tel, bolumkodu=@bkodu, akademisyenID=@akID, baslamatarihi=@bastar, donem=@dnm, ogrenımdurumu=@ogrdm where ogrno=@numara", baglanti);
            cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@oad", txtad.Text);
            cmd.Parameters.AddWithValue("@osoyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@tel", txttelno.Text);
            cmd.Parameters.AddWithValue("@bkodu", cmbbolumkod.Text);
            cmd.Parameters.AddWithValue("@akID", Convert.ToInt16(cmbdanisman.Text));
            cmd.Parameters.AddWithValue("@bastar", mtxttarih.Text);
            cmd.Parameters.AddWithValue("@dnm", cmbdonem.Text);
            cmd.Parameters.AddWithValue("@ogrdm",cmbogrenımdurum.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci güncelleme başarılı");
            //this.oGRENCITableAdapter.Fill(this.oGRBILGISISTEMIDataSet1.OGRENCI);//goruntuleme
            this.oGRENCITableAdapter1.Fill(this.oGRBILGISISTEMIDataSet9.OGRENCI);

            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Hatalı veri");
            }
            
        }
        //EKLEME
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into OGRENCI(ograd,ogrsoyad,telno,bolumkodu,akademisyenID,baslamatarihi,donem,ogrenımdurumu) values (@oad, @osoyad, @tel, @bkodu, @akID,@dogtar, @dnm,  @ogrenimdrm)",baglanti);
            cmd.Parameters.AddWithValue("@oad", txtad.Text);
            cmd.Parameters.AddWithValue("@osoyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@tel", txttelno.Text);
            cmd.Parameters.AddWithValue("@bkodu", cmbbolumkod.Text);
            cmd.Parameters.AddWithValue("@akID", Convert.ToInt16(cmbdanisman.Text));
            cmd.Parameters.AddWithValue("@dogtar", mtxttarih.Text);
            cmd.Parameters.AddWithValue("@dnm", Convert.ToInt16(cmbdonem.Text));
            cmd.Parameters.AddWithValue("@ogrenimdrm", cmbogrenımdurum.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci kaydı başarılı");
            temizle();
            //this.oGRENCITableAdapter.Fill(this.oGRBILGISISTEMIDataSet1.OGRENCI);//datagrid guncelleme
            this.oGRENCITableAdapter1.Fill(this.oGRBILGISISTEMIDataSet9.OGRENCI);
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("GİRİŞ HATALI!");
            }
        }
        //SİLME
        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            { baglanti.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM OGRENCI where ogrno=@numara", baglanti);
            cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci silme işlemi başarılı");
            //this.oGRENCITableAdapter.Fill(this.oGRBILGISISTEMIDataSet1.OGRENCI);
            this.oGRENCITableAdapter1.Fill(this.oGRBILGISISTEMIDataSet9.OGRENCI);

            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("hata! Silme İşlemi Başarısız");
            }
           
        }

        private void cmbbolumkod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //burasi* bos alan
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string ad, soyad, telno, bolumkodu, akademisyenID, baslamatarihi, donem, ogrenimdurum;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            telno = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            bolumkodu = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            akademisyenID = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            baslamatarihi = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            donem = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            ogrenimdurum = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtad.Text = ad;
            txtsoyad.Text = soyad;
            txttelno.Text = telno;
            cmbbolumkod.Text = bolumkodu;
            cmbdanisman.Text = akademisyenID;
            mtxttarih.Text = baslamatarihi;
            cmbdonem.Text = donem;
            cmbogrenımdurum.Text = ogrenimdurum;
        }
    }
}
