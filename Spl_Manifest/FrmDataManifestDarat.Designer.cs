namespace Spl_Manifest
{
    partial class FrmDataManifestDarat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataManifestDarat));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgvManifestDarat = new System.Windows.Forms.DataGridView();
            this.IdManifest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoAWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPengirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlamatPengirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTelpon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPenerima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlamatPenerima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTelpon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsiBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KotaTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsalSmu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSmu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoliSmu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KiloSmu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManifestDarat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(354, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 61);
            this.button1.TabIndex = 47;
            this.button1.Text = "Load Data";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cari No. AWB";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 119);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilter.Location = new System.Drawing.Point(425, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(64, 61);
            this.btnFilter.TabIndex = 55;
            this.btnFilter.Text = "Filter Data";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(555, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 97);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Sampai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Dari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "s/d";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(282, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Data Incoming Darat";
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(126, 73);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(197, 26);
            this.txtCari.TabIndex = 43;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // dgvManifestDarat
            // 
            this.dgvManifestDarat.AllowUserToAddRows = false;
            this.dgvManifestDarat.AllowUserToDeleteRows = false;
            this.dgvManifestDarat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManifestDarat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdManifest,
            this.NoAWB,
            this.NamaPengirim,
            this.AlamatPengirim,
            this.NoTelpon1,
            this.NamaPenerima,
            this.AlamatPenerima,
            this.NoTelpon2,
            this.TanggalKirim,
            this.Koli,
            this.Kilo,
            this.IsiBarang,
            this.KotaTujuan,
            this.AsalSmu,
            this.NoSmu,
            this.Area,
            this.Vendor,
            this.KoliSmu,
            this.KiloSmu,
            this.NamaDriver,
            this.CreatedBy});
            this.dgvManifestDarat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManifestDarat.Location = new System.Drawing.Point(0, 123);
            this.dgvManifestDarat.Name = "dgvManifestDarat";
            this.dgvManifestDarat.ReadOnly = true;
            this.dgvManifestDarat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManifestDarat.Size = new System.Drawing.Size(1284, 790);
            this.dgvManifestDarat.TabIndex = 28;
            this.dgvManifestDarat.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvManifestDarat_RowPostPaint);
            // 
            // IdManifest
            // 
            this.IdManifest.DataPropertyName = "ManfUdaraId";
            this.IdManifest.HeaderText = "IdManifest";
            this.IdManifest.Name = "IdManifest";
            this.IdManifest.ReadOnly = true;
            this.IdManifest.Visible = false;
            // 
            // NoAWB
            // 
            this.NoAWB.DataPropertyName = "NoAwb";
            this.NoAWB.HeaderText = "AWB";
            this.NoAWB.Name = "NoAWB";
            this.NoAWB.ReadOnly = true;
            this.NoAWB.Width = 130;
            // 
            // NamaPengirim
            // 
            this.NamaPengirim.DataPropertyName = "NamaPengirim";
            this.NamaPengirim.HeaderText = "Nama Pengirim";
            this.NamaPengirim.Name = "NamaPengirim";
            this.NamaPengirim.ReadOnly = true;
            this.NamaPengirim.Width = 200;
            // 
            // AlamatPengirim
            // 
            this.AlamatPengirim.DataPropertyName = "AlamatPengirim";
            this.AlamatPengirim.HeaderText = "Alamat Pengirim";
            this.AlamatPengirim.Name = "AlamatPengirim";
            this.AlamatPengirim.ReadOnly = true;
            this.AlamatPengirim.Width = 250;
            // 
            // NoTelpon1
            // 
            this.NoTelpon1.DataPropertyName = "NoTelpon1";
            this.NoTelpon1.HeaderText = "No Telepon";
            this.NoTelpon1.Name = "NoTelpon1";
            this.NoTelpon1.ReadOnly = true;
            this.NoTelpon1.Width = 150;
            // 
            // NamaPenerima
            // 
            this.NamaPenerima.DataPropertyName = "NamaPenerima";
            this.NamaPenerima.HeaderText = "Nama Penerima";
            this.NamaPenerima.Name = "NamaPenerima";
            this.NamaPenerima.ReadOnly = true;
            this.NamaPenerima.Width = 200;
            // 
            // AlamatPenerima
            // 
            this.AlamatPenerima.DataPropertyName = "AlamatPenerima";
            this.AlamatPenerima.HeaderText = "Alamat Penerima";
            this.AlamatPenerima.Name = "AlamatPenerima";
            this.AlamatPenerima.ReadOnly = true;
            this.AlamatPenerima.Width = 250;
            // 
            // NoTelpon2
            // 
            this.NoTelpon2.DataPropertyName = "NoTelpon2";
            this.NoTelpon2.HeaderText = "NoTelepon";
            this.NoTelpon2.Name = "NoTelpon2";
            this.NoTelpon2.ReadOnly = true;
            this.NoTelpon2.Width = 150;
            // 
            // TanggalKirim
            // 
            this.TanggalKirim.DataPropertyName = "TanggalKirim";
            this.TanggalKirim.HeaderText = "Tanggal";
            this.TanggalKirim.Name = "TanggalKirim";
            this.TanggalKirim.ReadOnly = true;
            // 
            // Koli
            // 
            this.Koli.DataPropertyName = "Koli";
            this.Koli.HeaderText = "Koli";
            this.Koli.Name = "Koli";
            this.Koli.ReadOnly = true;
            this.Koli.Width = 70;
            // 
            // Kilo
            // 
            this.Kilo.DataPropertyName = "Kilo";
            this.Kilo.HeaderText = "Kilo";
            this.Kilo.Name = "Kilo";
            this.Kilo.ReadOnly = true;
            this.Kilo.Width = 70;
            // 
            // IsiBarang
            // 
            this.IsiBarang.DataPropertyName = "IsiBarang";
            this.IsiBarang.HeaderText = "Isi Barang";
            this.IsiBarang.Name = "IsiBarang";
            this.IsiBarang.ReadOnly = true;
            this.IsiBarang.Width = 200;
            // 
            // KotaTujuan
            // 
            this.KotaTujuan.DataPropertyName = "KotaTujuan";
            this.KotaTujuan.HeaderText = "Tujuan";
            this.KotaTujuan.Name = "KotaTujuan";
            this.KotaTujuan.ReadOnly = true;
            // 
            // AsalSmu
            // 
            this.AsalSmu.DataPropertyName = "AsalSmu";
            this.AsalSmu.HeaderText = "SMU Asal";
            this.AsalSmu.Name = "AsalSmu";
            this.AsalSmu.ReadOnly = true;
            // 
            // NoSmu
            // 
            this.NoSmu.DataPropertyName = "NoSmu";
            this.NoSmu.HeaderText = "No. STT Vendor";
            this.NoSmu.Name = "NoSmu";
            this.NoSmu.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Vendor
            // 
            this.Vendor.DataPropertyName = "Vendor";
            this.Vendor.HeaderText = "Vendor";
            this.Vendor.Name = "Vendor";
            this.Vendor.ReadOnly = true;
            // 
            // KoliSmu
            // 
            this.KoliSmu.DataPropertyName = "KoliSmu";
            this.KoliSmu.HeaderText = "Koli SMU";
            this.KoliSmu.Name = "KoliSmu";
            this.KoliSmu.ReadOnly = true;
            // 
            // KiloSmu
            // 
            this.KiloSmu.DataPropertyName = "KiloSmu";
            this.KiloSmu.HeaderText = "Kilo SMU";
            this.KiloSmu.Name = "KiloSmu";
            this.KiloSmu.ReadOnly = true;
            // 
            // NamaDriver
            // 
            this.NamaDriver.DataPropertyName = "NamaDriver";
            this.NamaDriver.HeaderText = "Driver";
            this.NamaDriver.Name = "NamaDriver";
            this.NamaDriver.ReadOnly = true;
            this.NamaDriver.Width = 150;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 123);
            this.panel1.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 913);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1284, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmDataManifestDarat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 938);
            this.ControlBox = false;
            this.Controls.Add(this.dgvManifestDarat);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDataManifestDarat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDataManifestDarat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManifestDarat)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvManifestDarat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdManifest;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoAWB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPengirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlamatPengirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTelpon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPenerima;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlamatPenerima;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTelpon2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalKirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsiBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn KotaTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsalSmu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSmu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoliSmu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiloSmu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}