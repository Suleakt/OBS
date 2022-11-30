namespace OGRENCIBILGISISTEMI
{
    partial class AkademisyenListele
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
            this.txtakademisyenad = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtakademisyenad
            // 
            this.txtakademisyenad.Location = new System.Drawing.Point(26, 56);
            this.txtakademisyenad.Name = "txtakademisyenad";
            this.txtakademisyenad.Size = new System.Drawing.Size(100, 20);
            this.txtakademisyenad.TabIndex = 1;
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.SandyBrown;
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnara.Location = new System.Drawing.Point(149, 51);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(88, 29);
            this.btnara.TabIndex = 2;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Akademisyen adına göre arama yapar:";
            // 
            // AkademisyenListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(699, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtakademisyenad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AkademisyenListele";
            this.Text = "Ada Göre Akademisyen Arama";
            this.Load += new System.EventHandler(this.AkademisyenListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtakademisyenad;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label label1;
    }
}