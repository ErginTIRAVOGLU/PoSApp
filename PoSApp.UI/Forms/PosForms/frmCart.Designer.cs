namespace PoSApp.UI.Forms.PosForms
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            dGWCart = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CartRefNo = new DataGridViewTextBoxColumn();
            CartPrice = new DataGridViewTextBoxColumn();
            CartDiscount = new DataGridViewTextBoxColumn();
            CartVat = new DataGridViewTextBoxColumn();
            CartPriceTotal = new DataGridViewTextBoxColumn();
            CartStatusType = new DataGridViewTextBoxColumn();
            CartDate = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            label1 = new Label();
            pBClose = new PictureBox();
            splitContainer1 = new SplitContainer();
            btnFiltre = new Button();
            dTPEndDate = new DateTimePicker();
            dTPBeginDate = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGWCart).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dGWCart
            // 
            dGWCart.AllowUserToAddRows = false;
            dGWCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dGWCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGWCart.BackgroundColor = Color.White;
            dGWCart.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dGWCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dGWCart.ColumnHeadersHeight = 30;
            dGWCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGWCart.Columns.AddRange(new DataGridViewColumn[] { Id, CartRefNo, CartPrice, CartDiscount, CartVat, CartPriceTotal, CartStatusType, CartDate, Edit, Delete });
            dGWCart.Dock = DockStyle.Fill;
            dGWCart.EnableHeadersVisualStyles = false;
            dGWCart.Location = new Point(0, 0);
            dGWCart.Name = "dGWCart";
            dGWCart.RowHeadersVisible = false;
            dGWCart.RowTemplate.Height = 25;
            dGWCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGWCart.Size = new Size(800, 421);
            dGWCart.TabIndex = 7;
            dGWCart.CellContentClick += dGWCart_CellContentClick;
            dGWCart.CellFormatting += dGWCart_CellFormatting;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "#";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // CartRefNo
            // 
            CartRefNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CartRefNo.DataPropertyName = "CartRefNo";
            CartRefNo.HeaderText = "REF CODE";
            CartRefNo.Name = "CartRefNo";
            // 
            // CartPrice
            // 
            CartPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CartPrice.DataPropertyName = "CartPrice";
            CartPrice.HeaderText = "Fiyat";
            CartPrice.Name = "CartPrice";
            CartPrice.Width = 57;
            // 
            // CartDiscount
            // 
            CartDiscount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CartDiscount.DataPropertyName = "CartDiscount";
            CartDiscount.HeaderText = "İndirim";
            CartDiscount.Name = "CartDiscount";
            CartDiscount.Width = 71;
            // 
            // CartVat
            // 
            CartVat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CartVat.DataPropertyName = "CartVat";
            CartVat.HeaderText = "Kdv";
            CartVat.Name = "CartVat";
            CartVat.Width = 53;
            // 
            // CartPriceTotal
            // 
            CartPriceTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CartPriceTotal.DataPropertyName = "CartPriceTotal";
            CartPriceTotal.HeaderText = "Toplam Fiyat";
            CartPriceTotal.Name = "CartPriceTotal";
            CartPriceTotal.Width = 104;
            // 
            // CartStatusType
            // 
            CartStatusType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CartStatusType.DataPropertyName = "CartStatusType";
            CartStatusType.HeaderText = "Durum";
            CartStatusType.Name = "CartStatusType";
            CartStatusType.Width = 70;
            // 
            // CartDate
            // 
            CartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CartDate.DataPropertyName = "CartDate";
            CartDate.HeaderText = "Tarih";
            CartDate.Name = "CartDate";
            CartDate.Width = 59;
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
            label1.Size = new Size(144, 21);
            label1.TabIndex = 3;
            label1.Text = "Günlük Satış Listesi";
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dGWCart);
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
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCart";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dGWCart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBClose).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGWCart;
        private Panel panel1;
        private Label label1;
        private PictureBox pBClose;
        private SplitContainer splitContainer1;
        private Button btnFiltre;
        private DateTimePicker dTPEndDate;
        private DateTimePicker dTPBeginDate;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CartRefNo;
        private DataGridViewTextBoxColumn CartPrice;
        private DataGridViewTextBoxColumn CartDiscount;
        private DataGridViewTextBoxColumn CartVat;
        private DataGridViewTextBoxColumn CartPriceTotal;
        private DataGridViewTextBoxColumn CartStatus;
        private DataGridViewTextBoxColumn CartDate;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn CartStatusType;
    }
}