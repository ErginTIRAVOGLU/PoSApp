namespace PoSApp.Desktop.Forms.WarehouseForms
{
    partial class frmWarehouseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouseList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pbAdd = new PictureBox();
            pBClose = new PictureBox();
            dGWWarehouse = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            WarehouseName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWWarehouse).BeginInit();
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
            label1.Size = new Size(94, 21);
            label1.TabIndex = 3;
            label1.Text = "Depo Listesi";
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
            // dGWWarehouse
            // 
            dGWWarehouse.AllowUserToAddRows = false;
            dGWWarehouse.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dGWWarehouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGWWarehouse.BackgroundColor = Color.White;
            dGWWarehouse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dGWWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dGWWarehouse.ColumnHeadersHeight = 30;
            dGWWarehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWWarehouse.Columns.AddRange(new DataGridViewColumn[] { Id, WarehouseName, Edit, Delete });
            dGWWarehouse.Dock = DockStyle.Fill;
            dGWWarehouse.EnableHeadersVisualStyles = false;
            dGWWarehouse.Location = new Point(0, 40);
            dGWWarehouse.Name = "dGWWarehouse";
            dGWWarehouse.RowHeadersVisible = false;
            dGWWarehouse.RowTemplate.Height = 25;
            dGWWarehouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWWarehouse.Size = new Size(800, 470);
            dGWWarehouse.TabIndex = 4;
            dGWWarehouse.CellContentClick += dGWWarehouse_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "#";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // WarehouseName
            // 
            WarehouseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WarehouseName.DataPropertyName = "WarehouseName";
            WarehouseName.HeaderText = "Depo";
            WarehouseName.Name = "WarehouseName";
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
            // frmWarehouseList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(dGWWarehouse);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmWarehouseList";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWWarehouse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pbAdd;
        private PictureBox pBClose;
        private DataGridView dGWWarehouse;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn WarehouseName;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}