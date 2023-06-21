namespace PoSApp.UI.Forms.SupplierForms
{
    partial class frmSupplierList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pbAdd = new PictureBox();
            pBClose = new PictureBox();
            dGWSupplier = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Address1 = new DataGridViewTextBoxColumn();
            Address2 = new DataGridViewTextBoxColumn();
            Phone1 = new DataGridViewTextBoxColumn();
            Phone2 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWSupplier).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 3;
            label1.Text = "Tedarikçi Listesi";
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
            // dGWSupplier
            // 
            dGWSupplier.AllowUserToAddRows = false;
            dGWSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dGWSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGWSupplier.BackgroundColor = Color.White;
            dGWSupplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dGWSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dGWSupplier.ColumnHeadersHeight = 30;
            dGWSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWSupplier.Columns.AddRange(new DataGridViewColumn[] { Column1, Id, SupplierName, Address1, Address2, Phone1, Phone2, Edit, Delete });
            dGWSupplier.Dock = DockStyle.Fill;
            dGWSupplier.EnableHeadersVisualStyles = false;
            dGWSupplier.Location = new Point(0, 40);
            dGWSupplier.Name = "dGWSupplier";
            dGWSupplier.RowHeadersVisible = false;
            dGWSupplier.RowTemplate.Height = 25;
            dGWSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWSupplier.Size = new Size(800, 470);
            dGWSupplier.TabIndex = 4;
            dGWSupplier.CellContentClick += dGWSupplier_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // SupplierName
            // 
            SupplierName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "TEDARİKÇİ";
            SupplierName.Name = "SupplierName";
            // 
            // Address1
            // 
            Address1.DataPropertyName = "SupplierAddress1";
            Address1.HeaderText = "ADRES1";
            Address1.Name = "Address1";
            // 
            // Address2
            // 
            Address2.DataPropertyName = "SupplierAddress2";
            Address2.HeaderText = "ADRES2";
            Address2.Name = "Address2";
            // 
            // Phone1
            // 
            Phone1.DataPropertyName = "SupplierPhone1";
            Phone1.HeaderText = "TELEFON1";
            Phone1.Name = "Phone1";
            // 
            // Phone2
            // 
            Phone2.DataPropertyName = "SupplierPhone2";
            Phone2.HeaderText = "TELEFON2";
            Phone2.Name = "Phone2";
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
            // frmSupplierList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(dGWSupplier);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSupplierList";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pbAdd;
        private PictureBox pBClose;
        private DataGridView dGWSupplier;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Address1;
        private DataGridViewTextBoxColumn Address2;
        private DataGridViewTextBoxColumn Phone1;
        private DataGridViewTextBoxColumn Phone2;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}