namespace PoSApp.Desktop.Forms.StockInForms
{
    partial class frmStockInList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInList));
            dGWStockIn = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StockInRefNo = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            StockInDate = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            label1 = new Label();
            pbAdd = new PictureBox();
            pBClose = new PictureBox();
            splitContainer1 = new SplitContainer();
            btnFiltre = new Button();
            dTPEndDate = new DateTimePicker();
            dTPBeginDate = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGWStockIn).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dGWStockIn
            // 
            dGWStockIn.AllowUserToAddRows = false;
            dGWStockIn.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dGWStockIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGWStockIn.BackgroundColor = Color.White;
            dGWStockIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dGWStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dGWStockIn.ColumnHeadersHeight = 30;
            dGWStockIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWStockIn.Columns.AddRange(new DataGridViewColumn[] { Id, StockInRefNo, SupplierName, StockInDate, Edit, Delete });
            dGWStockIn.Dock = DockStyle.Fill;
            dGWStockIn.EnableHeadersVisualStyles = false;
            dGWStockIn.Location = new Point(0, 0);
            dGWStockIn.Name = "dGWStockIn";
            dGWStockIn.RowHeadersVisible = false;
            dGWStockIn.RowTemplate.Height = 25;
            dGWStockIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWStockIn.Size = new Size(800, 421);
            dGWStockIn.TabIndex = 7;
            dGWStockIn.CellContentClick += dGWStockIn_CellContentClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "#";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // StockInRefNo
            // 
            StockInRefNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockInRefNo.DataPropertyName = "StockInRefNo";
            StockInRefNo.HeaderText = "REF CODE";
            StockInRefNo.Name = "StockInRefNo";
            // 
            // SupplierName
            // 
            SupplierName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "TEDARİKÇİ";
            SupplierName.Name = "SupplierName";
            // 
            // StockInDate
            // 
            StockInDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockInDate.DataPropertyName = "StockInDate";
            StockInDate.HeaderText = "TARİH";
            StockInDate.Name = "StockInDate";
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
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 3;
            label1.Text = "Ürün Girişi Listesi";
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 40);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnFiltre);
            splitContainer1.Panel1.Controls.Add(dTPEndDate);
            splitContainer1.Panel1.Controls.Add(dTPBeginDate);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dGWStockIn);
            splitContainer1.Size = new Size(800, 470);
            splitContainer1.SplitterDistance = 45;
            splitContainer1.TabIndex = 8;
            // 
            // btnFiltre
            // 
            btnFiltre.Location = new Point(520, 6);
            btnFiltre.Name = "btnFiltre";
            btnFiltre.Size = new Size(75, 28);
            btnFiltre.TabIndex = 3;
            btnFiltre.Text = "Yükle";
            btnFiltre.UseVisualStyleBackColor = true;
            btnFiltre.Click += btnFiltre_Click;
            // 
            // dTPEndDate
            // 
            dTPEndDate.Location = new Point(314, 8);
            dTPEndDate.Name = "dTPEndDate";
            dTPEndDate.Size = new Size(200, 25);
            dTPEndDate.TabIndex = 2;
            // 
            // dTPBeginDate
            // 
            dTPBeginDate.Location = new Point(108, 8);
            dTPBeginDate.Name = "dTPBeginDate";
            dTPBeginDate.Size = new Size(200, 25);
            dTPBeginDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 14);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 0;
            label2.Text = "Tarih Aralığı : ";
            // 
            // frmStockInList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStockInList";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dGWStockIn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGWStockIn;
        private Panel panel1;
        private Label label1;
        private PictureBox pbAdd;
        private PictureBox pBClose;
        private SplitContainer splitContainer1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StockInRefNo;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn StockInDate;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Button btnFiltre;
        private DateTimePicker dTPEndDate;
        private DateTimePicker dTPBeginDate;
        private Label label2;
    }
}