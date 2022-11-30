namespace OGRENCIBILGISISTEMI
{
    partial class Yetkilendirme
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
            this.formadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erisimDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.yETKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGRBILGISISTEMIDataSet12 = new OGRENCIBILGISISTEMI.OGRBILGISISTEMIDataSet12();
            this.txterisim = new System.Windows.Forms.TextBox();
            this.txtyetki = new System.Windows.Forms.TextBox();
            this.txtformadi = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.yETKITableAdapter = new OGRENCIBILGISISTEMI.OGRBILGISISTEMIDataSet12TableAdapters.YETKITableAdapter();
            this.btnsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yETKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRBILGISISTEMIDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formadiDataGridViewTextBoxColumn,
            this.yetkiDataGridViewTextBoxColumn,
            this.erisimDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.yETKIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(154, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(340, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // formadiDataGridViewTextBoxColumn
            // 
            this.formadiDataGridViewTextBoxColumn.DataPropertyName = "formadi";
            this.formadiDataGridViewTextBoxColumn.HeaderText = "formadi";
            this.formadiDataGridViewTextBoxColumn.Name = "formadiDataGridViewTextBoxColumn";
            // 
            // yetkiDataGridViewTextBoxColumn
            // 
            this.yetkiDataGridViewTextBoxColumn.DataPropertyName = "yetki";
            this.yetkiDataGridViewTextBoxColumn.HeaderText = "yetki";
            this.yetkiDataGridViewTextBoxColumn.Name = "yetkiDataGridViewTextBoxColumn";
            // 
            // erisimDataGridViewCheckBoxColumn
            // 
            this.erisimDataGridViewCheckBoxColumn.DataPropertyName = "erisim";
            this.erisimDataGridViewCheckBoxColumn.HeaderText = "erisim";
            this.erisimDataGridViewCheckBoxColumn.Name = "erisimDataGridViewCheckBoxColumn";
            // 
            // yETKIBindingSource
            // 
            this.yETKIBindingSource.DataMember = "YETKI";
            this.yETKIBindingSource.DataSource = this.oGRBILGISISTEMIDataSet12;
            // 
            // oGRBILGISISTEMIDataSet12
            // 
            this.oGRBILGISISTEMIDataSet12.DataSetName = "OGRBILGISISTEMIDataSet12";
            this.oGRBILGISISTEMIDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txterisim
            // 
            this.txterisim.Location = new System.Drawing.Point(24, 133);
            this.txterisim.Name = "txterisim";
            this.txterisim.Size = new System.Drawing.Size(100, 20);
            this.txterisim.TabIndex = 9;
            // 
            // txtyetki
            // 
            this.txtyetki.Location = new System.Drawing.Point(24, 106);
            this.txtyetki.Name = "txtyetki";
            this.txtyetki.Size = new System.Drawing.Size(100, 20);
            this.txtyetki.TabIndex = 8;
            // 
            // txtformadi
            // 
            this.txtformadi.Location = new System.Drawing.Point(24, 79);
            this.txtformadi.Name = "txtformadi";
            this.txtformadi.Size = new System.Drawing.Size(100, 20);
            this.txtformadi.TabIndex = 7;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(24, 197);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(100, 41);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "Değişiklikleri Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // yETKITableAdapter
            // 
            this.yETKITableAdapter.ClearBeforeFill = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(24, 261);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(39, 23);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lütfen önce satır seçiniz.";
            // 
            // Yetkilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(518, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txterisim);
            this.Controls.Add(this.txtyetki);
            this.Controls.Add(this.txtformadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Yetkilendirme";
            this.Text = "Yetkilendirme";
            this.Load += new System.EventHandler(this.Yetkilendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yETKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRBILGISISTEMIDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txterisim;
        private System.Windows.Forms.TextBox txtyetki;
        private System.Windows.Forms.TextBox txtformadi;
        private System.Windows.Forms.Button btnkaydet;
        private OGRBILGISISTEMIDataSet12 oGRBILGISISTEMIDataSet12;
        private System.Windows.Forms.BindingSource yETKIBindingSource;
        private OGRBILGISISTEMIDataSet12TableAdapters.YETKITableAdapter yETKITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn formadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn erisimDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label1;
    }
}