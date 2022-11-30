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
using System.IO;

namespace OGRENCIBILGISISTEMI
{
    public partial class BolumDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        public BolumDuzenle()
        {
            InitializeComponent();
        }
         void temizle()
        {
            txtbolumkod.Text = "";
            txtbolumad.Text = "";
        }
        private void BolumDuzenle_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'oGRBILGISISTEMIDataSet10.BOLUM' table. You can move, or remove it, as needed.
            this.bOLUMTableAdapter.Fill(this.oGRBILGISISTEMIDataSet10.BOLUM);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO BOLUM(bolumkodu, bolumad) VALUES ('" + txtbolumkod.Text + "','" + txtbolumad.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                this.bOLUMTableAdapter.Fill(this.oGRBILGISISTEMIDataSet10.BOLUM); 
                temizle();
                MessageBox.Show("Bölüm Kayit Islemi Gerceklestirilmistir.");
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
                cmd.CommandText = "update BOLUM set bolumkodu='" + txtbolumkod.Text + "', bolumad='" + txtbolumad.Text + "' where bolumkodu=@bkod";
                cmd.Parameters.AddWithValue("@bkod", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                this.bOLUMTableAdapter.Fill(this.oGRBILGISISTEMIDataSet10.BOLUM);
                temizle();
                MessageBox.Show("Bölüm Güncelleme İşlemi Gerçekleşti");

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
                    cmd.CommandText = "DELETE FROM BOLUM WHERE bolumkodu=@bkod";
                    cmd.Parameters.AddWithValue("@bkod", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    this.bOLUMTableAdapter.Fill(this.oGRBILGISISTEMIDataSet10.BOLUM);
                    temizle();
                    MessageBox.Show("KAYIT SILINMISTIR");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbolumkod.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtbolumad.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnimport_Click(object sender, EventArgs e)
        {

            StreamReader inputstream = File.OpenText(@"C:\Users\PCburada\Desktop\bolumkod.txt");
            string s;
            // s = inputstream.ReadLine();
            int x = 0;
            while ((s = inputstream.ReadLine()) != null)
            {
                if (s != " ")
                {
                    string[] strDizi = s.Split(',');

                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                    String a = "";

                    for (int i = 0; i < strDizi.Length; i++)
                    {
                        // row.Cells[i].Value = strDizi[i];

                        a += strDizi[i];

                    }

                    // dataGridView1.Rows.Add(row);

                    MessageBox.Show(a);
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("insert into BOLUM (bolumkodu) values (@a)", baglanti);
                    cmd.Parameters.AddWithValue("@a", a);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    //  dataGridView1.Rows[i].Cells[0].Value = 
                    //  dataGridView1.Rows[i].Cells[1].Value = ;

                    x = x + 1;
                    this.bOLUMTableAdapter.Fill(this.oGRBILGISISTEMIDataSet10.BOLUM);
                }
            }
            inputstream.Close();
        }
        }
    }

