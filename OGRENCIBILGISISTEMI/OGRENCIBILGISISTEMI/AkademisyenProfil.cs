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
    public partial class AkademisyenProfil : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");
        public string akid = GIRIS.ogrno;
        void listele()

        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "Select * From AKADEMISYEN where akademisyenID=@akıd";
                cmd.Parameters.AddWithValue("@akıd", Convert.ToInt16(akid));
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptr.Fill(ds, "AKADEMISYEN");
                dataGridView1.DataSource = ds.Tables["AKADEMISYEN"];
                baglanti.Close();

            }
        }
        public AkademisyenProfil()
        {
            InitializeComponent();
        }

        private void AkademisyenProfil_Load(object sender, EventArgs e)
        {
            listele();
           
            lblad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblbkod.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lblunvan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lbleposta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
            dataGridView1.Visible = false;
        }
    }
}
