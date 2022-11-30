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
    
    public partial class GIRIS : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");
       public static string ogrno;
        public GIRIS()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            //try
            //{
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from GIRIS where kullaniciadi=@kad and sifre=@sif", baglanti);
                cmd.Parameters.AddWithValue("@kad", txtkullaniciadi.Text);
                cmd.Parameters.AddWithValue("@sif", txtsifre.Text);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string yet = "select yetki from GIRIS where sifre=@sif";
                    SqlCommand cmd2 = new SqlCommand(yet, baglanti);
                    cmd2.Parameters.AddWithValue("@sif", txtsifre.Text);
                    cmd2.ExecuteNonQuery();
                    string isim = cmd2.ExecuteScalar().ToString();
                    AnaForm af = new AnaForm();//bu
                    af.yetki = isim;
                    ogrno = txtkullaniciadi.Text;                  
                    MessageBox.Show("kullanıcı girişi onaylandı");
                    af.Show();//ve bu
                    this.Hide();
                }
                else
                    MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI");
                    baglanti.Close();

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI");
            //}
        }
    }
}
