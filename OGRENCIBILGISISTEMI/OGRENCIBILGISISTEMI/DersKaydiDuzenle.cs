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
    public partial class DersKaydiDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        public DersKaydiDuzenle()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtogrno.Text = "";
            txtderskodu.Text = "";
            txtvizenotu.Text="";
            txtfinalnotu.Text="";
            txtodevnotu.Text="";
            txtdevamsizlik.Text="";
            txtort.Text="";
        }

        private void DersKaydiDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oGRBILGISISTEMIDataSet11.OGRENCIDERS' table. You can move, or remove it, as needed.
            this.oGRENCIDERSTableAdapter.Fill(this.oGRBILGISISTEMIDataSet11.OGRENCIDERS);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO OGRENCIDERS(ogrno, derskodu, vizenot, finalnot,odevnot,devamsizlik, ortalama) VALUES ('" + txtogrno.Text + "','" + txtderskodu.Text + "','" + txtvizenotu.Text + "','" + txtfinalnotu.Text + "','" + txtodevnotu.Text + "','" + txtdevamsizlik.Text + "','" + txtort.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    this.oGRENCIDERSTableAdapter.Fill(this.oGRBILGISISTEMIDataSet11.OGRENCIDERS);
                    temizle();
                    MessageBox.Show("Ders Kayit Islemi Gerceklestirilmistir.");
                }
                else
                    baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!");
            }
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update OGRENCIDERS set ogrno='" + txtogrno.Text + "', derskodu='" + txtderskodu.Text + "', vizenot='" + txtvizenotu.Text + "', finalnot='" + txtfinalnotu.Text + "', odevnot='" + txtodevnotu.Text + "', devamsizlik='" + txtdevamsizlik.Text + "', ortalama='" + txtort.Text + "' where ogrno=@no and bolumkodu=bkod";
                cmd.Parameters.AddWithValue("@bkod", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@no", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                this.oGRENCIDERSTableAdapter.Fill(this.oGRBILGISISTEMIDataSet11.OGRENCIDERS); 
                temizle();
                MessageBox.Show("Ders Kaydı Güncelleme İşlemi Gerçekleşti");

            }
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
                    cmd.CommandText = "DELETE FROM OGRENCIDERS WHERE derskodu=@dkod and ogrno=@no";
                    cmd.Parameters.AddWithValue("@dkod", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@no", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    this.oGRENCIDERSTableAdapter.Fill(this.oGRBILGISISTEMIDataSet11.OGRENCIDERS);
                    temizle();
                    MessageBox.Show("KAYIT SILINMISTIR");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //HATALI YER
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtogrno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtderskodu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtvizenotu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtfinalnotu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtodevnotu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtdevamsizlik.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtort.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        }
    }

