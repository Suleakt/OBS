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
    public partial class AkademisyenDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");
        //int b;
        //void listele()
        //{
           
        //    //if (baglanti.State == ConnectionState.Closed)
        //    //{
        //    //    baglanti.Open();
        //    //    SqlCommand cmd = new SqlCommand();
        //    //    cmd.Connection = baglanti;
        //    //    cmd.CommandText = "Select * From AKADEMISYEN";
        //    //    SqlDataAdapter adptr = new SqlDataAdapter(cmd);
        //    //    DataSet ds = new DataSet();
        //    //    adptr.Fill(ds, "AKADEMISYEN");
        //    //    dataGridView1.DataSource = ds.Tables["AKADEMISYEN"];
        //    //    baglanti.Close();

        //    //}
        //}
        void temizle()
        {
            txtakad.Text = "";
            txtaksoyad.Text = "";
            cmbunvan.Text = "";
            txteposta.Text = "";
            cmbbolumkod.Text = "";
        }
        public AkademisyenDuzenle()
        {
            InitializeComponent();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediginize emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "DELETE FROM AKADEMISYEN WHERE akademisyenID=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    this.aKADEMISYENTableAdapter.Fill(this.oGRBILGISISTEMIDataSet2.AKADEMISYEN);
                    temizle();
                    MessageBox.Show("KAYIT SILINMISTIR");
                }
            }
        }

        private void AkademisyenDuzenle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select bolumkodu from bolum", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbbolumkod.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
            
            // TODO: This line of code loads data into the 'oGRBILGISISTEMIDataSet2.AKADEMISYEN' table. You can move, or remove it, as needed.
            this.aKADEMISYENTableAdapter.Fill(this.oGRBILGISISTEMIDataSet2.AKADEMISYEN);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string ad, soyad, unvan, eposta, bolumkodu;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            unvan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            eposta = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            bolumkodu = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtakad.Text = ad;
            txtaksoyad.Text = soyad;
            cmbunvan.Text = unvan;
            txteposta.Text = eposta;
            cmbbolumkod.Text = bolumkodu;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO AKADEMISYEN(ad, soyad, unvan, eposta,bolumkodu) VALUES ('" + txtakad.Text + "','" + txtaksoyad.Text + "','" + cmbunvan.Text + "','" + txteposta.Text + "','" + cmbbolumkod.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                this.aKADEMISYENTableAdapter.Fill(this.oGRBILGISISTEMIDataSet2.AKADEMISYEN);
                temizle();
                MessageBox.Show("Akademisyen Kayit Islemi Gerceklestirilmistir.");
            }
            else
                baglanti.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update AKADEMISYEN set ad='" + txtakad.Text + "',soyad='" + txtaksoyad.Text + "',unvan='" + cmbunvan.Text + "',eposta='" + txteposta.Text + "', bolumkodu='"+cmbbolumkod.Text+"' where akademisyenID=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                this.aKADEMISYENTableAdapter.Fill(this.oGRBILGISISTEMIDataSet2.AKADEMISYEN);
                temizle();
                MessageBox.Show("Bilgi Duzenleme Islemi Gerceklestirilmistir");

            }
        }
    }
}
