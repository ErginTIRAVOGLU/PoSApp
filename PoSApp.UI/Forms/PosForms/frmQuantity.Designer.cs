namespace PoSApp.UI.Forms.PosForms
{
    partial class frmQuantity
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
            txtQuantity = new TextBox();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Font = new Font("Consolas", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(12, 12);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(151, 57);
            txtQuantity.TabIndex = 0;
            txtQuantity.Text = "1";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            // 
            // frmQuantity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(176, 85);
            Controls.Add(txtQuantity);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmQuantity";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adet";
            TopMost = true;
            Load += frmQuantity_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuantity;
    }
}