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
    public partial class Yetkilendirme : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        public Yetkilendirme()
        {
            InitializeComponent();
        }

        private void Yetkilendirme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oGRBILGISISTEMIDataSet12.YETKI' table. You can move, or remove it, as needed.
            this.yETKITableAdapter.Fill(this.oGRBILGISISTEMIDataSet12.YETKI);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //SqlCommand cmd = new SqlCommand("update YETKI set erisim=@erisim1 where formadi=@fadi1 and yetki=@yetki1", baglanti);
            //cmd.Parameters.Add("@fadi1", txtformadi.Text);
            //cmd.Parameters.Add("@erisim1", txtyetki.Text);
            //cmd.Parameters.Add("@yetki1", txterisim.Text);
            //cmd.ExecuteNonQuery();
            //baglanti.Close();
            //MessageBox.Show("bölüm güncellendi");
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update YETKI set erisim='" + txterisim.Text + "' where yetki=@yet and formadi=@fadi";
                cmd.Parameters.AddWithValue("@fadi", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@yet", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                this.yETKITableAdapter.Fill(this.oGRBILGISISTEMIDataSet12.YETKI);
                MessageBox.Show("Bilgi Duzenleme Islemi Gerceklestirilmistir");

            }
            
        }
        int secilen;
        string f_adi;
        string ersm;
        string ytki;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            f_adi = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ersm = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            ytki = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtformadi.Text = f_adi;
            txtyetki.Text = ytki;
            txterisim.Text = ersm.ToString();
          
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "DELETE FROM YETKI WHERE formadi=@fadi and yetki=@yet";
                cmd.Parameters.AddWithValue("@fadi", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@yet", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                this.yETKITableAdapter.Fill(this.oGRBILGISISTEMIDataSet12.YETKI);
                MessageBox.Show("Kayıt Silme İşlemi Yerine Erişim Biti False Yapıldı");
            }
        }
    }
}
