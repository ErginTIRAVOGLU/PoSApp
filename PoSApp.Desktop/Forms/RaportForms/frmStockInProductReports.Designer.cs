﻿namespace PoSApp.Desktop.Forms.RaportForms
{
    partial class frmStockInProductReports
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInProductReports));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            pBClose = new PictureBox();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            lblYearSelect = new Label();
            label3 = new Label();
            cmBoxYears = new ComboBox();
            cmBoxReportType = new ComboBox();
            btnFilter = new Button();
            dTPEndDate = new DateTimePicker();
            dTPBeginDate = new DateTimePicker();
            lblPickDate = new Label();
            txtProductSearch = new TextBox();
            pictureBox1 = new PictureBox();
            splitContainer3 = new SplitContainer();
            dGWProductWithGroupbyMonth = new DataGridView();
            Month = new DataGridViewTextBoxColumn();
            MonthName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            TotalStockedProducts = new DataGridViewTextBoxColumn();
            TotalPriceWithVat = new DataGridViewTextBoxColumn();
            dGWProductWithGroup = new DataGridView();
            WGId = new DataGridViewTextBoxColumn();
            WGProductCode = new DataGridViewTextBoxColumn();
            WGProductName = new DataGridViewTextBoxColumn();
            WGProductBarcode = new DataGridViewTextBoxColumn();
            WGalimsayisi = new DataGridViewTextBoxColumn();
            WGStockInDetailUnit = new DataGridViewTextBoxColumn();
            WGStockInDetailUnitType = new DataGridViewTextBoxColumn();
            WGLastPriceWithVat = new DataGridViewTextBoxColumn();
            dGWProduct = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StockInId = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductBarcode = new DataGridViewTextBoxColumn();
            onePrice = new DataGridViewTextBoxColumn();
            StockInDetailUnit = new DataGridViewTextBoxColumn();
            LastPriceWithVat = new DataGridViewTextBoxColumn();
            StockInDetailUnitType = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            StockInDate = new DataGridViewTextBoxColumn();
            cProductMenuStrip = new ContextMenuStrip(components);
            tSMIProductStockInDetail = new ToolStripMenuItem();
            tSMIProductDetail = new ToolStripMenuItem();
            lblTotal = new Label();
            lblTotalAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGWProductWithGroupbyMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWProductWithGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWProduct).BeginInit();
            cProductMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 2;
            label1.Text = "Ürün Stok Girişi Raporu";
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(1109, 8);
            pBClose.Name = "pBClose";
            pBClose.Size = new Size(24, 24);
            pBClose.TabIndex = 0;
            pBClose.TabStop = false;
            pBClose.Click += pBClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pBClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 40);
            panel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 40);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(1145, 530);
            splitContainer1.SplitterDistance = 79;
            splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lblYearSelect);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(cmBoxYears);
            splitContainer2.Panel1.Controls.Add(cmBoxReportType);
            splitContainer2.Panel1.Controls.Add(btnFilter);
            splitContainer2.Panel1.Controls.Add(dTPEndDate);
            splitContainer2.Panel1.Controls.Add(dTPBeginDate);
            splitContainer2.Panel1.Controls.Add(lblPickDate);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtProductSearch);
            splitContainer2.Panel2.Controls.Add(pictureBox1);
            splitContainer2.Size = new Size(1145, 79);
            splitContainer2.SplitterDistance = 40;
            splitContainer2.TabIndex = 0;
            // 
            // lblYearSelect
            // 
            lblYearSelect.AutoSize = true;
            lblYearSelect.Location = new Point(711, 10);
            lblYearSelect.Name = "lblYearSelect";
            lblYearSelect.Size = new Size(78, 15);
            lblYearSelect.TabIndex = 12;
            lblYearSelect.Text = "Tarih Aralığı : ";
            lblYearSelect.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 10);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 11;
            label3.Text = "Rapor Türü : ";
            // 
            // cmBoxYears
            // 
            cmBoxYears.FormattingEnabled = true;
            cmBoxYears.Items.AddRange(new object[] { "Ürünleri Listele", "Ürünleri Grupla", "Aylara Göre Göster" });
            cmBoxYears.Location = new Point(818, 6);
            cmBoxYears.Name = "cmBoxYears";
            cmBoxYears.Size = new Size(87, 23);
            cmBoxYears.TabIndex = 10;
            cmBoxYears.Visible = false;
            // 
            // cmBoxReportType
            // 
            cmBoxReportType.FormattingEnabled = true;
            cmBoxReportType.Items.AddRange(new object[] { "Ürünleri Listele", "Ürünleri Grupla", "Aylara Göre Göster" });
            cmBoxReportType.Location = new Point(568, 6);
            cmBoxReportType.Name = "cmBoxReportType";
            cmBoxReportType.Size = new Size(137, 23);
            cmBoxReportType.TabIndex = 9;
            cmBoxReportType.SelectedIndexChanged += cmBoxReportType_SelectedIndexChanged;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilter.Location = new Point(1067, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 28);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Yükle";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // dTPEndDate
            // 
            dTPEndDate.Location = new Point(278, 6);
            dTPEndDate.Name = "dTPEndDate";
            dTPEndDate.Size = new Size(181, 23);
            dTPEndDate.TabIndex = 6;
            // 
            // dTPBeginDate
            // 
            dTPBeginDate.Location = new Point(90, 6);
            dTPBeginDate.Name = "dTPBeginDate";
            dTPBeginDate.Size = new Size(182, 23);
            dTPBeginDate.TabIndex = 5;
            // 
            // lblPickDate
            // 
            lblPickDate.AutoSize = true;
            lblPickDate.Location = new Point(6, 10);
            lblPickDate.Name = "lblPickDate";
            lblPickDate.Size = new Size(78, 15);
            lblPickDate.TabIndex = 4;
            lblPickDate.Text = "Tarih Aralığı : ";
            // 
            // txtProductSearch
            // 
            txtProductSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProductSearch.Location = new Point(36, 4);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.PlaceholderText = "Ürün Ara";
            txtProductSearch.Size = new Size(965, 23);
            txtProductSearch.TabIndex = 5;
            txtProductSearch.KeyDown += txtProductSearch_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 28);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(dGWProductWithGroupbyMonth);
            splitContainer3.Panel1.Controls.Add(dGWProductWithGroup);
            splitContainer3.Panel1.Controls.Add(dGWProduct);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(lblTotal);
            splitContainer3.Panel2.Controls.Add(lblTotalAmount);
            splitContainer3.Size = new Size(1145, 447);
            splitContainer3.SplitterDistance = 399;
            splitContainer3.TabIndex = 7;
            // 
            // dGWProductWithGroupbyMonth
            // 
            dGWProductWithGroupbyMonth.AllowUserToAddRows = false;
            dGWProductWithGroupbyMonth.AllowUserToDeleteRows = false;
            dGWProductWithGroupbyMonth.AllowUserToOrderColumns = true;
            dGWProductWithGroupbyMonth.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.LightSkyBlue;
            dGWProductWithGroupbyMonth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dGWProductWithGroupbyMonth.BackgroundColor = Color.White;
            dGWProductWithGroupbyMonth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dGWProductWithGroupbyMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dGWProductWithGroupbyMonth.ColumnHeadersHeight = 30;
            dGWProductWithGroupbyMonth.Columns.AddRange(new DataGridViewColumn[] { Month, MonthName, Year, TotalStockedProducts, TotalPriceWithVat });
            dGWProductWithGroupbyMonth.EditMode = DataGridViewEditMode.EditOnF2;
            dGWProductWithGroupbyMonth.EnableHeadersVisualStyles = false;
            dGWProductWithGroupbyMonth.Location = new Point(3, 250);
            dGWProductWithGroupbyMonth.MultiSelect = false;
            dGWProductWithGroupbyMonth.Name = "dGWProductWithGroupbyMonth";
            dGWProductWithGroupbyMonth.RowHeadersVisible = false;
            dGWProductWithGroupbyMonth.RowTemplate.Height = 25;
            dGWProductWithGroupbyMonth.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWProductWithGroupbyMonth.Size = new Size(1139, 124);
            dGWProductWithGroupbyMonth.TabIndex = 8;
            dGWProductWithGroupbyMonth.Visible = false;
            // 
            // Month
            // 
            Month.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Month.DataPropertyName = "Month";
            Month.HeaderText = "AY";
            Month.Name = "Month";
            Month.Width = 44;
            // 
            // MonthName
            // 
            MonthName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MonthName.DataPropertyName = "MonthName";
            MonthName.HeaderText = "ADI";
            MonthName.Name = "MonthName";
            MonthName.Width = 49;
            // 
            // Year
            // 
            Year.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Year.DataPropertyName = "Year";
            Year.HeaderText = "YIL";
            Year.Name = "Year";
            Year.Width = 46;
            // 
            // TotalStockedProducts
            // 
            TotalStockedProducts.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalStockedProducts.DataPropertyName = "TotalStockedProducts";
            TotalStockedProducts.HeaderText = "TOPLAM ÜRÜN";
            TotalStockedProducts.Name = "TotalStockedProducts";
            TotalStockedProducts.Width = 111;
            // 
            // TotalPriceWithVat
            // 
            TotalPriceWithVat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalPriceWithVat.DataPropertyName = "TotalPriceWithVat";
            TotalPriceWithVat.HeaderText = "TOPLAM TUTAR";
            TotalPriceWithVat.Name = "TotalPriceWithVat";
            TotalPriceWithVat.Width = 113;
            // 
            // dGWProductWithGroup
            // 
            dGWProductWithGroup.AllowUserToAddRows = false;
            dGWProductWithGroup.AllowUserToDeleteRows = false;
            dGWProductWithGroup.AllowUserToOrderColumns = true;
            dGWProductWithGroup.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.LightSkyBlue;
            dGWProductWithGroup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dGWProductWithGroup.BackgroundColor = Color.White;
            dGWProductWithGroup.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dGWProductWithGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dGWProductWithGroup.ColumnHeadersHeight = 30;
            dGWProductWithGroup.Columns.AddRange(new DataGridViewColumn[] { WGId, WGProductCode, WGProductName, WGProductBarcode, WGalimsayisi, WGStockInDetailUnit, WGStockInDetailUnitType, WGLastPriceWithVat });
            dGWProductWithGroup.EditMode = DataGridViewEditMode.EditOnF2;
            dGWProductWithGroup.EnableHeadersVisualStyles = false;
            dGWProductWithGroup.Location = new Point(3, 120);
            dGWProductWithGroup.MultiSelect = false;
            dGWProductWithGroup.Name = "dGWProductWithGroup";
            dGWProductWithGroup.RowHeadersVisible = false;
            dGWProductWithGroup.RowTemplate.Height = 25;
            dGWProductWithGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWProductWithGroup.Size = new Size(1139, 124);
            dGWProductWithGroup.TabIndex = 7;
            dGWProductWithGroup.Visible = false;
            // 
            // WGId
            // 
            WGId.DataPropertyName = "Id";
            WGId.HeaderText = "Id";
            WGId.Name = "WGId";
            WGId.Visible = false;
            // 
            // WGProductCode
            // 
            WGProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WGProductCode.DataPropertyName = "ProductCode";
            WGProductCode.HeaderText = "ÜRÜN KODU";
            WGProductCode.Name = "WGProductCode";
            WGProductCode.Width = 96;
            // 
            // WGProductName
            // 
            WGProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WGProductName.DataPropertyName = "ProductName";
            WGProductName.HeaderText = "ÜRÜN";
            WGProductName.Name = "WGProductName";
            // 
            // WGProductBarcode
            // 
            WGProductBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WGProductBarcode.DataPropertyName = "ProductBarcode";
            WGProductBarcode.HeaderText = "BARKOD";
            WGProductBarcode.Name = "WGProductBarcode";
            WGProductBarcode.Width = 75;
            // 
            // WGalimsayisi
            // 
            WGalimsayisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WGalimsayisi.DataPropertyName = "alimsayisi";
            WGalimsayisi.HeaderText = "TEKRAR";
            WGalimsayisi.Name = "WGalimsayisi";
            WGalimsayisi.Width = 71;
            // 
            // WGStockInDetailUnit
            // 
            WGStockInDetailUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WGStockInDetailUnit.DataPropertyName = "StockInDetailUnit";
            WGStockInDetailUnit.HeaderText = "ADET/GRAM";
            WGStockInDetailUnit.Name = "WGStockInDetailUnit";
            WGStockInDetailUnit.Width = 97;
            // 
            // WGStockInDetailUnitType
            // 
            WGStockInDetailUnitType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WGStockInDetailUnitType.DataPropertyName = "StockInDetailUnitType";
            WGStockInDetailUnitType.HeaderText = "ÜRÜN TİPİ";
            WGStockInDetailUnitType.Name = "WGStockInDetailUnitType";
            WGStockInDetailUnitType.Width = 84;
            // 
            // WGLastPriceWithVat
            // 
            WGLastPriceWithVat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WGLastPriceWithVat.DataPropertyName = "LastPriceWithVat";
            WGLastPriceWithVat.HeaderText = "KDV Dahil Toplam Tutar";
            WGLastPriceWithVat.Name = "WGLastPriceWithVat";
            WGLastPriceWithVat.Width = 154;
            // 
            // dGWProduct
            // 
            dGWProduct.AllowUserToAddRows = false;
            dGWProduct.AllowUserToDeleteRows = false;
            dGWProduct.AllowUserToOrderColumns = true;
            dGWProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.LightSkyBlue;
            dGWProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dGWProduct.BackgroundColor = Color.White;
            dGWProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dGWProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dGWProduct.ColumnHeadersHeight = 30;
            dGWProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWProduct.Columns.AddRange(new DataGridViewColumn[] { Id, StockInId, ProductId, ProductCode, ProductName, ProductBarcode, onePrice, StockInDetailUnit, LastPriceWithVat, StockInDetailUnitType, ProductPrice, StockInDate });
            dGWProduct.ContextMenuStrip = cProductMenuStrip;
            dGWProduct.EditMode = DataGridViewEditMode.EditOnF2;
            dGWProduct.EnableHeadersVisualStyles = false;
            dGWProduct.Location = new Point(3, 2);
            dGWProduct.MultiSelect = false;
            dGWProduct.Name = "dGWProduct";
            dGWProduct.RowHeadersVisible = false;
            dGWProduct.RowTemplate.Height = 25;
            dGWProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWProduct.Size = new Size(1139, 112);
            dGWProduct.TabIndex = 6;
            dGWProduct.Visible = false;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // StockInId
            // 
            StockInId.DataPropertyName = "StockInId";
            StockInId.HeaderText = "STOCKINID";
            StockInId.Name = "StockInId";
            StockInId.Visible = false;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            ProductId.Visible = false;
            // 
            // ProductCode
            // 
            ProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "ÜRÜN KODU";
            ProductCode.Name = "ProductCode";
            ProductCode.Width = 96;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ÜRÜN";
            ProductName.Name = "ProductName";
            // 
            // ProductBarcode
            // 
            ProductBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductBarcode.DataPropertyName = "ProductBarcode";
            ProductBarcode.HeaderText = "BARKOD";
            ProductBarcode.Name = "ProductBarcode";
            ProductBarcode.Width = 75;
            // 
            // onePrice
            // 
            onePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            onePrice.DataPropertyName = "onePrice";
            onePrice.HeaderText = "ALIŞ FİYATI";
            onePrice.Name = "onePrice";
            onePrice.Width = 87;
            // 
            // StockInDetailUnit
            // 
            StockInDetailUnit.DataPropertyName = "StockInDetailUnit";
            StockInDetailUnit.HeaderText = "ADET/GRAM";
            StockInDetailUnit.Name = "StockInDetailUnit";
            // 
            // LastPriceWithVat
            // 
            LastPriceWithVat.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            LastPriceWithVat.DataPropertyName = "LastPriceWithVat";
            LastPriceWithVat.HeaderText = "KDV Dahil Toplam Tutar";
            LastPriceWithVat.Name = "LastPriceWithVat";
            LastPriceWithVat.Width = 154;
            // 
            // StockInDetailUnitType
            // 
            StockInDetailUnitType.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StockInDetailUnitType.DataPropertyName = "StockInDetailUnitType";
            StockInDetailUnitType.HeaderText = "ÜRÜN TİPİ";
            StockInDetailUnitType.Name = "StockInDetailUnitType";
            StockInDetailUnitType.Width = 84;
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProductPrice.DataPropertyName = "ProductPrice";
            ProductPrice.HeaderText = "SATIŞ FİYATI";
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Width = 92;
            // 
            // StockInDate
            // 
            StockInDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StockInDate.DataPropertyName = "StockInDate";
            StockInDate.HeaderText = "STOK GİRİŞ TARİHİ";
            StockInDate.Name = "StockInDate";
            StockInDate.Width = 125;
            // 
            // cProductMenuStrip
            // 
            cProductMenuStrip.Items.AddRange(new ToolStripItem[] { tSMIProductStockInDetail, tSMIProductDetail });
            cProductMenuStrip.Name = "cProductMenuStrip";
            cProductMenuStrip.Size = new Size(169, 48);
            // 
            // tSMIProductStockInDetail
            // 
            tSMIProductStockInDetail.Name = "tSMIProductStockInDetail";
            tSMIProductStockInDetail.Size = new Size(168, 22);
            tSMIProductStockInDetail.Text = "Ürün Girişini Gör";
            tSMIProductStockInDetail.Click += tSMIProductStockInDetail_Click;
            // 
            // tSMIProductDetail
            // 
            tSMIProductDetail.Name = "tSMIProductDetail";
            tSMIProductDetail.Size = new Size(168, 22);
            tSMIProductDetail.Text = "Ürün Detayını Gör";
            tSMIProductDetail.Click += tSMIProductDetail_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(809, 14);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Toplam : ";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(870, 14);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(13, 15);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "0";
            // 
            // frmStockInProductReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 570);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStockInProductReports";
            Text = "frmStockInProductReports";
            Load += frmStockInProductReports_Load;
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGWProductWithGroupbyMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWProductWithGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWProduct).EndInit();
            cProductMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pBClose;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        public TextBox txtProductSearch;
        private PictureBox pictureBox1;
        private Button btnFilter;
        private DateTimePicker dTPEndDate;
        private DateTimePicker dTPBeginDate;
        private Label lblPickDate;
        public DataGridView dGWProduct;
        private ContextMenuStrip cProductMenuStrip;
        private ToolStripMenuItem tSMIProductStockInDetail;
        private Label lblTotalAmount;
        private Label lblTotal;
        private ToolStripMenuItem tSMIProductDetail;
        private SplitContainer splitContainer3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StockInId;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductBarcode;
        private DataGridViewTextBoxColumn onePrice;
        private DataGridViewTextBoxColumn StockInDetailUnit;
        private DataGridViewTextBoxColumn LastPriceWithVat;
        private DataGridViewTextBoxColumn StockInDetailUnitType;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn StockInDate;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn WGId;
        private DataGridViewTextBoxColumn WGProductCode;
        private DataGridViewTextBoxColumn WGProductName;
        private DataGridViewTextBoxColumn WGProductBarcode;
        private DataGridViewTextBoxColumn WGalimsayisi;
        private DataGridViewTextBoxColumn WGStockInDetailUnit;
        private DataGridViewTextBoxColumn WGStockInDetailUnitType;
        private DataGridViewTextBoxColumn WGLastPriceWithVat;
        public DataGridView dGWProductWithGroup;
        public DataGridView dGWProductWithGroupbyMonth;
        private ComboBox cmBoxReportType;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn MonthName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn TotalStockedProducts;
        private DataGridViewTextBoxColumn TotalPriceWithVat;
        private Label lblYearSelect;
        private Label label3;
        private ComboBox cmBoxYears;
    }
}