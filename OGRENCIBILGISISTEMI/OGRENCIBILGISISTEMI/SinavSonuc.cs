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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace OGRENCIBILGISISTEMI
{
    public partial class SinavSonuc : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");
        public string ogrno = GIRIS.ogrno;
        public SinavSonuc()
        { 
            InitializeComponent();
        }

        private void SinavSonuc_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ogrderskaydi = new SqlCommand("sınavsonuc", baglanti);
            ogrderskaydi.Parameters.AddWithValue("@ogrno", (Convert.ToInt32(ogrno)));
            SqlDataAdapter spadapter = new SqlDataAdapter("sınavsonuc " + Convert.ToInt32(ogrno), baglanti);
            DataSet ds = new DataSet();
            spadapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnraporla_Click(object sender, EventArgs e)
        {
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
        }
    }
}
