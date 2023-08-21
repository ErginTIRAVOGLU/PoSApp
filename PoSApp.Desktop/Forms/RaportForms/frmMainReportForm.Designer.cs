namespace PoSApp.Desktop.Forms.RaportForms
{
    partial class frmMainReportForm
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
            btnStockInProductReports = new Button();
            btnCartProductReports = new Button();
            SuspendLayout();
            // 
            // btnStockInProductReports
            // 
            btnStockInProductReports.Location = new Point(12, 12);
            btnStockInProductReports.Name = "btnStockInProductReports";
            btnStockInProductReports.Size = new Size(107, 57);
            btnStockInProductReports.TabIndex = 0;
            btnStockInProductReports.Text = "Ürün Stok Girişi Raporu";
            btnStockInProductReports.UseVisualStyleBackColor = true;
            btnStockInProductReports.Click += btnStockInProductReports_Click;
            // 
            // btnCartProductReports
            // 
            btnCartProductReports.Location = new Point(125, 12);
            btnCartProductReports.Name = "btnCartProductReports";
            btnCartProductReports.Size = new Size(107, 57);
            btnCartProductReports.TabIndex = 1;
            btnCartProductReports.Text = "Ürün Stok Çıkışı Raporu";
            btnCartProductReports.UseVisualStyleBackColor = true;
            btnCartProductReports.Click += btnCartProductReports_Click;
            // 
            // frmMainReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnCartProductReports);
            Controls.Add(btnStockInProductReports);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMainReportForm";
            Text = "frmMainReportForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStockInProductReports;
        private Button btnCartProductReports;
    }
}