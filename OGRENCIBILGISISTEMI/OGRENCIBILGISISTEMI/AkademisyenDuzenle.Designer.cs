namespace OGRENCIBILGISISTEMI
{
    partial class AkademisyenDuzenle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkademisyenDuzenle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbunvan = new System.Windows.Forms.ComboBox();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.txtaksoyad = new System.Windows.Forms.TextBox();
            this.txtakad = new System.Windows.Forms.TextBox();
            this.cmbbolumkod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.akademisyenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKADEMISYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGRBILGISISTEMIDataSet2 = new OGRENCIBILGISISTEMI.OGRBILGISISTEMIDataSet2();
            this.aKADEMISYENTableAdapter = new OGRENCIBILGISISTEMI.OGRBILGISISTEMIDataSet2TableAdapters.AKADEMISYENTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKADEMISYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRBILGISISTEMIDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbunvan);
            this.groupBox1.Controls.Add(this.txteposta);
            this.groupBox1.Controls.Add(this.txtaksoyad);
            this.groupBox1.Controls.Add(this.txtakad);
            this.groupBox1.Controls.Add(this.cmbbolumkod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(181, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 196);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Akademisyen Bilgileri";
            // 
            // cmbunvan
            // 
            this.cmbunvan.FormattingEnabled = true;
            this.cmbunvan.Items.AddRange(new object[] {
            "Araştırma Görevlisi",
            "Yardımcı Doçent",
            "Doçent",
            "Profesör"});
            this.cmbunvan.Location = new System.Drawing.Point(123, 92);
            this.cmbunvan.Name = "cmbunvan";
            this.cmbunvan.Size = new System.Drawing.Size(100, 21);
            this.cmbunvan.TabIndex = 11;
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(123, 125);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(100, 20);
            this.txteposta.TabIndex = 10;
            // 
            // txtaksoyad
            // 
            this.txtaksoyad.Location = new System.Drawing.Point(123, 59);
            this.txtaksoyad.Name = "txtaksoyad";
            this.txtaksoyad.Size = new System.Drawing.Size(100, 20);
            this.txtaksoyad.TabIndex = 8;
            // 
            // txtakad
            // 
            this.txtakad.Location = new System.Drawing.Point(123, 25);
            this.txtakad.Name = "txtakad";
            this.txtakad.Size = new System.Drawing.Size(100, 20);
            this.txtakad.TabIndex = 7;
            // 
            // cmbbolumkod
            // 
            this.cmbbolumkod.FormattingEnabled = true;
            this.cmbbolumkod.Location = new System.Drawing.Point(123, 157);
            this.cmbbolumkod.Name = "cmbbolumkod";
            this.cmbbolumkod.Size = new System.Drawing.Size(100, 21);
            this.cmbbolumkod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bölüm Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unvan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 128);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Posta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Location = new System.Drawing.Point(445, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 196);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Menüsü";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsil.Location = new System.Drawing.Point(49, 140);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(94, 38);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnguncelle.Location = new System.Drawing.Point(49, 80);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(94, 43);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnkaydet.Location = new System.Drawing.Point(49, 23);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 42);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.akademisyenIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.unvanDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.bolumkoduDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aKADEMISYENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 171);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // akademisyenIDDataGridViewTextBoxColumn
            // 
            this.akademisyenIDDataGridViewTextBoxColumn.DataPropertyName = "akademisyenID";
            this.akademisyenIDDataGridViewTextBoxColumn.HeaderText = "akademisyenID";
            this.akademisyenIDDataGridViewTextBoxColumn.Name = "akademisyenIDDataGridViewTextBoxColumn";
            this.akademisyenIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "unvan";
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            this.unvanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "eposta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            this.epostaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumkoduDataGridViewTextBoxColumn
            // 
            this.bolumkoduDataGridViewTextBoxColumn.DataPropertyName = "bolumkodu";
            this.bolumkoduDataGridViewTextBoxColumn.HeaderText = "bolumkodu";
            this.bolumkoduDataGridViewTextBoxColumn.Name = "bolumkoduDataGridViewTextBoxColumn";
            this.bolumkoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aKADEMISYENBindingSource
            // 
            this.aKADEMISYENBindingSource.DataMember = "AKADEMISYEN";
            this.aKADEMISYENBindingSource.DataSource = this.oGRBILGISISTEMIDataSet2;
            // 
            // oGRBILGISISTEMIDataSet2
            // 
            this.oGRBILGISISTEMIDataSet2.DataSetName = "OGRBILGISISTEMIDataSet2";
            this.oGRBILGISISTEMIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aKADEMISYENTableAdapter
            // 
            this.aKADEMISYENTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AkademisyenDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AkademisyenDuzenle";
            this.Text = "AkademisyenDuzenle";
            this.Load += new System.EventHandler(this.AkademisyenDuzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKADEMISYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRBILGISISTEMIDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.TextBox txtaksoyad;
        private System.Windows.Forms.TextBox txtakad;
        private System.Windows.Forms.ComboBox cmbbolumkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OGRBILGISISTEMIDataSet2 oGRBILGISISTEMIDataSet2;
        private System.Windows.Forms.BindingSource aKADEMISYENBindingSource;
        private OGRBILGISISTEMIDataSet2TableAdapters.AKADEMISYENTableAdapter aKADEMISYENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn akademisyenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbunvan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}