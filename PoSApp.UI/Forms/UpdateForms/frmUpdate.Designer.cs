namespace PoSApp.UI.Forms.UpdateForms
{
    partial class frmUpdate
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
            label1 = new Label();
            label2 = new Label();
            lblSonVersion = new Label();
            lblYukluVersion = new Label();
            btnUpdate = new Button();
            lblHeader = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 95);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Yüklü Version : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 125);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Son Version : ";
            // 
            // lblSonVersion
            // 
            lblSonVersion.AutoSize = true;
            lblSonVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSonVersion.Location = new Point(159, 125);
            lblSonVersion.Name = "lblSonVersion";
            lblSonVersion.Size = new Size(16, 15);
            lblSonVersion.TabIndex = 3;
            lblSonVersion.Text = "...";
            // 
            // lblYukluVersion
            // 
            lblYukluVersion.AutoSize = true;
            lblYukluVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblYukluVersion.Location = new Point(159, 95);
            lblYukluVersion.Name = "lblYukluVersion";
            lblYukluVersion.Size = new Size(19, 15);
            lblYukluVersion.TabIndex = 2;
            lblYukluVersion.Text = "... ";
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(116, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(137, 53);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(16, 15);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "...";
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(328, 264);
            Controls.Add(lblHeader);
            Controls.Add(btnUpdate);
            Controls.Add(lblSonVersion);
            Controls.Add(lblYukluVersion);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Güncelleme Kontrol";
            Load += frmUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSonVersion;
        private Label lblYukluVersion;
        private Button btnUpdate;
        private Label lblHeader;
    }
}