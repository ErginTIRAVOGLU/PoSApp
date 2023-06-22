namespace PoSApp.Desktop.Forms.WarehouseForms
{
    partial class frmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtDepo = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pBClose = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(242, 115);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 41);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(161, 115);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 41);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(80, 115);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 41);
            btnSave.TabIndex = 15;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDepo
            // 
            txtDepo.Location = new Point(99, 62);
            txtDepo.Name = "txtDepo";
            txtDepo.Size = new Size(280, 25);
            txtDepo.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 13;
            label2.Text = "Depo Adı :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 118, 210);
            panel1.Controls.Add(pBClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 45);
            panel1.TabIndex = 18;
            // 
            // pBClose
            // 
            pBClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pBClose.BackgroundImage = (Image)resources.GetObject("pBClose.BackgroundImage");
            pBClose.BackgroundImageLayout = ImageLayout.Center;
            pBClose.Cursor = Cursors.Hand;
            pBClose.Location = new Point(361, 10);
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
            label1.Size = new Size(47, 21);
            label1.TabIndex = 0;
            label1.Text = "Depo";
            // 
            // frmWarehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 186);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtDepo);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmWarehouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "1";
            Load += frmWarehouse_Load;
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
        public TextBox txtDepo;
        private Label label2;
        private Panel panel1;
        private PictureBox pBClose;
        private Label label1;
    }
}