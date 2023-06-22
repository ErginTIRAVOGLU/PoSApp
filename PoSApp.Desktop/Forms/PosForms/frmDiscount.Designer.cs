namespace PoSApp.Desktop.Forms.PosForms
{
    partial class frmDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscount));
            btnCancel = new Button();
            btnSave = new Button();
            txtPrice = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pBClose = new PictureBox();
            label1 = new Label();
            txtPercentage = new TextBox();
            label3 = new Label();
            txtTotalDiscount = new TextBox();
            label4 = new Label();
            txtListPrice = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(248, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 36);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(110, 189);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 10;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(137, 84);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(186, 23);
            txtPrice.TabIndex = 9;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.KeyUp += txtPrice_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 87);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "Fiyat :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(pBClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 40);
            panel1.TabIndex = 7;
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(336, 6);
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
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün İndirim";
            // 
            // txtPercentage
            // 
            txtPercentage.Location = new Point(137, 113);
            txtPercentage.Name = "txtPercentage";
            txtPercentage.Size = new Size(186, 23);
            txtPercentage.TabIndex = 14;
            txtPercentage.TextChanged += txtPercentage_TextChanged;
            txtPercentage.KeyUp += txtPercentage_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 116);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 13;
            label3.Text = "İndirim (%) :";
            // 
            // txtTotalDiscount
            // 
            txtTotalDiscount.Location = new Point(137, 142);
            txtTotalDiscount.Name = "txtTotalDiscount";
            txtTotalDiscount.Size = new Size(186, 23);
            txtTotalDiscount.TabIndex = 16;
            txtTotalDiscount.TextChanged += txtTotalDiscount_TextChanged;
            txtTotalDiscount.KeyUp += txtTotalDiscount_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 145);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 15;
            label4.Text = "İndirim Tutarı :";
            // 
            // txtListPrice
            // 
            txtListPrice.Location = new Point(137, 55);
            txtListPrice.Name = "txtListPrice";
            txtListPrice.Size = new Size(186, 23);
            txtListPrice.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 58);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 17;
            label5.Text = "Liste Fiyatı :";
            // 
            // frmDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 262);
            Controls.Add(txtListPrice);
            Controls.Add(label5);
            Controls.Add(txtTotalDiscount);
            Controls.Add(label4);
            Controls.Add(txtPercentage);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDiscount";
            Text = "frmDiscount";
            Load += frmDiscount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        public TextBox txtPrice;
        private Label label2;
        private Panel panel1;
        private PictureBox pBClose;
        private Label label1;
        public TextBox txtPercentage;
        private Label label3;
        public TextBox txtTotalDiscount;
        private Label label4;
        public TextBox txtListPrice;
        private Label label5;
    }
}