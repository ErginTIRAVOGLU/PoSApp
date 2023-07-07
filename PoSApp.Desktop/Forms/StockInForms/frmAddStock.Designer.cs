namespace PoSApp.Desktop.Forms.StockInForms
{
    partial class frmAddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStock));
            txtCount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmBoxWarehouse = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            pBClose = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            SuspendLayout();
            // 
            // txtCount
            // 
            txtCount.Location = new Point(95, 81);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(146, 23);
            txtCount.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 84);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 15;
            label2.Text = "Adet / Gram :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 55);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 18;
            label3.Text = "Depo :";
            // 
            // cmBoxWarehouse
            // 
            cmBoxWarehouse.FormattingEnabled = true;
            cmBoxWarehouse.Location = new Point(95, 52);
            cmBoxWarehouse.Name = "cmBoxWarehouse";
            cmBoxWarehouse.Size = new Size(146, 23);
            cmBoxWarehouse.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(328, 168);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 36);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(166, 168);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 19;
            btnSave.Text = "Ekle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(247, 168);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 36);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(pBClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 40);
            panel1.TabIndex = 22;
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(478, 6);
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
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün Girişi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 55);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 23;
            label4.Text = "Geliş Fiyatı :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 84);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 25;
            label5.Text = "İskonto :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(344, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 23);
            textBox3.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 113);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 27;
            label6.Text = "Son Fiyat :";
            // 
            // frmAddStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 218);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(cmBoxWarehouse);
            Controls.Add(txtCount);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddStock";
            Load += frmAddStock_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtCount;
        private Label label2;
        private Label label3;
        public ComboBox cmBoxWarehouse;
        private Button btnCancel;
        private Button btnSave;
        private Button btnUpdate;
        private Panel panel1;
        private PictureBox pBClose;
        private Label label1;
        public TextBox textBox1;
        private Label label4;
        public TextBox textBox2;
        private Label label5;
        public TextBox textBox3;
        private Label label6;
    }
}