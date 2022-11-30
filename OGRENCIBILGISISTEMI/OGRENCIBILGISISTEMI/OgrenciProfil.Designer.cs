namespace OGRENCIBILGISISTEMI
{
    partial class OgrenciProfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblogrno = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblbkod = new System.Windows.Forms.Label();
            this.lbldanisman = new System.Windows.Forms.Label();
            this.lbldonem = new System.Windows.Forms.Label();
            this.lblogrtur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bölüm Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Danışman:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dönem:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Öğrenim Türü:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblogrtur);
            this.groupBox1.Controls.Add(this.lbldonem);
            this.groupBox1.Controls.Add(this.lbldanisman);
            this.groupBox1.Controls.Add(this.lblbkod);
            this.groupBox1.Controls.Add(this.lblsoyad);
            this.groupBox1.Controls.Add(this.lblad);
            this.groupBox1.Controls.Add(this.lblogrno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 244);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // lblogrno
            // 
            this.lblogrno.AutoSize = true;
            this.lblogrno.Location = new System.Drawing.Point(103, 30);
            this.lblogrno.Name = "lblogrno";
            this.lblogrno.Size = new System.Drawing.Size(64, 13);
            this.lblogrno.TabIndex = 8;
            this.lblogrno.Text = "Öğrenci No:";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(103, 63);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(64, 13);
            this.lblad.TabIndex = 9;
            this.lblad.Text = "Öğrenci No:";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(103, 92);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(64, 13);
            this.lblsoyad.TabIndex = 10;
            this.lblsoyad.Text = "Öğrenci No:";
            // 
            // lblbkod
            // 
            this.lblbkod.AutoSize = true;
            this.lblbkod.Location = new System.Drawing.Point(103, 122);
            this.lblbkod.Name = "lblbkod";
            this.lblbkod.Size = new System.Drawing.Size(64, 13);
            this.lblbkod.TabIndex = 11;
            this.lblbkod.Text = "Öğrenci No:";
            // 
            // lbldanisman
            // 
            this.lbldanisman.AutoSize = true;
            this.lbldanisman.Location = new System.Drawing.Point(103, 151);
            this.lbldanisman.Name = "lbldanisman";
            this.lbldanisman.Size = new System.Drawing.Size(64, 13);
            this.lbldanisman.TabIndex = 12;
            this.lbldanisman.Text = "Öğrenci No:";
            // 
            // lbldonem
            // 
            this.lbldonem.AutoSize = true;
            this.lbldonem.Location = new System.Drawing.Point(103, 183);
            this.lbldonem.Name = "lbldonem";
            this.lbldonem.Size = new System.Drawing.Size(64, 13);
            this.lbldonem.TabIndex = 13;
            this.lbldonem.Text = "Öğrenci No:";
            // 
            // lblogrtur
            // 
            this.lblogrtur.AutoSize = true;
            this.lblogrtur.Location = new System.Drawing.Point(103, 213);
            this.lblogrtur.Name = "lblogrtur";
            this.lblogrtur.Size = new System.Drawing.Size(64, 13);
            this.lblogrtur.TabIndex = 14;
            this.lblogrtur.Text = "Öğrenci No:";
            this.lblogrtur.Click += new System.EventHandler(this.label14_Click);
            // 
            // OgrenciProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OgrenciProfil";
            this.Text = "OgrenciProfil";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.OgrenciProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblogrtur;
        private System.Windows.Forms.Label lbldonem;
        private System.Windows.Forms.Label lbldanisman;
        private System.Windows.Forms.Label lblbkod;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblogrno;
    }
}