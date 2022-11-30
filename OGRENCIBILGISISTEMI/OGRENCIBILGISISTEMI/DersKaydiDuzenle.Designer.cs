namespace OGRENCIBILGISISTEMI
{
    partial class DersKaydiDuzenle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrencıdersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derskoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizenotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalnotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odevnotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devamsizlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRENCIDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGRBILGISISTEMIDataSet11 = new OGRENCIBILGISISTEMI.OGRBILGISISTEMIDataSet11();
            this.oGRENCIDERSTableAdapter = new OGRENCIBILGISISTEMI.OGRBILGISISTEMIDataSet11TableAdapters.OGRENCIDERSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtogrno = new System.Windows.Forms.TextBox();
            this.txtderskodu = new System.Windows.Forms.TextBox();
            this.txtvizenotu = new System.Windows.Forms.TextBox();
            this.txtfinalnotu = new System.Windows.Forms.TextBox();
            this.txtodevnotu = new System.Windows.Forms.TextBox();
            this.txtdevamsizlik = new System.Windows.Forms.TextBox();
            this.txtort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRENCIDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRBILGISISTEMIDataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Location = new System.Drawing.Point(454, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 202);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Menüsü";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsil.Location = new System.Drawing.Point(49, 140);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(94, 39);
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
            this.ogrencıdersIDDataGridViewTextBoxColumn,
            this.ogrnoDataGridViewTextBoxColumn,
            this.derskoduDataGridViewTextBoxColumn,
            this.vizenotDataGridViewTextBoxColumn,
            this.finalnotDataGridViewTextBoxColumn,
            this.odevnotDataGridViewTextBoxColumn,
            this.devamsizlikDataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oGRENCIDERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrencıdersIDDataGridViewTextBoxColumn
            // 
            this.ogrencıdersIDDataGridViewTextBoxColumn.DataPropertyName = "ogrencıdersID";
            this.ogrencıdersIDDataGridViewTextBoxColumn.HeaderText = "ogrencıdersID";
            this.ogrencıdersIDDataGridViewTextBoxColumn.Name = "ogrencıdersIDDataGridViewTextBoxColumn";
            this.ogrencıdersIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrnoDataGridViewTextBoxColumn
            // 
            this.ogrnoDataGridViewTextBoxColumn.DataPropertyName = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.HeaderText = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.Name = "ogrnoDataGridViewTextBoxColumn";
            this.ogrnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // derskoduDataGridViewTextBoxColumn
            // 
            this.derskoduDataGridViewTextBoxColumn.DataPropertyName = "derskodu";
            this.derskoduDataGridViewTextBoxColumn.HeaderText = "derskodu";
            this.derskoduDataGridViewTextBoxColumn.Name = "derskoduDataGridViewTextBoxColumn";
            this.derskoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vizenotDataGridViewTextBoxColumn
            // 
            this.vizenotDataGridViewTextBoxColumn.DataPropertyName = "vizenot";
            this.vizenotDataGridViewTextBoxColumn.HeaderText = "vizenot";
            this.vizenotDataGridViewTextBoxColumn.Name = "vizenotDataGridViewTextBoxColumn";
            this.vizenotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalnotDataGridViewTextBoxColumn
            // 
            this.finalnotDataGridViewTextBoxColumn.DataPropertyName = "finalnot";
            this.finalnotDataGridViewTextBoxColumn.HeaderText = "finalnot";
            this.finalnotDataGridViewTextBoxColumn.Name = "finalnotDataGridViewTextBoxColumn";
            this.finalnotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odevnotDataGridViewTextBoxColumn
            // 
            this.odevnotDataGridViewTextBoxColumn.DataPropertyName = "odevnot";
            this.odevnotDataGridViewTextBoxColumn.HeaderText = "odevnot";
            this.odevnotDataGridViewTextBoxColumn.Name = "odevnotDataGridViewTextBoxColumn";
            this.odevnotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devamsizlikDataGridViewTextBoxColumn
            // 
            this.devamsizlikDataGridViewTextBoxColumn.DataPropertyName = "devamsizlik";
            this.devamsizlikDataGridViewTextBoxColumn.HeaderText = "devamsizlik";
            this.devamsizlikDataGridViewTextBoxColumn.Name = "devamsizlikDataGridViewTextBoxColumn";
            this.devamsizlikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            this.ortalamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRENCIDERSBindingSource
            // 
            this.oGRENCIDERSBindingSource.DataMember = "OGRENCIDERS";
            this.oGRENCIDERSBindingSource.DataSource = this.oGRBILGISISTEMIDataSet11;
            // 
            // oGRBILGISISTEMIDataSet11
            // 
            this.oGRBILGISISTEMIDataSet11.DataSetName = "OGRBILGISISTEMIDataSet11";
            this.oGRBILGISISTEMIDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oGRENCIDERSTableAdapter
            // 
            this.oGRENCIDERSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ders Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vize Notu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Final Notu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ödev Notu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Devamsızlık:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ortalama:";
            // 
            // txtogrno
            // 
            this.txtogrno.Location = new System.Drawing.Point(106, 49);
            this.txtogrno.Name = "txtogrno";
            this.txtogrno.Size = new System.Drawing.Size(100, 20);
            this.txtogrno.TabIndex = 19;
            // 
            // txtderskodu
            // 
            this.txtderskodu.Location = new System.Drawing.Point(106, 75);
            this.txtderskodu.Name = "txtderskodu";
            this.txtderskodu.Size = new System.Drawing.Size(100, 20);
            this.txtderskodu.TabIndex = 20;
            // 
            // txtvizenotu
            // 
            this.txtvizenotu.Location = new System.Drawing.Point(106, 104);
            this.txtvizenotu.Name = "txtvizenotu";
            this.txtvizenotu.Size = new System.Drawing.Size(100, 20);
            this.txtvizenotu.TabIndex = 21;
            // 
            // txtfinalnotu
            // 
            this.txtfinalnotu.Location = new System.Drawing.Point(106, 131);
            this.txtfinalnotu.Name = "txtfinalnotu";
            this.txtfinalnotu.Size = new System.Drawing.Size(100, 20);
            this.txtfinalnotu.TabIndex = 22;
            // 
            // txtodevnotu
            // 
            this.txtodevnotu.Location = new System.Drawing.Point(316, 61);
            this.txtodevnotu.Name = "txtodevnotu";
            this.txtodevnotu.Size = new System.Drawing.Size(100, 20);
            this.txtodevnotu.TabIndex = 23;
            // 
            // txtdevamsizlik
            // 
            this.txtdevamsizlik.Location = new System.Drawing.Point(316, 89);
            this.txtdevamsizlik.Name = "txtdevamsizlik";
            this.txtdevamsizlik.Size = new System.Drawing.Size(100, 20);
            this.txtdevamsizlik.TabIndex = 24;
            // 
            // txtort
            // 
            this.txtort.Location = new System.Drawing.Point(316, 117);
            this.txtort.Name = "txtort";
            this.txtort.Size = new System.Drawing.Size(100, 20);
            this.txtort.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtderskodu);
            this.groupBox1.Controls.Add(this.txtort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdevamsizlik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtodevnotu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfinalnotu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtvizenotu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtogrno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 202);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Kaydı Düzenleme";
            // 
            // DersKaydiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DersKaydiDuzenle";
            this.Text = "DersKaydiDuzenle";
            this.Load += new System.EventHandler(this.DersKaydiDuzenle_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRENCIDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRBILGISISTEMIDataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OGRBILGISISTEMIDataSet11 oGRBILGISISTEMIDataSet11;
        private System.Windows.Forms.BindingSource oGRENCIDERSBindingSource;
        private OGRBILGISISTEMIDataSet11TableAdapters.OGRENCIDERSTableAdapter oGRENCIDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencıdersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn derskoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizenotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalnotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odevnotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devamsizlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtogrno;
        private System.Windows.Forms.TextBox txtderskodu;
        private System.Windows.Forms.TextBox txtvizenotu;
        private System.Windows.Forms.TextBox txtfinalnotu;
        private System.Windows.Forms.TextBox txtodevnotu;
        private System.Windows.Forms.TextBox txtdevamsizlik;
        private System.Windows.Forms.TextBox txtort;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}