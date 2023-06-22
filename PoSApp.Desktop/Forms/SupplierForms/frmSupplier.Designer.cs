namespace PoSApp.Desktop.Forms.SupplierForms
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtSupplier = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pBClose = new PictureBox();
            label1 = new Label();
            txtPhone1 = new TextBox();
            label3 = new Label();
            txtPhone2 = new TextBox();
            label4 = new Label();
            txtAddress1 = new TextBox();
            label5 = new Label();
            txtAddress2 = new TextBox();
            label6 = new Label();
            txtTaxNumber = new TextBox();
            label7 = new Label();
            txtTaxAdministrator = new TextBox();
            label8 = new Label();
            txtManager = new TextBox();
            label9 = new Label();
            txtNote = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(260, 460);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 41);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(179, 460);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 41);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(98, 460);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 41);
            btnSave.TabIndex = 15;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(99, 62);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(337, 25);
            txtSupplier.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 65);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 13;
            label2.Text = "Tedarikçi Adı :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(pBClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 45);
            panel1.TabIndex = 18;
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(450, 9);
            pBClose.Name = "pBClose";
            pBClose.Size = new Size(24, 27);
            pBClose.TabIndex = 1;
            pBClose.TabStop = false;
            pBClose.Click += pBClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 0;
            label1.Text = "Tedarikçi";
            // 
            // txtPhone1
            // 
            txtPhone1.Location = new Point(99, 155);
            txtPhone1.Name = "txtPhone1";
            txtPhone1.Size = new Size(125, 25);
            txtPhone1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 158);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 19;
            label3.Text = "Telefon 1 :";
            // 
            // txtPhone2
            // 
            txtPhone2.Location = new Point(311, 155);
            txtPhone2.Name = "txtPhone2";
            txtPhone2.Size = new Size(125, 25);
            txtPhone2.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 158);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 21;
            label4.Text = "Telefon 2 :";
            // 
            // txtAddress1
            // 
            txtAddress1.Location = new Point(99, 186);
            txtAddress1.Multiline = true;
            txtAddress1.Name = "txtAddress1";
            txtAddress1.Size = new Size(337, 83);
            txtAddress1.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 189);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 23;
            label5.Text = "Adres 1 :";
            // 
            // txtAddress2
            // 
            txtAddress2.Location = new Point(99, 275);
            txtAddress2.Multiline = true;
            txtAddress2.Name = "txtAddress2";
            txtAddress2.Size = new Size(337, 83);
            txtAddress2.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 278);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 25;
            label6.Text = "Adres 2 :";
            // 
            // txtTaxNumber
            // 
            txtTaxNumber.Location = new Point(323, 93);
            txtTaxNumber.Name = "txtTaxNumber";
            txtTaxNumber.Size = new Size(113, 25);
            txtTaxNumber.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 96);
            label7.Name = "label7";
            label7.Size = new Size(86, 17);
            label7.TabIndex = 29;
            label7.Text = "V. Numarası :";
            // 
            // txtTaxAdministrator
            // 
            txtTaxAdministrator.Location = new Point(99, 93);
            txtTaxAdministrator.Name = "txtTaxAdministrator";
            txtTaxAdministrator.Size = new Size(113, 25);
            txtTaxAdministrator.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 96);
            label8.Name = "label8";
            label8.Size = new Size(70, 17);
            label8.TabIndex = 27;
            label8.Text = "V. Dairesi :";
            // 
            // txtManager
            // 
            txtManager.Location = new Point(99, 124);
            txtManager.Name = "txtManager";
            txtManager.Size = new Size(206, 25);
            txtManager.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 127);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 31;
            label9.Text = "Sorumlu Kişi :";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(99, 364);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(337, 83);
            txtNote.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(56, 367);
            label10.Name = "label10";
            label10.Size = new Size(37, 17);
            label10.TabIndex = 33;
            label10.Text = "Not :";
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 522);
            Controls.Add(txtNote);
            Controls.Add(label10);
            Controls.Add(txtManager);
            Controls.Add(label9);
            Controls.Add(txtTaxNumber);
            Controls.Add(label7);
            Controls.Add(txtTaxAdministrator);
            Controls.Add(label8);
            Controls.Add(txtAddress2);
            Controls.Add(label6);
            Controls.Add(txtAddress1);
            Controls.Add(label5);
            Controls.Add(txtPhone2);
            Controls.Add(label4);
            Controls.Add(txtPhone1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtSupplier);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "1";
            Load += frmSupplier_Load;
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
        public TextBox txtSupplier;
        private Label label2;
        private Panel panel1;
        private PictureBox pBClose;
        private Label label1;
        public TextBox txtPhone1;
        private Label label3;
        public TextBox txtPhone2;
        private Label label4;
        public TextBox txtAddress1;
        private Label label5;
        public TextBox txtAddress2;
        private Label label6;
        public TextBox txtTaxNumber;
        private Label label7;
        public TextBox txtTaxAdministrator;
        private Label label8;
        public TextBox txtManager;
        private Label label9;
        public TextBox txtNote;
        private Label label10;
    }
}