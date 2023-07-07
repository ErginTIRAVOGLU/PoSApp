namespace PoSApp.Desktop.Forms.ProductForms
{
    partial class frmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pbAdd = new PictureBox();
            pBClose = new PictureBox();
            dGWProduct = new DataGridView();
            splitContainer1 = new SplitContainer();
            txtProductSearch = new TextBox();
            pictureBox1 = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductBarcode = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductUnitTypeColon = new DataGridViewTextBoxColumn();
            Vat = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbAdd);
            panel1.Controls.Add(pBClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 3;
            label1.Text = "Ürün Listesi";
            // 
            // pbAdd
            // 
            pbAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbAdd.BackgroundImage = (Image)resources.GetObject("pbAdd.BackgroundImage");
            pbAdd.BackgroundImageLayout = ImageLayout.Center;
            pbAdd.Cursor = Cursors.Hand;
            pbAdd.Location = new Point(752, 7);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(24, 24);
            pbAdd.TabIndex = 1;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(773, 7);
            pBClose.Name = "pBClose";
            pBClose.Size = new Size(24, 24);
            pBClose.TabIndex = 0;
            pBClose.TabStop = false;
            pBClose.Click += pBClose_Click;
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
            dGWProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Id, ProductCode, ProductName, ProductBarcode, ProductPrice, ProductUnitTypeColon, Vat, Edit, Delete });
            dGWProduct.Dock = DockStyle.Fill;
            dGWProduct.EditMode = DataGridViewEditMode.EditOnF2;
            dGWProduct.EnableHeadersVisualStyles = false;
            dGWProduct.Location = new Point(0, 0);
            dGWProduct.MultiSelect = false;
            dGWProduct.Name = "dGWProduct";
            dGWProduct.RowHeadersVisible = false;
            dGWProduct.RowTemplate.Height = 25;
            dGWProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWProduct.Size = new Size(800, 429);
            dGWProduct.TabIndex = 5;
            dGWProduct.CellContentClick += dGWProduct_CellContentClick;
            dGWProduct.CellDoubleClick += dGWProduct_CellDoubleClick;
            dGWProduct.CellFormatting += dGWProduct_CellFormatting;
            dGWProduct.KeyDown += dGWProduct_KeyDown;
            dGWProduct.KeyUp += dGWProduct_KeyUp;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 40);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtProductSearch);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dGWProduct);
            splitContainer1.Size = new Size(800, 470);
            splitContainer1.SplitterDistance = 37;
            splitContainer1.TabIndex = 6;
            // 
            // txtProductSearch
            // 
            txtProductSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProductSearch.Location = new Point(33, 6);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.PlaceholderText = "Ürün Ara";
            txtProductSearch.Size = new Size(755, 25);
            txtProductSearch.TabIndex = 3;
            txtProductSearch.TextChanged += txtProductSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 39;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.Visible = false;
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
            // ProductPrice
            // 
            ProductPrice.DataPropertyName = "ProductPrice";
            ProductPrice.HeaderText = "FİYATI";
            ProductPrice.Name = "ProductPrice";
            // 
            // ProductUnitTypeColon
            // 
            ProductUnitTypeColon.DataPropertyName = "ProductUnitType";
            ProductUnitTypeColon.HeaderText = "BİRİM TİPİ";
            ProductUnitTypeColon.Name = "ProductUnitTypeColon";
            // 
            // Vat
            // 
            Vat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Vat.DataPropertyName = "Vat";
            Vat.HeaderText = "KDV";
            Vat.Name = "Vat";
            Vat.Width = 56;
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
            // frmProductList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductList";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWProduct).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pbAdd;
        private PictureBox pBClose;
        public DataGridView dGWProduct;
        private SplitContainer splitContainer1;
        public TextBox txtProductSearch;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductBarcode;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductUnitTypeColon;
        private DataGridViewTextBoxColumn Vat;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}