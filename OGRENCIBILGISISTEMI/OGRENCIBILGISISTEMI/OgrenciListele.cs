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
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;



namespace OGRENCIBILGISISTEMI
{
    public partial class OgrenciListele : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        public OgrenciListele()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
           baglanti.Open();
            SqlCommand ders = new SqlCommand("spdersarama", baglanti);
            ders.Parameters.AddWithValue("@dersadi", (cmbdersegoreogr.Text.ToString()));
            SqlDataAdapter spadapter = new SqlDataAdapter("spdersarama " +cmbdersegoreogr.Text.ToString(), baglanti);
            DataSet ds = new DataSet();
            spadapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        //***
        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select dersadi from DERS", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbdersegoreogr.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Excel.Application exceldosya = new Excel.Application();
            //object Missing = Type.Missing;
            //Workbook calismakitabı = exceldosya.Workbooks.Add(Missing);
            //Worksheet sheet1 = (Worksheet)calismakitabı.Sheets[0];

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartRow = 1;
            int StartCol = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();


                }
            }
            MessageBox.Show("İŞLEM BAŞARILI");
            //exceldosya.Visible = true;
                
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            
        //}
    }
}
