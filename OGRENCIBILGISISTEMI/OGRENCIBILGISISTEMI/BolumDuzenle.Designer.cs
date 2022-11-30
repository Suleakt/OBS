namespace OGRENCIBILGISISTEMI
{
    partial class BolumDuzenle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOLUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGRBILGISISTEMIDataSet10 = new OGRENCIBILGISISTEMI.OGRBILGISISTEMIDataSet10();
            this.bOLUMTableAdapter = new OGRENCIBILGISISTEMI.OGRBILGISISTEMIDataSet10TableAdapters.BOLUMTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbolumkod = new System.Windows.Forms.TextBox();
            this.txtbolumad = new System.Windows.Forms.TextBox();
            this.btnimport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLUMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRBILGISISTEMIDataSet10)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumkoduDataGridViewTextBoxColumn,
            this.bolumadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOLUMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(295, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(344, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumkoduDataGridViewTextBoxColumn
            // 
            this.bolumkoduDataGridViewTextBoxColumn.DataPropertyName = "bolumkodu";
            this.bolumkoduDataGridViewTextBoxColumn.HeaderText = "bolumkodu";
            this.bolumkoduDataGridViewTextBoxColumn.Name = "bolumkoduDataGridViewTextBoxColumn";
            this.bolumkoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumadDataGridViewTextBoxColumn
            // 
            this.bolumadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumadDataGridViewTextBoxColumn.DataPropertyName = "bolumad";
            this.bolumadDataGridViewTextBoxColumn.HeaderText = "bolumad";
            this.bolumadDataGridViewTextBoxColumn.Name = "bolumadDataGridViewTextBoxColumn";
            this.bolumadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOLUMBindingSource
            // 
            this.bOLUMBindingSource.DataMember = "BOLUM";
            this.bOLUMBindingSource.DataSource = this.oGRBILGISISTEMIDataSet10;
            // 
            // oGRBILGISISTEMIDataSet10
            // 
            this.oGRBILGISISTEMIDataSet10.DataSetName = "OGRBILGISISTEMIDataSet10";
            this.oGRBILGISISTEMIDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOLUMTableAdapter
            // 
            this.bOLUMTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnimport);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Location = new System.Drawing.Point(73, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 249);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Menüsü";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Snow;
            this.btnsil.Location = new System.Drawing.Point(49, 140);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(94, 42);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Snow;
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
            this.btnkaydet.BackColor = System.Drawing.Color.Snow;
            this.btnkaydet.Location = new System.Drawing.Point(49, 23);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 42);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bölüm Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bölüm Ad:";
            // 
            // txtbolumkod
            // 
            this.txtbolumkod.Location = new System.Drawing.Point(133, 12);
            this.txtbolumkod.Name = "txtbolumkod";
            this.txtbolumkod.Size = new System.Drawing.Size(136, 20);
            this.txtbolumkod.TabIndex = 12;
            // 
            // txtbolumad
            // 
            this.txtbolumad.Location = new System.Drawing.Point(133, 47);
            this.txtbolumad.Name = "txtbolumad";
            this.txtbolumad.Size = new System.Drawing.Size(136, 20);
            this.txtbolumad.TabIndex = 13;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(49, 199);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(94, 44);
            this.btnimport.TabIndex = 3;
            this.btnimport.Text = "İMPORT";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // BolumDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(671, 347);
            this.Controls.Add(this.txtbolumad);
            this.Controls.Add(this.txtbolumkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BolumDuzenle";
            this.Text = "Bölüm Düzenle";
            this.Load += new System.EventHandler(this.BolumDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOLUMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRBILGISISTEMIDataSet10)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OGRBILGISISTEMIDataSet10 oGRBILGISISTEMIDataSet10;
        private System.Windows.Forms.BindingSource bOLUMBindingSource;
        private OGRBILGISISTEMIDataSet10TableAdapters.BOLUMTableAdapter bOLUMTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbolumkod;
        private System.Windows.Forms.TextBox txtbolumad;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnimport;
    }
}