namespace PoSApp.Desktop.Forms.PosForms
{
    partial class frmPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlSide = new Panel();
            btnLockTheButtons = new Button();
            btnExit = new Button();
            btnUnLockTheButtons = new Button();
            btnSales = new Button();
            btnCancel = new Button();
            btnSettle = new Button();
            btnDiscount = new Button();
            btnProductList = new Button();
            btnNew = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnPrint = new Button();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            lblPayedAmount = new Label();
            label4 = new Label();
            lblTotal = new Label();
            label14 = new Label();
            lblVAT = new Label();
            label12 = new Label();
            lblDiscount = new Label();
            label10 = new Label();
            lblSubTotal = new Label();
            label7 = new Label();
            panel3 = new Panel();
            lblDisplayTotal = new Label();
            panel4 = new Panel();
            dTPickerCart = new DateTimePicker();
            btnYukle = new Button();
            txtTransNo = new TextBox();
            txtProductSearch = new TextBox();
            pictureBox2 = new PictureBox();
            label15 = new Label();
            lblDate = new Label();
            label5 = new Label();
            label2 = new Label();
            dGWCartDetail = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            CartDetailUnitType = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Vat = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            pnlSide.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWCartDetail).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(37, 37, 38);
            pnlSide.Controls.Add(btnLockTheButtons);
            pnlSide.Controls.Add(btnExit);
            pnlSide.Controls.Add(btnUnLockTheButtons);
            pnlSide.Controls.Add(btnSales);
            pnlSide.Controls.Add(btnCancel);
            pnlSide.Controls.Add(btnSettle);
            pnlSide.Controls.Add(btnDiscount);
            pnlSide.Controls.Add(btnProductList);
            pnlSide.Controls.Add(btnNew);
            pnlSide.Controls.Add(panel1);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(207, 700);
            pnlSide.TabIndex = 0;
            // 
            // btnLockTheButtons
            // 
            btnLockTheButtons.Location = new Point(143, 631);
            btnLockTheButtons.Name = "btnLockTheButtons";
            btnLockTheButtons.Size = new Size(50, 28);
            btnLockTheButtons.TabIndex = 11;
            btnLockTheButtons.Text = "Kapat";
            btnLockTheButtons.UseVisualStyleBackColor = true;
            btnLockTheButtons.Click += btnLockTheButtons_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 666);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 10, 0);
            btnExit.Size = new Size(207, 34);
            btnExit.TabIndex = 11;
            btnExit.Text = "  [ESC] Çıkış";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUnLockTheButtons
            // 
            btnUnLockTheButtons.Location = new Point(99, 631);
            btnUnLockTheButtons.Name = "btnUnLockTheButtons";
            btnUnLockTheButtons.Size = new Size(38, 28);
            btnUnLockTheButtons.TabIndex = 10;
            btnUnLockTheButtons.Text = "Aç";
            btnUnLockTheButtons.UseVisualStyleBackColor = true;
            btnUnLockTheButtons.Click += btnUnLockTheButtons_Click;
            // 
            // btnSales
            // 
            btnSales.Cursor = Cursors.Hand;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.ForeColor = Color.White;
            btnSales.Image = (Image)resources.GetObject("btnSales.Image");
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 387);
            btnSales.Name = "btnSales";
            btnSales.Padding = new Padding(10, 0, 10, 0);
            btnSales.Size = new Size(207, 34);
            btnSales.TabIndex = 9;
            btnSales.Text = "  [F6] Günlük Satışlar";
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(0, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(10, 0, 10, 0);
            btnCancel.Size = new Size(207, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "  [F5] Satışı İptal Et";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSettle
            // 
            btnSettle.Cursor = Cursors.Hand;
            btnSettle.FlatAppearance.BorderSize = 0;
            btnSettle.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnSettle.FlatStyle = FlatStyle.Flat;
            btnSettle.ForeColor = Color.White;
            btnSettle.Image = (Image)resources.GetObject("btnSettle.Image");
            btnSettle.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettle.Location = new Point(0, 311);
            btnSettle.Name = "btnSettle";
            btnSettle.Padding = new Padding(10, 0, 10, 0);
            btnSettle.Size = new Size(207, 34);
            btnSettle.TabIndex = 7;
            btnSettle.Text = "  [F4] Ödeme Al";
            btnSettle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettle.UseVisualStyleBackColor = true;
            btnSettle.Click += btnSettle_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Cursor = Cursors.Hand;
            btnDiscount.FlatAppearance.BorderSize = 0;
            btnDiscount.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.ForeColor = Color.White;
            btnDiscount.Image = (Image)resources.GetObject("btnDiscount.Image");
            btnDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiscount.Location = new Point(0, 273);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Padding = new Padding(10, 0, 10, 0);
            btnDiscount.Size = new Size(207, 34);
            btnDiscount.TabIndex = 6;
            btnDiscount.Text = "  [F3] İndirim Ekle";
            btnDiscount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnProductList
            // 
            btnProductList.Cursor = Cursors.Hand;
            btnProductList.FlatAppearance.BorderSize = 0;
            btnProductList.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnProductList.FlatStyle = FlatStyle.Flat;
            btnProductList.ForeColor = Color.White;
            btnProductList.Image = (Image)resources.GetObject("btnProductList.Image");
            btnProductList.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductList.Location = new Point(0, 235);
            btnProductList.Name = "btnProductList";
            btnProductList.Padding = new Padding(10, 0, 10, 0);
            btnProductList.Size = new Size(207, 34);
            btnProductList.TabIndex = 5;
            btnProductList.Text = "  [F2] Ürün Listesi";
            btnProductList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductList.UseVisualStyleBackColor = true;
            btnProductList.Click += btnProductList_Click;
            // 
            // btnNew
            // 
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = Color.White;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(0, 197);
            btnNew.Name = "btnNew";
            btnNew.Padding = new Padding(10, 0, 10, 0);
            btnNew.Size = new Size(207, 34);
            btnNew.TabIndex = 4;
            btnNew.Text = "  [F1] Yeni Satış";
            btnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 190);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 132);
            label1.Name = "label1";
            label1.Size = new Size(150, 24);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı *";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(25, 118, 210);
            lblName.Location = new Point(24, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 24);
            lblName.TabIndex = 4;
            lblName.Text = "POS Yazılımı *";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 37, 38);
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(967, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 700);
            panel2.TabIndex = 3;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.FromArgb(25, 118, 210);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.Location = new Point(126, 288);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(62, 83);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "Yazdır";
            btnPrint.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 442);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(310, 258);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.Controls.Add(lblPayedAmount);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(lblTotal);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(lblVAT);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(lblDiscount);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(lblSubTotal);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(313, 157);
            panel5.TabIndex = 6;
            // 
            // lblPayedAmount
            // 
            lblPayedAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPayedAmount.Location = new Point(211, 128);
            lblPayedAmount.Name = "lblPayedAmount";
            lblPayedAmount.Size = new Size(99, 21);
            lblPayedAmount.TabIndex = 9;
            lblPayedAmount.Text = "0.00";
            lblPayedAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 128);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 8;
            label4.Text = "Ödenen Para : ";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(211, 84);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(99, 21);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(3, 84);
            label14.Name = "label14";
            label14.Size = new Size(71, 21);
            label14.TabIndex = 6;
            label14.Text = "Toplam : ";
            // 
            // lblVAT
            // 
            lblVAT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVAT.Location = new Point(211, 57);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(99, 21);
            lblVAT.TabIndex = 5;
            lblVAT.Text = "0.00";
            lblVAT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 57);
            label12.Name = "label12";
            label12.Size = new Size(51, 21);
            label12.TabIndex = 4;
            label12.Text = "KDV : ";
            // 
            // lblDiscount
            // 
            lblDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscount.Location = new Point(211, 30);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(99, 21);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 30);
            label10.Name = "label10";
            label10.Size = new Size(67, 21);
            label10.TabIndex = 2;
            label10.Text = "İndirim :";
            // 
            // lblSubTotal
            // 
            lblSubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(211, 3);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(99, 21);
            lblSubTotal.TabIndex = 1;
            lblSubTotal.Text = "0.00";
            lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 0;
            label7.Text = "Ara Toplam : ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 37, 38);
            panel3.Controls.Add(lblDisplayTotal);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 83);
            panel3.TabIndex = 5;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.Dock = DockStyle.Fill;
            lblDisplayTotal.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayTotal.ForeColor = Color.White;
            lblDisplayTotal.Location = new Point(0, 0);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(313, 83);
            lblDisplayTotal.TabIndex = 0;
            lblDisplayTotal.Text = "0.00";
            lblDisplayTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dTPickerCart);
            panel4.Controls.Add(btnYukle);
            panel4.Controls.Add(txtTransNo);
            panel4.Controls.Add(txtProductSearch);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(lblDate);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(207, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(760, 102);
            panel4.TabIndex = 4;
            // 
            // dTPickerCart
            // 
            dTPickerCart.Location = new Point(462, 41);
            dTPickerCart.Name = "dTPickerCart";
            dTPickerCart.Size = new Size(200, 25);
            dTPickerCart.TabIndex = 9;
            dTPickerCart.ValueChanged += dTPickerCart_ValueChanged;
            // 
            // btnYukle
            // 
            btnYukle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnYukle.ForeColor = Color.FromArgb(25, 118, 210);
            btnYukle.Image = (Image)resources.GetObject("btnYukle.Image");
            btnYukle.ImageAlign = ContentAlignment.MiddleLeft;
            btnYukle.Location = new Point(281, 13);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(61, 26);
            btnYukle.TabIndex = 8;
            btnYukle.Text = "Yükle";
            btnYukle.TextAlign = ContentAlignment.MiddleRight;
            btnYukle.UseVisualStyleBackColor = false;
            btnYukle.Click += btnYukle_Click;
            // 
            // txtTransNo
            // 
            txtTransNo.Location = new Point(131, 13);
            txtTransNo.Name = "txtTransNo";
            txtTransNo.Size = new Size(144, 25);
            txtTransNo.TabIndex = 1;
            // 
            // txtProductSearch
            // 
            txtProductSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductSearch.Enabled = false;
            txtProductSearch.Location = new Point(131, 71);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.PlaceholderText = "Ürün Ara";
            txtProductSearch.Size = new Size(531, 25);
            txtProductSearch.TabIndex = 2;
            txtProductSearch.KeyDown += txtProductSearch_KeyDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(32, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 25);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(62, 74);
            label15.Name = "label15";
            label15.Size = new Size(63, 17);
            label15.TabIndex = 4;
            label15.Text = "Barcode :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(131, 47);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(78, 17);
            lblDate.TabIndex = 3;
            lblDate.Text = "0000000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 47);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 2;
            label5.Text = "Tarih :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 21);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 0;
            label2.Text = "Transaction No :";
            // 
            // dGWCartDetail
            // 
            dGWCartDetail.AllowUserToAddRows = false;
            dGWCartDetail.AllowUserToDeleteRows = false;
            dGWCartDetail.AllowUserToOrderColumns = true;
            dGWCartDetail.AllowUserToResizeRows = false;
            dGWCartDetail.BackgroundColor = Color.White;
            dGWCartDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGWCartDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGWCartDetail.ColumnHeadersHeight = 30;
            dGWCartDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWCartDetail.Columns.AddRange(new DataGridViewColumn[] { Id, ProductId, Description, Quantity, CartDetailUnitType, Discount, Price, Vat, Total, Delete });
            dGWCartDetail.EditMode = DataGridViewEditMode.EditOnF2;
            dGWCartDetail.EnableHeadersVisualStyles = false;
            dGWCartDetail.Location = new Point(213, 108);
            dGWCartDetail.MultiSelect = false;
            dGWCartDetail.Name = "dGWCartDetail";
            dGWCartDetail.RowHeadersVisible = false;
            dGWCartDetail.RowTemplate.Height = 25;
            dGWCartDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWCartDetail.Size = new Size(748, 551);
            dGWCartDetail.TabIndex = 5;
            dGWCartDetail.CellContentClick += dGWCartDetail_CellContentClick;
            dGWCartDetail.CellFormatting += dGWCartDetail_CellFormatting;
            dGWCartDetail.KeyUp += dGWCartDetail_KeyUp;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "#";
            Id.Name = "Id";
            Id.Width = 39;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Ürün Adı";
            Description.Name = "Description";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Adet";
            Quantity.Name = "Quantity";
            Quantity.Width = 58;
            // 
            // CartDetailUnitType
            // 
            CartDetailUnitType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CartDetailUnitType.DataPropertyName = "CartDetailUnitType";
            CartDetailUnitType.HeaderText = "Tip";
            CartDetailUnitType.Name = "CartDetailUnitType";
            CartDetailUnitType.Width = 49;
            // 
            // Discount
            // 
            Discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Discount.DataPropertyName = "Discount";
            Discount.HeaderText = "İndirim";
            Discount.Name = "Discount";
            Discount.Width = 71;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Fiyat";
            Price.Name = "Price";
            Price.Width = 57;
            // 
            // Vat
            // 
            Vat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Vat.DataPropertyName = "Vat";
            Vat.HeaderText = "Kdv";
            Vat.Name = "Vat";
            Vat.Width = 53;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Toplam";
            Total.Name = "Total";
            Total.Width = 74;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 700);
            Controls.Add(dGWCartDetail);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(pnlSide);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPos";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmPos_Load;
            pnlSide.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWCartDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Panel panel1;
        private Button btnExit;
        private Button btnSales;
        private Button btnCancel;
        private Button btnSettle;
        private Button btnDiscount;
        private Button btnProductList;
        private Button btnNew;
        private Label label1;
        private Label lblName;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblDate;
        private Label label5;
        private Label label2;
        private Panel panel5;
        private Label lblDisplayTotal;
        private DataGridView dGWCartDetail;
        private Label lblTotal;
        private Label label14;
        private Label lblVAT;
        private Label label12;
        private Label lblDiscount;
        private Label label10;
        private Label lblSubTotal;
        private Label label7;
        private Label label15;
        public TextBox txtProductSearch;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblPayedAmount;
        private Label label4;
        public TextBox txtTransNo;
        private RadioButton btnCash;
        private Button btnPrint;
        private DateTimePicker dTPickerCart;
        private Button btnYukle;
        private Button btnLockTheButtons;
        private Button btnUnLockTheButtons;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn CartDetailUnitType;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Vat;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewImageColumn Delete;
    }
}