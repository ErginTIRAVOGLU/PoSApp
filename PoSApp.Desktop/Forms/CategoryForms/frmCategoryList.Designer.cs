

namespace PoSApp.Desktop.Forms.CategoryForms
{
    partial class frmCategoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pbAdd = new PictureBox();
            pBClose = new PictureBox();
            dGWCategory = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWCategory).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 3;
            label1.Text = "Kategori Listesi";
            // 
            // pbAdd
            // 
            pbAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbAdd.BackgroundImage = (Image)resources.GetObject("pbAdd.BackgroundImage");
            pbAdd.BackgroundImageLayout = ImageLayout.Center;
            pbAdd.Cursor = Cursors.Hand;
            pbAdd.Location = new Point(745, 8);
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
            pBClose.Location = new Point(772, 8);
            pBClose.Name = "pBClose";
            pBClose.Size = new Size(24, 24);
            pBClose.TabIndex = 0;
            pBClose.TabStop = false;
            pBClose.Click += pBClose_Click;
            // 
            // dGWCategory
            // 
            dGWCategory.AllowUserToAddRows = false;
            dGWCategory.AllowUserToResizeRows = false;
            dGWCategory.BackgroundColor = Color.White;
            dGWCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGWCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGWCategory.ColumnHeadersHeight = 30;
            dGWCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWCategory.Columns.AddRange(new DataGridViewColumn[] { Column1, Id, CategoryName, Edit, Delete });
            dGWCategory.Dock = DockStyle.Fill;
            dGWCategory.EnableHeadersVisualStyles = false;
            dGWCategory.Location = new Point(0, 40);
            dGWCategory.Name = "dGWCategory";
            dGWCategory.RowHeadersVisible = false;
            dGWCategory.RowTemplate.Height = 25;
            dGWCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWCategory.Size = new Size(800, 470);
            dGWCategory.TabIndex = 3;
            dGWCategory.CellContentClick += dGWCategory_CellContentClick;
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
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "KATEGORİ";
            CategoryName.Name = "CategoryName";
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
            // frmCategoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(dGWCategory);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoryList";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbAdd;
        private PictureBox pBClose;
        private Label label1;
        private DataGridView dGWCategory;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}