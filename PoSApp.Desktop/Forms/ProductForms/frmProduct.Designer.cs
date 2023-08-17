namespace PoSApp.Desktop.Forms.ProductForms
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtProduct = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pBClose = new PictureBox();
            label1 = new Label();
            cmBoxBrand = new ComboBox();
            cmBoxCategory = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmBoxProductUnitType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            lblStok = new Label();
            txtProductPrice = new TextBox();
            txtBarcode = new TextBox();
            label8 = new Label();
            txtCode = new TextBox();
            label9 = new Label();
            txtDescription = new TextBox();
            label10 = new Label();
            txtVat = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(270, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 36);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(189, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 36);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(108, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(108, 58);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(410, 23);
            txtProduct.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 61);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Ürün Adı :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(pBClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 40);
            panel1.TabIndex = 7;
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(509, 9);
            pBClose.Name = "pBClose";
            pBClose.Size = new Size(24, 24);
            pBClose.TabIndex = 1;
            pBClose.TabStop = false;
            pBClose.Click += pBClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // cmBoxBrand
            // 
            cmBoxBrand.FormattingEnabled = true;
            cmBoxBrand.Location = new Point(360, 145);
            cmBoxBrand.Name = "cmBoxBrand";
            cmBoxBrand.Size = new Size(158, 23);
            cmBoxBrand.TabIndex = 6;
            // 
            // cmBoxCategory
            // 
            cmBoxCategory.FormattingEnabled = true;
            cmBoxCategory.Location = new Point(360, 116);
            cmBoxCategory.Name = "cmBoxCategory";
            cmBoxCategory.Size = new Size(158, 23);
            cmBoxCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 148);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 15;
            label3.Text = "Marka Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 119);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 16;
            label4.Text = "Kategori Adı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 177);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 18;
            label5.Text = "Ürün Birimı :";
            // 
            // cmBoxProductUnitType
            // 
            cmBoxProductUnitType.FormattingEnabled = true;
            cmBoxProductUnitType.Location = new Point(360, 174);
            cmBoxProductUnitType.Name = "cmBoxProductUnitType";
            cmBoxProductUnitType.Size = new Size(158, 23);
            cmBoxProductUnitType.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 119);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 8;
            label6.Text = "Ürün Fiyatı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 370);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 8;
            label7.Text = "Stok :";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(110, 370);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(13, 15);
            lblStok.TabIndex = 19;
            lblStok.Text = "0";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(108, 116);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(158, 23);
            txtProductPrice.TabIndex = 2;
            txtProductPrice.Validating += txtProductPrice_Validating;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(360, 87);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(158, 23);
            txtBarcode.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 90);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 22;
            label8.Text = "Barkod :";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(108, 87);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(158, 23);
            txtCode.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 90);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 24;
            label9.Text = "Ürün Kodu :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(108, 209);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(408, 99);
            txtDescription.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 212);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 26;
            label10.Text = "Açıklama :";
            // 
            // txtVat
            // 
            txtVat.Location = new Point(108, 145);
            txtVat.Name = "txtVat";
            txtVat.Size = new Size(158, 23);
            txtVat.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 148);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 28;
            label11.Text = "Ürün KDV :";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 396);
            Controls.Add(txtVat);
            Controls.Add(label11);
            Controls.Add(txtDescription);
            Controls.Add(label10);
            Controls.Add(txtCode);
            Controls.Add(label9);
            Controls.Add(txtBarcode);
            Controls.Add(label8);
            Controls.Add(txtProductPrice);
            Controls.Add(lblStok);
            Controls.Add(label5);
            Controls.Add(cmBoxProductUnitType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmBoxCategory);
            Controls.Add(cmBoxBrand);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtProduct);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private Button btnSave;
        public TextBox txtProduct;
        private Label label2;
        private Panel panel1;
        private PictureBox pBClose;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public ComboBox cmBoxBrand;
        public ComboBox cmBoxCategory;
        public ComboBox cmBoxProductUnitType;
        public TextBox txtProductPrice;
        public TextBox txtBarcode;
        private Label label8;
        public TextBox txtCode;
        private Label label9;
        public TextBox txtDescription;
        private Label label10;
        public TextBox txtVat;
        private Label label11;
        public Label lblStok;
    }
}