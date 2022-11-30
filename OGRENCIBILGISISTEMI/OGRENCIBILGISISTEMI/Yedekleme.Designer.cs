namespace OGRENCIBILGISISTEMI
{
    partial class Yedekleme
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
            this.txtbackupdosyaad = new System.Windows.Forms.TextBox();
            this.btndosyayersec = new System.Windows.Forms.Button();
            this.btnyedektendön = new System.Windows.Forms.Button();
            this.txtdosyaad = new System.Windows.Forms.TextBox();
            this.btndosyabul = new System.Windows.Forms.Button();
            this.btnyedekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbackupdosyaad
            // 
            this.txtbackupdosyaad.Location = new System.Drawing.Point(161, 54);
            this.txtbackupdosyaad.Name = "txtbackupdosyaad";
            this.txtbackupdosyaad.Size = new System.Drawing.Size(100, 20);
            this.txtbackupdosyaad.TabIndex = 24;
            // 
            // btndosyayersec
            // 
            this.btndosyayersec.Location = new System.Drawing.Point(66, 37);
            this.btndosyayersec.Name = "btndosyayersec";
            this.btndosyayersec.Size = new System.Drawing.Size(75, 37);
            this.btndosyayersec.TabIndex = 23;
            this.btndosyayersec.Text = "DOSYA YERİ SEÇ";
            this.btndosyayersec.UseVisualStyleBackColor = true;
            this.btndosyayersec.Click += new System.EventHandler(this.btndosyayersec_Click);
            // 
            // btnyedektendön
            // 
            this.btnyedektendön.Location = new System.Drawing.Point(186, 247);
            this.btnyedektendön.Name = "btnyedektendön";
            this.btnyedektendön.Size = new System.Drawing.Size(75, 38);
            this.btnyedektendön.TabIndex = 22;
            this.btnyedektendön.Text = "RESTORE";
            this.btnyedektendön.UseVisualStyleBackColor = true;
            this.btnyedektendön.Click += new System.EventHandler(this.btnyedektendön_Click);
            // 
            // txtdosyaad
            // 
            this.txtdosyaad.Location = new System.Drawing.Point(161, 210);
            this.txtdosyaad.Name = "txtdosyaad";
            this.txtdosyaad.Size = new System.Drawing.Size(100, 20);
            this.txtdosyaad.TabIndex = 21;
            // 
            // btndosyabul
            // 
            this.btndosyabul.Location = new System.Drawing.Point(66, 194);
            this.btndosyabul.Name = "btndosyabul";
            this.btndosyabul.Size = new System.Drawing.Size(75, 36);
            this.btndosyabul.TabIndex = 20;
            this.btndosyabul.Text = "DOSYA BUL";
            this.btndosyabul.UseVisualStyleBackColor = true;
            this.btndosyabul.Click += new System.EventHandler(this.btndosyabul_Click);
            // 
            // btnyedekle
            // 
            this.btnyedekle.Enabled = false;
            this.btnyedekle.Location = new System.Drawing.Point(186, 99);
            this.btnyedekle.Name = "btnyedekle";
            this.btnyedekle.Size = new System.Drawing.Size(75, 37);
            this.btnyedekle.TabIndex = 19;
            this.btnyedekle.Text = "BACK UP";
            this.btnyedekle.UseVisualStyleBackColor = true;
            this.btnyedekle.Click += new System.EventHandler(this.btnyedekle_Click);
            // 
            // Yedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 322);
            this.Controls.Add(this.txtbackupdosyaad);
            this.Controls.Add(this.btndosyayersec);
            this.Controls.Add(this.btnyedektendön);
            this.Controls.Add(this.txtdosyaad);
            this.Controls.Add(this.btndosyabul);
            this.Controls.Add(this.btnyedekle);
            this.Name = "Yedekleme";
            this.Text = "Yedekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbackupdosyaad;
        private System.Windows.Forms.Button btndosyayersec;
        private System.Windows.Forms.Button btnyedektendön;
        private System.Windows.Forms.TextBox txtdosyaad;
        private System.Windows.Forms.Button btndosyabul;
        private System.Windows.Forms.Button btnyedekle;
    }
}