namespace PoSApp.Desktop.Forms.StockInForms
{
    partial class frmStockInDetailList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInDetailList));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dGWProduct = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Select = new DataGridViewImageColumn();
            panel1 = new Panel();
            label1 = new Label();
            pBClose = new PictureBox();
            pictureBox1 = new PictureBox();
            txtProductSearch = new TextBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            dtTimeInputDate = new DateTimePicker();
            cmBoxSupplier = new ComboBox();
            txtStockInRefNo = new TextBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            dGWStockInDetail = new DataGridView();
            detailId = new DataGridViewTextBoxColumn();
            detailProductId = new DataGridViewTextBoxColumn();
            detailProductCode = new DataGridViewTextBoxColumn();
            detailProductName = new DataGridViewTextBoxColumn();
            DepoAdi = new DataGridViewTextBoxColumn();
            detailStockInDetailUnit = new DataGridViewTextBoxColumn();
            StockInDetailUnitType = new DataGridViewTextBoxColumn();
            ProductWarehouseId = new DataGridViewTextBoxColumn();
            ProductArrivalPrice = new DataGridViewTextBoxColumn();
            ProductDiscountPercentage = new DataGridViewTextBoxColumn();
            ProductUnitDiscountAmount = new DataGridViewTextBoxColumn();
            ProductTotalDiscountAmount = new DataGridViewTextBoxColumn();
            ProductTotalVatAmount = new DataGridViewTextBoxColumn();
            ProductLastPriceWithoutVat = new DataGridViewTextBoxColumn();
            ProductLastPriceWithVat = new DataGridViewTextBoxColumn();
            detailDelete = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            StockInDetailUnit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dGWProduct).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGWStockInDetail).BeginInit();
            SuspendLayout();
            // 
            // dGWProduct
            // 
            dGWProduct.AllowUserToAddRows = false;
            dGWProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dGWProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGWProduct.BackgroundColor = Color.White;
            dGWProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dGWProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dGWProduct.ColumnHeadersHeight = 30;
            dGWProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWProduct.Columns.AddRange(new DataGridViewColumn[] { Id, ProductCode, ProductName, Select });
            dGWProduct.Dock = DockStyle.Fill;
            dGWProduct.EnableHeadersVisualStyles = false;
            dGWProduct.Location = new Point(0, 0);
            dGWProduct.Name = "dGWProduct";
            dGWProduct.RowHeadersVisible = false;
            dGWProduct.RowTemplate.Height = 25;
            dGWProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWProduct.Size = new Size(964, 186);
            dGWProduct.TabIndex = 4;
            dGWProduct.CellContentClick += dGWProduct_CellContentClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "#";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // ProductCode
            // 
            ProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "KOD";
            ProductCode.Name = "ProductCode";
            ProductCode.Width = 57;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ADI";
            ProductName.Name = "ProductName";
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Select.HeaderText = "";
            Select.Image = (Image)resources.GetObject("Select.Image");
            Select.Name = "Select";
            Select.Width = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pBClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1305, 40);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 2;
            label1.Text = "Ürün Stok Girişi";
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(1278, 8);
            pBClose.Name = "pBClose";
            pBClose.Size = new Size(24, 24);
            pBClose.TabIndex = 0;
            pBClose.TabStop = false;
            pBClose.Click += pBClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(11, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 25);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtProductSearch
            // 
            txtProductSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductSearch.Location = new Point(41, 3);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.PlaceholderText = "Ürün Ara";
            txtProductSearch.Size = new Size(911, 25);
            txtProductSearch.TabIndex = 0;
            txtProductSearch.TextChanged += txtProductSearch_TextChanged;
            txtProductSearch.KeyDown += txtProductSearch_KeyDown;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(1225, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 36);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Location = new Point(1144, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 36);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(1063, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 13;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 97);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 5;
            label4.Text = "Giriş Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 55);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 4;
            label3.Text = "Tedarikçi :";
            // 
            // dtTimeInputDate
            // 
            dtTimeInputDate.Location = new Point(97, 91);
            dtTimeInputDate.Name = "dtTimeInputDate";
            dtTimeInputDate.Size = new Size(200, 25);
            dtTimeInputDate.TabIndex = 3;
            // 
            // cmBoxSupplier
            // 
            cmBoxSupplier.FormattingEnabled = true;
            cmBoxSupplier.Location = new Point(96, 52);
            cmBoxSupplier.Name = "cmBoxSupplier";
            cmBoxSupplier.Size = new Size(169, 25);
            cmBoxSupplier.TabIndex = 2;
            // 
            // txtStockInRefNo
            // 
            txtStockInRefNo.Location = new Point(97, 19);
            txtStockInRefNo.Name = "txtStockInRefNo";
            txtStockInRefNo.Size = new Size(168, 25);
            txtStockInRefNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 22);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 0;
            label2.Text = "Belge No :";
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
            splitContainer1.Size = new Size(1305, 563);
            splitContainer1.SplitterDistance = 225;
            splitContainer1.TabIndex = 16;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(dtTimeInputDate);
            splitContainer2.Panel1.Controls.Add(cmBoxSupplier);
            splitContainer2.Panel1.Controls.Add(txtStockInRefNo);
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer4);
            splitContainer2.Size = new Size(1305, 225);
            splitContainer2.SplitterDistance = 337;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(txtProductSearch);
            splitContainer4.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(dGWProduct);
            splitContainer4.Size = new Size(964, 225);
            splitContainer4.SplitterDistance = 35;
            splitContainer4.TabIndex = 5;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(dGWStockInDetail);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(btnSave);
            splitContainer3.Panel2.Controls.Add(btnCancel);
            splitContainer3.Panel2.Controls.Add(btnUpdate);
            splitContainer3.Size = new Size(1305, 334);
            splitContainer3.SplitterDistance = 289;
            splitContainer3.TabIndex = 6;
            // 
            // dGWStockInDetail
            // 
            dGWStockInDetail.AllowUserToAddRows = false;
            dGWStockInDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.LightSkyBlue;
            dGWStockInDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dGWStockInDetail.BackgroundColor = Color.White;
            dGWStockInDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dGWStockInDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dGWStockInDetail.ColumnHeadersHeight = 30;
            dGWStockInDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWStockInDetail.Columns.AddRange(new DataGridViewColumn[] { detailId, detailProductId, detailProductCode, detailProductName, DepoAdi, detailStockInDetailUnit, StockInDetailUnitType, ProductWarehouseId, ProductArrivalPrice, ProductDiscountPercentage, ProductUnitDiscountAmount, ProductTotalDiscountAmount, ProductTotalVatAmount, ProductLastPriceWithoutVat, ProductLastPriceWithVat, detailDelete });
            dGWStockInDetail.Dock = DockStyle.Fill;
            dGWStockInDetail.EnableHeadersVisualStyles = false;
            dGWStockInDetail.Location = new Point(0, 0);
            dGWStockInDetail.Name = "dGWStockInDetail";
            dGWStockInDetail.ReadOnly = true;
            dGWStockInDetail.RowHeadersVisible = false;
            dGWStockInDetail.RowTemplate.Height = 25;
            dGWStockInDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWStockInDetail.Size = new Size(1305, 289);
            dGWStockInDetail.TabIndex = 5;
            dGWStockInDetail.CellContentClick += dGWStockInDetail_CellContentClick;
            dGWStockInDetail.CellFormatting += dGWStockInDetail_CellFormatting;
            // 
            // detailId
            // 
            detailId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            detailId.DataPropertyName = "Id";
            detailId.HeaderText = "#";
            detailId.Name = "detailId";
            detailId.ReadOnly = true;
            detailId.Visible = false;
            // 
            // detailProductId
            // 
            detailProductId.DataPropertyName = "ProductId";
            detailProductId.HeaderText = "ProductId";
            detailProductId.Name = "detailProductId";
            detailProductId.ReadOnly = true;
            detailProductId.Visible = false;
            // 
            // detailProductCode
            // 
            detailProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            detailProductCode.DataPropertyName = "ProductCode";
            detailProductCode.HeaderText = "KOD";
            detailProductCode.Name = "detailProductCode";
            detailProductCode.ReadOnly = true;
            detailProductCode.Width = 57;
            // 
            // detailProductName
            // 
            detailProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            detailProductName.DataPropertyName = "ProductName";
            detailProductName.HeaderText = "ÜRÜN ADI";
            detailProductName.Name = "detailProductName";
            detailProductName.ReadOnly = true;
            detailProductName.Width = 91;
            // 
            // DepoAdi
            // 
            DepoAdi.DataPropertyName = "DepoAdi";
            DepoAdi.HeaderText = "Depo Adi";
            DepoAdi.Name = "DepoAdi";
            DepoAdi.ReadOnly = true;
            // 
            // detailStockInDetailUnit
            // 
            detailStockInDetailUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            detailStockInDetailUnit.DataPropertyName = "StockInDetailUnit";
            detailStockInDetailUnit.HeaderText = "Miktar";
            detailStockInDetailUnit.Name = "detailStockInDetailUnit";
            detailStockInDetailUnit.ReadOnly = true;
            detailStockInDetailUnit.Width = 68;
            // 
            // StockInDetailUnitType
            // 
            StockInDetailUnitType.DataPropertyName = "StockInDetailUnitType";
            StockInDetailUnitType.HeaderText = "";
            StockInDetailUnitType.Name = "StockInDetailUnitType";
            StockInDetailUnitType.ReadOnly = true;
            // 
            // ProductWarehouseId
            // 
            ProductWarehouseId.DataPropertyName = "ProductWarehouseId";
            ProductWarehouseId.HeaderText = "Depo";
            ProductWarehouseId.Name = "ProductWarehouseId";
            ProductWarehouseId.ReadOnly = true;
            ProductWarehouseId.Visible = false;
            // 
            // ProductArrivalPrice
            // 
            ProductArrivalPrice.DataPropertyName = "ProductArrivalPrice";
            ProductArrivalPrice.HeaderText = "Birim Fiyat";
            ProductArrivalPrice.Name = "ProductArrivalPrice";
            ProductArrivalPrice.ReadOnly = true;
            // 
            // ProductDiscountPercentage
            // 
            ProductDiscountPercentage.DataPropertyName = "ProductDiscountPercentage";
            ProductDiscountPercentage.HeaderText = "İskonto Oranı";
            ProductDiscountPercentage.Name = "ProductDiscountPercentage";
            ProductDiscountPercentage.ReadOnly = true;
            // 
            // ProductUnitDiscountAmount
            // 
            ProductUnitDiscountAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProductUnitDiscountAmount.DataPropertyName = "ProductUnitDiscountAmount";
            ProductUnitDiscountAmount.HeaderText = "Tek Ürün İndirim Tutarı";
            ProductUnitDiscountAmount.Name = "ProductUnitDiscountAmount";
            ProductUnitDiscountAmount.ReadOnly = true;
            ProductUnitDiscountAmount.Width = 163;
            // 
            // ProductTotalDiscountAmount
            // 
            ProductTotalDiscountAmount.DataPropertyName = "ProductTotalDiscountAmount";
            ProductTotalDiscountAmount.HeaderText = "İskonto Tutarı";
            ProductTotalDiscountAmount.Name = "ProductTotalDiscountAmount";
            ProductTotalDiscountAmount.ReadOnly = true;
            // 
            // ProductTotalVatAmount
            // 
            ProductTotalVatAmount.DataPropertyName = "ProductTotalVatAmount";
            ProductTotalVatAmount.HeaderText = "KDV Tutarı";
            ProductTotalVatAmount.Name = "ProductTotalVatAmount";
            ProductTotalVatAmount.ReadOnly = true;
            // 
            // ProductLastPriceWithoutVat
            // 
            ProductLastPriceWithoutVat.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProductLastPriceWithoutVat.DataPropertyName = "ProductLastPriceWithoutVat";
            ProductLastPriceWithoutVat.HeaderText = "KDV'siz Toplam Fiyat";
            ProductLastPriceWithoutVat.Name = "ProductLastPriceWithoutVat";
            ProductLastPriceWithoutVat.ReadOnly = true;
            ProductLastPriceWithoutVat.Width = 151;
            // 
            // ProductLastPriceWithVat
            // 
            ProductLastPriceWithVat.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProductLastPriceWithVat.DataPropertyName = "ProductLastPriceWithVat";
            ProductLastPriceWithVat.HeaderText = "KDV'li Toplam Fiyat";
            ProductLastPriceWithVat.Name = "ProductLastPriceWithVat";
            ProductLastPriceWithVat.ReadOnly = true;
            ProductLastPriceWithVat.Width = 142;
            // 
            // detailDelete
            // 
            detailDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            detailDelete.HeaderText = "";
            detailDelete.Image = (Image)resources.GetObject("detailDelete.Image");
            detailDelete.Name = "detailDelete";
            detailDelete.ReadOnly = true;
            detailDelete.Resizable = DataGridViewTriState.True;
            detailDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            detailDelete.Width = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "#";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // StockInDetailUnit
            // 
            StockInDetailUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockInDetailUnit.DataPropertyName = "StockInDetailUnit";
            StockInDetailUnit.HeaderText = "Adet";
            StockInDetailUnit.Name = "StockInDetailUnit";
            // 
            // frmStockInDetailList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 603);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStockInDetailList";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmStockInDetailList_Load;
            ((System.ComponentModel.ISupportInitialize)dGWProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGWStockInDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pBClose;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        public DataGridView dGWProduct;
        public ComboBox cmBoxSupplier;
        public TextBox txtProductSearch;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn StockInDetailUnit;
        public DataGridView dGWStockInDetail;
        public Button btnUpdate;
        public Button btnSave;
        public DateTimePicker dtTimeInputDate;
        public TextBox txtStockInRefNo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewImageColumn Select;
        private DataGridViewTextBoxColumn detailId;
        private DataGridViewTextBoxColumn detailProductId;
        private DataGridViewTextBoxColumn detailProductCode;
        private DataGridViewTextBoxColumn detailProductName;
        private DataGridViewTextBoxColumn DepoAdi;
        private DataGridViewTextBoxColumn detailStockInDetailUnit;
        private DataGridViewTextBoxColumn StockInDetailUnitType;
        private DataGridViewTextBoxColumn ProductWarehouseId;
        private DataGridViewTextBoxColumn ProductArrivalPrice;
        private DataGridViewTextBoxColumn ProductDiscountPercentage;
        private DataGridViewTextBoxColumn ProductUnitDiscountAmount;
        private DataGridViewTextBoxColumn ProductTotalDiscountAmount;
        private DataGridViewTextBoxColumn ProductTotalVatAmount;
        private DataGridViewTextBoxColumn ProductLastPriceWithoutVat;
        private DataGridViewTextBoxColumn ProductLastPriceWithVat;
        private DataGridViewImageColumn detailDelete;
    }
}