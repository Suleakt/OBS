using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGRENCIBILGISISTEMI
{
    public partial class AnaForm : Form
    {
        public string yetki;
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'oGRBILGISISTEMIDataSet.YETKI' table. You can move, or remove it, as needed.
            this.yETKITableAdapter.Fill(this.oGRBILGISISTEMIDataSet.YETKI);
           // textBox1.Text = yetki;
           // textBox1.Visible = false;
            dataGridView2.Visible = false;
            if (yetki == "0")
            {
                foreach (DataRow satir in oGRBILGISISTEMIDataSet.YETKI.Rows)
                {

                    if (bool.Parse(satir["erisim"].ToString()) == false && satir["yetki"].ToString() == "0")
                    {   //menüleri dolaşıp yetki tablosuna göre menü görünürlüğünü ayarlar
                        foreach (ToolStripMenuItem menItem in menuStrip2.Items)
                        {
                            if (menItem.Text == satir["formadi"].ToString())
                                menItem.Visible = false;
                            foreach (ToolStripDropDownItem subitem in menItem.DropDownItems)
                            {
                                if (subitem.Text == satir["formadi"].ToString())
                                    subitem.Visible = false;
                            }
                        }
                    }

                }
            }
            else if (yetki == "1")
            {
                foreach (DataRow satir in oGRBILGISISTEMIDataSet.YETKI.Rows)
                {

                    if (bool.Parse(satir["erisim"].ToString()) == false && satir["yetki"].ToString() == "1")
                    {
                        foreach (ToolStripMenuItem menItem in menuStrip2.Items)
                        {
                            if (menItem.Text == satir["formadi"].ToString())
                                menItem.Visible = false;
                            foreach (ToolStripDropDownItem subitem in menItem.DropDownItems)
                            {
                                if (subitem.Text == satir["formadi"].ToString())
                                    subitem.Visible = false;
                            }
                        }
                    }

                }
            }
            if (yetki == "2")
            {
                foreach (DataRow satir in oGRBILGISISTEMIDataSet.YETKI.Rows)
                {

                    if (bool.Parse(satir["erisim"].ToString()) == false && satir["yetki"].ToString() == "2")
                    {   //menüleri dolaşıp yetki tablosuna göre menü görünürlüğünü ayarlar
                        foreach (ToolStripMenuItem menItem in menuStrip2.Items)
                        {
                            if (menItem.Text == satir["formadi"].ToString())
                                menItem.Visible = false;
                            foreach (ToolStripDropDownItem subitem in menItem.DropDownItems)
                            {
                                if (subitem.Text == satir["formadi"].ToString())
                                    subitem.Visible = false;
                            }
                        }
                    }

                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OgrenciDuzenle yeni = new OgrenciDuzenle();
            yeni.Show();

        }

        private void aKDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkademisyenDuzenle yeni = new AkademisyenDuzenle();
            yeni.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            DersSecme yeni = new DersSecme();
            yeni.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OgrenciListele yeni = new OgrenciListele();
            yeni.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            NotGirisi ng = new NotGirisi();
            ng.Show();
        }

        private void sınavSonuçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinavSonuc ss = new SinavSonuc();
            ss.Show();

        }

        private void devamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devam dd = new Devam();
            dd.Show();


        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            DersPlani yeni = new DersPlani();
            yeni.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            DersProgrami yeni = new DersProgrami();
            yeni.Show();
        }

        private void bölümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumDuzenle yeni = new BolumDuzenle();
            yeni.Show();
        }

        private void dKEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersKaydiDuzenle dkd = new DersKaydiDuzenle();
            dkd.Show();
        }

        private void aKListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkademisyenListele akl = new AkademisyenListele();
            akl.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Yetkilendirme yet = new Yetkilendirme();
            yet.Show();
        }

        private void ögrenciProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciProfil yeni = new OgrenciProfil();
            yeni.Show();
        }

        private void akademisyenProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkademisyenProfil ap = new AkademisyenProfil();
            ap.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Transkript t = new Transkript();
            t.Show();
        }

        private void yüzdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yuzde y = new Yuzde();
            y.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //ANASAYFAYA DÖNÜŞ
            this.Hide();
            GIRIS grs = new GIRIS();
            grs.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //YEDEKLE/YEDEKTEN DÖN SAYFASI
            Yedekleme yedek = new Yedekleme();
            yedek.Show();
        }
    }
}
