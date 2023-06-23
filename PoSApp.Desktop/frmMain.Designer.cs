namespace PoSApp.Desktop
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panel1 = new Panel();
            pnlSide = new Panel();
            btnUpdate = new Button();
            btnStockIn = new Button();
            btnSupplier = new Button();
            btnBrand = new Button();
            btnReports = new Button();
            btnSettings = new Button();
            btnRecords = new Button();
            btnCategory = new Button();
            btnProduct = new Button();
            btnPos = new Button();
            btnDashboard = new Button();
            btnWarehouse = new Button();
            btnExit = new Button();
            label1 = new Label();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            pnlMain = new Panel();
            pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 40);
            panel1.TabIndex = 0;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(37, 37, 38);
            pnlSide.Controls.Add(btnUpdate);
            pnlSide.Controls.Add(btnStockIn);
            pnlSide.Controls.Add(btnSupplier);
            pnlSide.Controls.Add(btnBrand);
            pnlSide.Controls.Add(btnReports);
            pnlSide.Controls.Add(btnSettings);
            pnlSide.Controls.Add(btnRecords);
            pnlSide.Controls.Add(btnCategory);
            pnlSide.Controls.Add(btnProduct);
            pnlSide.Controls.Add(btnPos);
            pnlSide.Controls.Add(btnDashboard);
            pnlSide.Controls.Add(btnWarehouse);
            pnlSide.Controls.Add(btnExit);
            pnlSide.Controls.Add(label1);
            pnlSide.Controls.Add(lblName);
            pnlSide.Controls.Add(pictureBox1);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 40);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(200, 660);
            pnlSide.TabIndex = 1;
            pnlSide.Paint += pnlSide_Paint;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(24, 594);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Güncelleme";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnStockIn
            // 
            btnStockIn.Cursor = Cursors.Hand;
            btnStockIn.FlatAppearance.BorderSize = 0;
            btnStockIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnStockIn.FlatStyle = FlatStyle.Flat;
            btnStockIn.ForeColor = Color.White;
            btnStockIn.Image = (Image)resources.GetObject("btnStockIn.Image");
            btnStockIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockIn.Location = new Point(1, 205);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(194, 34);
            btnStockIn.TabIndex = 13;
            btnStockIn.Text = " [F3] Ürün Girişi";
            btnStockIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStockIn.UseVisualStyleBackColor = true;
            btnStockIn.Click += btnStockIn_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.Cursor = Cursors.Hand;
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.ForeColor = Color.White;
            btnSupplier.Image = (Image)resources.GetObject("btnSupplier.Image");
            btnSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupplier.Location = new Point(1, 390);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(194, 34);
            btnSupplier.TabIndex = 12;
            btnSupplier.Text = " [F8] Tedarikçi Takip";
            btnSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnBrand
            // 
            btnBrand.Cursor = Cursors.Hand;
            btnBrand.FlatAppearance.BorderSize = 0;
            btnBrand.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnBrand.FlatStyle = FlatStyle.Flat;
            btnBrand.ForeColor = Color.White;
            btnBrand.Image = (Image)resources.GetObject("btnBrand.Image");
            btnBrand.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrand.Location = new Point(1, 353);
            btnBrand.Name = "btnBrand";
            btnBrand.Size = new Size(194, 34);
            btnBrand.TabIndex = 11;
            btnBrand.Text = " [F7] Marka Takip";
            btnBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrand.UseVisualStyleBackColor = true;
            btnBrand.Click += btnBrand_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(1, 464);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(194, 34);
            btnReports.TabIndex = 9;
            btnReports.Text = " [F10] Raporlar *";
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(1, 501);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(194, 34);
            btnSettings.TabIndex = 8;
            btnSettings.Text = " [F11] Ayarlar *";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnRecords
            // 
            btnRecords.Cursor = Cursors.Hand;
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.ForeColor = Color.White;
            btnRecords.Image = (Image)resources.GetObject("btnRecords.Image");
            btnRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecords.Location = new Point(1, 427);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(194, 34);
            btnRecords.TabIndex = 7;
            btnRecords.Text = " [F9] Kayıtlar *";
            btnRecords.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // btnCategory
            // 
            btnCategory.Cursor = Cursors.Hand;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.ForeColor = Color.White;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(1, 279);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(194, 34);
            btnCategory.TabIndex = 6;
            btnCategory.Text = " [F5] Kategori Takip";
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.Cursor = Cursors.Hand;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(1, 242);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(194, 34);
            btnProduct.TabIndex = 5;
            btnProduct.Text = " [F4] Ürün Takip";
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnPos
            // 
            btnPos.Cursor = Cursors.Hand;
            btnPos.FlatAppearance.BorderSize = 0;
            btnPos.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnPos.FlatStyle = FlatStyle.Flat;
            btnPos.ForeColor = Color.White;
            btnPos.Image = (Image)resources.GetObject("btnPos.Image");
            btnPos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPos.Location = new Point(1, 168);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(194, 34);
            btnPos.TabIndex = 4;
            btnPos.Text = " [F2] POS";
            btnPos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPos.UseVisualStyleBackColor = true;
            btnPos.Click += btnPos_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(1, 131);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(194, 34);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = " [F1] Dashboard *";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnWarehouse
            // 
            btnWarehouse.Cursor = Cursors.Hand;
            btnWarehouse.FlatAppearance.BorderSize = 0;
            btnWarehouse.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.ForeColor = Color.White;
            btnWarehouse.Image = (Image)resources.GetObject("btnWarehouse.Image");
            btnWarehouse.ImageAlign = ContentAlignment.MiddleLeft;
            btnWarehouse.Location = new Point(1, 316);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(194, 34);
            btnWarehouse.TabIndex = 14;
            btnWarehouse.Text = " [F6] Depo Takip";
            btnWarehouse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWarehouse.UseVisualStyleBackColor = true;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1, 623);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(194, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = " [ESC] Çıkış";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 104);
            label1.Name = "label1";
            label1.Size = new Size(150, 24);
            label1.TabIndex = 2;
            label1.Text = "Yönetici *";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(25, 118, 210);
            lblName.Location = new Point(24, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 24);
            lblName.TabIndex = 1;
            lblName.Text = "Kullanıcı Adı *";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.Location = new Point(197, 40);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1083, 660);
            pnlMain.TabIndex = 2;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 700);
            ControlBox = false;
            Controls.Add(pnlMain);
            Controls.Add(pnlSide);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlSide;
        private Button btnBrand;
        private Button btnExit;
        private Button btnReports;
        private Button btnRecords;
        private Button btnCategory;
        private Button btnProduct;
        private Button btnPos;
        private Button btnDashboard;
        private Label label1;
        private Label lblName;
        private PictureBox pictureBox1;
        private Button btnSupplier;
        public Panel pnlMain;
        private Button btnWarehouse;
        public Button btnStockIn;
        private Button btnSettings;
        private Button btnUpdate;
    }
}