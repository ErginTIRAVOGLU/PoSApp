namespace PoSApp.Desktop.Forms.RaportForms
{
    partial class frmCartProductReports
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartProductReports));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            lblTotal = new Label();
            WGProductBarcode = new DataGridViewTextBoxColumn();
            WGalimsayisi = new DataGridViewTextBoxColumn();
            WGStockInDetailUnit = new DataGridViewTextBoxColumn();
            WGStockInDetailUnitType = new DataGridViewTextBoxColumn();
            WGLastPriceWithVat = new DataGridViewTextBoxColumn();
            dGWProduct = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CartId = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            TransNo = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ProductBarcode = new DataGridViewTextBoxColumn();
            ProductUnit = new DataGridViewTextBoxColumn();
            CartProductUnitType = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            PriceTotal = new DataGridViewTextBoxColumn();
            CartDate = new DataGridViewTextBoxColumn();
            cProductMenuStrip = new ContextMenuStrip(components);
            tSMIProductCartDetail = new ToolStripMenuItem();
            tSMIProductDetail = new ToolStripMenuItem();
            WGProductName = new DataGridViewTextBoxColumn();
            lblTotalAmount = new Label();
            WGProductCode = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pBClose = new PictureBox();
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
            TotalSellProducts = new DataGridViewTextBoxColumn();
            TotalPriceWithVat = new DataGridViewTextBoxColumn();
            dGWProductWithGroup = new DataGridView();
            WGId = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dGWProduct).BeginInit();
            cProductMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
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
            panel1.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle7.BackColor = Color.LightSkyBlue;
            dGWProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dGWProduct.BackgroundColor = Color.White;
            dGWProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dGWProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dGWProduct.ColumnHeadersHeight = 30;
            dGWProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWProduct.Columns.AddRange(new DataGridViewColumn[] { Id, CartId, ProductId, TransNo, ProductCode, Description, ProductBarcode, ProductUnit, CartProductUnitType, Price, PriceTotal, CartDate });
            dGWProduct.ContextMenuStrip = cProductMenuStrip;
            dGWProduct.EditMode = DataGridViewEditMode.EditOnF2;
            dGWProduct.EnableHeadersVisualStyles = false;
            dGWProduct.Location = new Point(3, 2);
            dGWProduct.MultiSelect = false;
            dGWProduct.Name = "dGWProduct";
            dGWProduct.RowHeadersVisible = false;
            dGWProduct.RowTemplate.Height = 25;
            dGWProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWProduct.Size = new Size(997, 112);
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
            // CartId
            // 
            CartId.DataPropertyName = "CartId";
            CartId.HeaderText = "CARTID";
            CartId.Name = "CartId";
            CartId.Visible = false;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            ProductId.Visible = false;
            // 
            // TransNo
            // 
            TransNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TransNo.DataPropertyName = "TransNo";
            TransNo.HeaderText = "BELGE NO";
            TransNo.Name = "TransNo";
            TransNo.Width = 84;
            // 
            // ProductCode
            // 
            ProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "ÜRÜN KODU";
            ProductCode.Name = "ProductCode";
            ProductCode.Width = 96;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "ÜRÜN";
            Description.Name = "Description";
            // 
            // ProductBarcode
            // 
            ProductBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductBarcode.DataPropertyName = "ProductBarcode";
            ProductBarcode.HeaderText = "BARKOD";
            ProductBarcode.Name = "ProductBarcode";
            ProductBarcode.Width = 75;
            // 
            // ProductUnit
            // 
            ProductUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProductUnit.DataPropertyName = "ProductUnit";
            ProductUnit.HeaderText = "ADET/GRAM";
            ProductUnit.Name = "ProductUnit";
            ProductUnit.Width = 97;
            // 
            // CartProductUnitType
            // 
            CartProductUnitType.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CartProductUnitType.DataPropertyName = "ProductUnitType";
            CartProductUnitType.HeaderText = "ÜRÜN TİPİ";
            CartProductUnitType.Name = "CartProductUnitType";
            CartProductUnitType.Width = 84;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "SATIŞ FİYATI";
            Price.Name = "Price";
            Price.Width = 92;
            // 
            // PriceTotal
            // 
            PriceTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PriceTotal.DataPropertyName = "PriceTotal";
            PriceTotal.HeaderText = "TOPLAM TUTAR";
            PriceTotal.Name = "PriceTotal";
            PriceTotal.Width = 113;
            // 
            // CartDate
            // 
            CartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CartDate.DataPropertyName = "CartDate";
            CartDate.HeaderText = "SATIŞ TARİHİ";
            CartDate.Name = "CartDate";
            CartDate.Width = 96;
            // 
            // cProductMenuStrip
            // 
            cProductMenuStrip.Items.AddRange(new ToolStripItem[] { tSMIProductCartDetail, tSMIProductDetail });
            cProductMenuStrip.Name = "cProductMenuStrip";
            cProductMenuStrip.Size = new Size(169, 48);
            // 
            // tSMIProductCartDetail
            // 
            tSMIProductCartDetail.Name = "tSMIProductCartDetail";
            tSMIProductCartDetail.Size = new Size(168, 22);
            tSMIProductCartDetail.Text = "Ürün Çıkışını Gör";
            tSMIProductCartDetail.Click += tSMIProductCartDetail_Click;
            // 
            // tSMIProductDetail
            // 
            tSMIProductDetail.Name = "tSMIProductDetail";
            tSMIProductDetail.Size = new Size(168, 22);
            tSMIProductDetail.Text = "Ürün Detayını Gör";
            tSMIProductDetail.Click += tSMIProductDetail_Click;
            // 
            // WGProductName
            // 
            WGProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WGProductName.DataPropertyName = "ProductName";
            WGProductName.HeaderText = "ÜRÜN";
            WGProductName.Name = "WGProductName";
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
            // WGProductCode
            // 
            WGProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WGProductCode.DataPropertyName = "ProductCode";
            WGProductCode.HeaderText = "ÜRÜN KODU";
            WGProductCode.Name = "WGProductCode";
            WGProductCode.Width = 96;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 2;
            label1.Text = "Ürün Stok Çıkış Raporu";
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(973, 8);
            pBClose.Name = "pBClose";
            pBClose.Size = new Size(24, 24);
            pBClose.TabIndex = 0;
            pBClose.TabStop = false;
            pBClose.Click += pBClose_Click;
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
            splitContainer1.Size = new Size(1011, 540);
            splitContainer1.SplitterDistance = 80;
            splitContainer1.TabIndex = 7;
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
            splitContainer2.Size = new Size(1011, 80);
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
            cmBoxReportType.SelectedValueChanged += cmBoxReportType_SelectedValueChanged;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilter.Location = new Point(922, 3);
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
            txtProductSearch.Location = new Point(36, 4);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.PlaceholderText = "Ürün Ara";
            txtProductSearch.Size = new Size(963, 23);
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
            pictureBox1.Size = new Size(24, 18);
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
            splitContainer3.Size = new Size(1011, 456);
            splitContainer3.SplitterDistance = 408;
            splitContainer3.TabIndex = 7;
            // 
            // dGWProductWithGroupbyMonth
            // 
            dGWProductWithGroupbyMonth.AllowUserToAddRows = false;
            dGWProductWithGroupbyMonth.AllowUserToDeleteRows = false;
            dGWProductWithGroupbyMonth.AllowUserToOrderColumns = true;
            dGWProductWithGroupbyMonth.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dGWProductWithGroupbyMonth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGWProductWithGroupbyMonth.BackgroundColor = Color.White;
            dGWProductWithGroupbyMonth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dGWProductWithGroupbyMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dGWProductWithGroupbyMonth.ColumnHeadersHeight = 30;
            dGWProductWithGroupbyMonth.Columns.AddRange(new DataGridViewColumn[] { Month, MonthName, Year, TotalSellProducts, TotalPriceWithVat });
            dGWProductWithGroupbyMonth.EditMode = DataGridViewEditMode.EditOnF2;
            dGWProductWithGroupbyMonth.EnableHeadersVisualStyles = false;
            dGWProductWithGroupbyMonth.Location = new Point(3, 250);
            dGWProductWithGroupbyMonth.MultiSelect = false;
            dGWProductWithGroupbyMonth.Name = "dGWProductWithGroupbyMonth";
            dGWProductWithGroupbyMonth.RowHeadersVisible = false;
            dGWProductWithGroupbyMonth.RowTemplate.Height = 25;
            dGWProductWithGroupbyMonth.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWProductWithGroupbyMonth.Size = new Size(997, 124);
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
            // TotalSellProducts
            // 
            TotalSellProducts.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalSellProducts.DataPropertyName = "TotalSellProducts";
            TotalSellProducts.HeaderText = "TOPLAM ÜRÜN";
            TotalSellProducts.Name = "TotalSellProducts";
            TotalSellProducts.Width = 111;
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
            dGWProductWithGroup.Size = new Size(997, 124);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pBClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 40);
            panel1.TabIndex = 6;
            // 
            // frmCartProductReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 580);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCartProductReports";
            Text = "frmCartProductReports";
            Load += frmCartProductReports_Load;
            ((System.ComponentModel.ISupportInitialize)dGWProduct).EndInit();
            cProductMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTotal;
        private DataGridViewTextBoxColumn WGProductBarcode;
        private DataGridViewTextBoxColumn WGalimsayisi;
        private DataGridViewTextBoxColumn WGStockInDetailUnit;
        private DataGridViewTextBoxColumn WGStockInDetailUnitType;
        private DataGridViewTextBoxColumn WGLastPriceWithVat;
        public DataGridView dGWProduct;
        private ContextMenuStrip cProductMenuStrip;
        private ToolStripMenuItem tSMIProductCartDetail;
        private ToolStripMenuItem tSMIProductDetail;
        private DataGridViewTextBoxColumn WGProductName;
        private Label lblTotalAmount;
        private DataGridViewTextBoxColumn WGProductCode;
        private Label label1;
        private PictureBox pBClose;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label lblYearSelect;
        private Label label3;
        private ComboBox cmBoxYears;
        private ComboBox cmBoxReportType;
        private Button btnFilter;
        private DateTimePicker dTPEndDate;
        private DateTimePicker dTPBeginDate;
        private Label lblPickDate;
        public TextBox txtProductSearch;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer3;
        public DataGridView dGWProductWithGroupbyMonth;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn MonthName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn TotalStockedProducts;
        private DataGridViewTextBoxColumn TotalPriceWithVat;
        public DataGridView dGWProductWithGroup;
        private DataGridViewTextBoxColumn WGId;
        private Panel panel1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CartId;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn TransNo;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ProductBarcode;
        private DataGridViewTextBoxColumn ProductUnit;
        private DataGridViewTextBoxColumn CartProductUnitType;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn PriceTotal;
        private DataGridViewTextBoxColumn CartDate;
        private DataGridViewTextBoxColumn TotalSellProducts;
    }
}