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
    public partial class Yedekleme : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC;Initial Catalog=OGRBILGISISTEMI;Integrated Security=True");

        public Yedekleme()
        {
            InitializeComponent();
        }

        private void btndosyayersec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtbackupdosyaad.Text = dlg.SelectedPath;
                btnyedekle.Enabled = true;
            }
        }

        private void btnyedekle_Click(object sender, EventArgs e)
        {
            string database = baglanti.Database.ToString();
            try
            {
                if (txtbackupdosyaad.Text == string.Empty)
                {
                    MessageBox.Show("please enter backup file location");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtbackupdosyaad.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, baglanti))
                    {
                        if (baglanti.State != ConnectionState.Open)
                        {
                            baglanti.Open();
                        }
                        command.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Yedekleme İşlemi Gerçekleşti");
                        btnyedekle.Enabled = false;
                    }
                }

            }
            catch
            {

            }
        }

        private void btndosyabul_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Restore database";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtdosyaad.Text = dlg.FileName;
            }
        }

        private void btnyedektendön_Click(object sender, EventArgs e)
        {
            string database = baglanti.Database.ToString();
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, baglanti);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtdosyaad.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, baglanti);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, baglanti);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Yedekten Dönme İşlemi Başarılı");
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
