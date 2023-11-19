namespace PoSApp.Desktop.Forms.BarcodeForms
{
    partial class frmBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarcode));
            btnCancel = new Button();
            btnSave = new Button();
            txtBarcode = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pBClose = new PictureBox();
            label1 = new Label();
            pBoxBarcode = new PictureBox();
            btnCreate = new Button();
            txtA4Sol = new TextBox();
            label3 = new Label();
            txtA4Ust = new TextBox();
            label4 = new Label();
            chkPdf = new CheckBox();
            chkMasaustu = new CheckBox();
            txtBarcodeHeight = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxBarcode).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(302, 301);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 36);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(203, 301);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 36);
            btnSave.TabIndex = 10;
            btnSave.Text = "Transfer Et";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(110, 173);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(337, 23);
            txtBarcode.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 176);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Barkod No :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(pBClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 40);
            panel1.TabIndex = 7;
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(457, 9);
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
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Barkod";
            // 
            // pBoxBarcode
            // 
            pBoxBarcode.Location = new Point(12, 46);
            pBoxBarcode.Name = "pBoxBarcode";
            pBoxBarcode.Size = new Size(435, 121);
            pBoxBarcode.TabIndex = 13;
            pBoxBarcode.TabStop = false;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(104, 301);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(93, 36);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Oluştur";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtA4Sol
            // 
            txtA4Sol.Location = new Point(110, 202);
            txtA4Sol.Name = "txtA4Sol";
            txtA4Sol.Size = new Size(40, 23);
            txtA4Sol.TabIndex = 16;
            txtA4Sol.Text = "30";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 205);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 15;
            label3.Text = "A4 Sol Boşluk :";
            // 
            // txtA4Ust
            // 
            txtA4Ust.Location = new Point(247, 202);
            txtA4Ust.Name = "txtA4Ust";
            txtA4Ust.Size = new Size(40, 23);
            txtA4Ust.TabIndex = 18;
            txtA4Ust.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 205);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 17;
            label4.Text = "A4 Üst Boşluk :";
            // 
            // chkPdf
            // 
            chkPdf.AutoSize = true;
            chkPdf.Checked = true;
            chkPdf.CheckState = CheckState.Checked;
            chkPdf.Location = new Point(110, 235);
            chkPdf.Name = "chkPdf";
            chkPdf.Size = new Size(86, 19);
            chkPdf.TabIndex = 19;
            chkPdf.Text = "Pdf Oluştur";
            chkPdf.UseVisualStyleBackColor = true;
            // 
            // chkMasaustu
            // 
            chkMasaustu.AutoSize = true;
            chkMasaustu.Location = new Point(110, 260);
            chkMasaustu.Name = "chkMasaustu";
            chkMasaustu.Size = new Size(132, 19);
            chkMasaustu.TabIndex = 20;
            chkMasaustu.Text = "Masaüstü'ne Kaydet";
            chkMasaustu.UseVisualStyleBackColor = true;
            // 
            // txtBarcodeHeight
            // 
            txtBarcodeHeight.Location = new Point(409, 202);
            txtBarcodeHeight.Name = "txtBarcodeHeight";
            txtBarcodeHeight.Size = new Size(40, 23);
            txtBarcodeHeight.TabIndex = 22;
            txtBarcodeHeight.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 205);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 21;
            label5.Text = "Barcode Yükseklik :";
            // 
            // frmBarcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 360);
            Controls.Add(txtBarcodeHeight);
            Controls.Add(label5);
            Controls.Add(chkMasaustu);
            Controls.Add(chkPdf);
            Controls.Add(txtA4Ust);
            Controls.Add(label4);
            Controls.Add(txtA4Sol);
            Controls.Add(label3);
            Controls.Add(btnCreate);
            Controls.Add(pBoxBarcode);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBarcode);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBarcode";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += frmBarcode_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxBarcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        public TextBox txtBarcode;
        private Label label2;
        private Panel panel1;
        private PictureBox pBClose;
        private Label label1;
        private PictureBox pBoxBarcode;
        private Button btnCreate;
        public TextBox txtA4Sol;
        private Label label3;
        public TextBox txtA4Ust;
        private Label label4;
        private CheckBox chkPdf;
        private CheckBox chkMasaustu;
        public TextBox txtBarcodeHeight;
        private Label label5;
    }
}