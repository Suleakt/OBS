namespace OGRENCIBILGISISTEMI
{
    partial class Devam
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
            this.txtdevam = new System.Windows.Forms.TextBox();
            this.btndevam = new System.Windows.Forms.Button();
            this.btnraporla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(289, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtdevam
            // 
            this.txtdevam.Location = new System.Drawing.Point(12, 40);
            this.txtdevam.Name = "txtdevam";
            this.txtdevam.Size = new System.Drawing.Size(100, 20);
            this.txtdevam.TabIndex = 1;
            // 
            // btndevam
            // 
            this.btndevam.Location = new System.Drawing.Point(118, 37);
            this.btndevam.Name = "btndevam";
            this.btndevam.Size = new System.Drawing.Size(75, 23);
            this.btndevam.TabIndex = 2;
            this.btndevam.Text = "Görüntüle ";
            this.btndevam.UseVisualStyleBackColor = true;
            this.btndevam.Click += new System.EventHandler(this.btndevam_Click);
            // 
            // btnraporla
            // 
            this.btnraporla.Location = new System.Drawing.Point(199, 37);
            this.btnraporla.Name = "btnraporla";
            this.btnraporla.Size = new System.Drawing.Size(102, 35);
            this.btnraporla.TabIndex = 4;
            this.btnraporla.Text = "RAPORLA";
            this.btnraporla.UseVisualStyleBackColor = true;
            this.btnraporla.Click += new System.EventHandler(this.btnraporla_Click);
            // 
            // Devam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 261);
            this.Controls.Add(this.btnraporla);
            this.Controls.Add(this.btndevam);
            this.Controls.Add(this.txtdevam);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Devam";
            this.Text = "Devam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdevam;
        private System.Windows.Forms.Button btndevam;
        private System.Windows.Forms.Button btnraporla;
    }
}