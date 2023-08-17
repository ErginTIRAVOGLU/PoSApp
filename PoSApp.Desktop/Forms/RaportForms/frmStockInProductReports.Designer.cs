namespace PoSApp.Desktop.Forms.RaportForms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            pBClose = new PictureBox();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            chkBProductGroup = new CheckBox();
            btnFiltre = new Button();
            dTPEndDate = new DateTimePicker();
            dTPBeginDate = new DateTimePicker();
            label2 = new Label();
            txtProductSearch = new TextBox();
            pictureBox1 = new PictureBox();
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
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cProductMenuStrip = new ContextMenuStrip(components);
            tSMIProductStockInDetail = new ToolStripMenuItem();
            tSMIProductDetail = new ToolStripMenuItem();
            pnlAlt = new Panel();
            lblTotalAmount = new Label();
            lblTotal = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dGWProduct).BeginInit();
            cProductMenuStrip.SuspendLayout();
            pnlAlt.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(dGWProduct);
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
            splitContainer2.Panel1.Controls.Add(chkBProductGroup);
            splitContainer2.Panel1.Controls.Add(btnFiltre);
            splitContainer2.Panel1.Controls.Add(dTPEndDate);
            splitContainer2.Panel1.Controls.Add(dTPBeginDate);
            splitContainer2.Panel1.Controls.Add(label2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtProductSearch);
            splitContainer2.Panel2.Controls.Add(pictureBox1);
            splitContainer2.Size = new Size(1145, 79);
            splitContainer2.SplitterDistance = 40;
            splitContainer2.TabIndex = 0;
            // 
            // chkBProductGroup
            // 
            chkBProductGroup.AutoSize = true;
            chkBProductGroup.Enabled = false;
            chkBProductGroup.Location = new Point(769, 12);
            chkBProductGroup.Name = "chkBProductGroup";
            chkBProductGroup.Size = new Size(106, 19);
            chkBProductGroup.TabIndex = 8;
            chkBProductGroup.Text = "Ürünleri Grupla";
            chkBProductGroup.UseVisualStyleBackColor = true;
            // 
            // btnFiltre
            // 
            btnFiltre.Location = new Point(670, 4);
            btnFiltre.Name = "btnFiltre";
            btnFiltre.Size = new Size(75, 28);
            btnFiltre.TabIndex = 7;
            btnFiltre.Text = "Yükle";
            btnFiltre.UseVisualStyleBackColor = true;
            btnFiltre.Click += btnFiltre_Click;
            // 
            // dTPEndDate
            // 
            dTPEndDate.Location = new Point(464, 6);
            dTPEndDate.Name = "dTPEndDate";
            dTPEndDate.Size = new Size(200, 23);
            dTPEndDate.TabIndex = 6;
            // 
            // dTPBeginDate
            // 
            dTPBeginDate.Location = new Point(258, 6);
            dTPBeginDate.Name = "dTPBeginDate";
            dTPBeginDate.Size = new Size(200, 23);
            dTPBeginDate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 12);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Tarih Aralığı : ";
            // 
            // txtProductSearch
            // 
            txtProductSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProductSearch.Location = new Point(36, 3);
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
            // dGWProduct
            // 
            dGWProduct.AllowUserToAddRows = false;
            dGWProduct.AllowUserToDeleteRows = false;
            dGWProduct.AllowUserToOrderColumns = true;
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
            dGWProduct.Columns.AddRange(new DataGridViewColumn[] { Id, StockInId, ProductId, ProductCode, ProductName, ProductBarcode, onePrice, StockInDetailUnit, LastPriceWithVat, StockInDetailUnitType, ProductPrice, StockInDate, Edit, Delete });
            dGWProduct.ContextMenuStrip = cProductMenuStrip;
            dGWProduct.Dock = DockStyle.Fill;
            dGWProduct.EditMode = DataGridViewEditMode.EditOnF2;
            dGWProduct.EnableHeadersVisualStyles = false;
            dGWProduct.Location = new Point(0, 0);
            dGWProduct.MultiSelect = false;
            dGWProduct.Name = "dGWProduct";
            dGWProduct.RowHeadersVisible = false;
            dGWProduct.RowTemplate.Height = 25;
            dGWProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWProduct.Size = new Size(1145, 447);
            dGWProduct.TabIndex = 6;
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
            ProductCode.Width = 106;
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
            ProductBarcode.DataPropertyName = "ProductBarcode";
            ProductBarcode.HeaderText = "BARKOD";
            ProductBarcode.Name = "ProductBarcode";
            // 
            // onePrice
            // 
            onePrice.DataPropertyName = "onePrice";
            onePrice.HeaderText = "ALIŞ FİYATI";
            onePrice.Name = "onePrice";
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
            LastPriceWithVat.Width = 170;
            // 
            // StockInDetailUnitType
            // 
            StockInDetailUnitType.DataPropertyName = "StockInDetailUnitType";
            StockInDetailUnitType.HeaderText = "ÜRÜN TİPİ";
            StockInDetailUnitType.Name = "StockInDetailUnitType";
            // 
            // ProductPrice
            // 
            ProductPrice.DataPropertyName = "ProductPrice";
            ProductPrice.HeaderText = "SATIŞ FİYATI";
            ProductPrice.Name = "ProductPrice";
            // 
            // StockInDate
            // 
            StockInDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StockInDate.DataPropertyName = "StockInDate";
            StockInDate.HeaderText = "STOK GİRİŞ TARİHİ";
            StockInDate.Name = "StockInDate";
            StockInDate.Width = 137;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.Name = "Edit";
            Edit.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.Width = 5;
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
            // pnlAlt
            // 
            pnlAlt.Controls.Add(lblTotalAmount);
            pnlAlt.Controls.Add(lblTotal);
            pnlAlt.Dock = DockStyle.Bottom;
            pnlAlt.Location = new Point(0, 501);
            pnlAlt.Name = "pnlAlt";
            pnlAlt.Size = new Size(1145, 69);
            pnlAlt.TabIndex = 6;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(769, 21);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(13, 15);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(708, 21);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Toplam : ";
            // 
            // frmStockInProductReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 570);
            Controls.Add(pnlAlt);
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
            ((System.ComponentModel.ISupportInitialize)dGWProduct).EndInit();
            cProductMenuStrip.ResumeLayout(false);
            pnlAlt.ResumeLayout(false);
            pnlAlt.PerformLayout();
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
        private Button btnFiltre;
        private DateTimePicker dTPEndDate;
        private DateTimePicker dTPBeginDate;
        private Label label2;
        public DataGridView dGWProduct;
        private ContextMenuStrip cProductMenuStrip;
        private ToolStripMenuItem tSMIProductStockInDetail;
        private Panel pnlAlt;
        private Label lblTotalAmount;
        private Label lblTotal;
        private ToolStripMenuItem tSMIProductDetail;
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
        private CheckBox chkBProductGroup;
    }
}