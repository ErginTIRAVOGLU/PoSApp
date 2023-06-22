namespace PoSApp.Desktop.Forms.UpdateForms
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
            btnControl = new Button();
            updateBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 155);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Yüklü Version : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 185);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Son Version : ";
            // 
            // lblSonVersion
            // 
            lblSonVersion.AutoSize = true;
            lblSonVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSonVersion.Location = new Point(157, 185);
            lblSonVersion.Name = "lblSonVersion";
            lblSonVersion.Size = new Size(16, 15);
            lblSonVersion.TabIndex = 3;
            lblSonVersion.Text = "...";
            // 
            // lblYukluVersion
            // 
            lblYukluVersion.AutoSize = true;
            lblYukluVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblYukluVersion.Location = new Point(157, 155);
            lblYukluVersion.Name = "lblYukluVersion";
            lblYukluVersion.Size = new Size(19, 15);
            lblYukluVersion.TabIndex = 2;
            lblYukluVersion.Text = "... ";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(124, 237);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(12, 59);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(304, 63);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "...";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnControl
            // 
            btnControl.Location = new Point(124, 21);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(85, 44);
            btnControl.TabIndex = 6;
            btnControl.Text = "Güncelleme Kontrol";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            // 
            // updateBar
            // 
            updateBar.Location = new Point(12, 280);
            updateBar.Name = "updateBar";
            updateBar.Size = new Size(321, 23);
            updateBar.TabIndex = 7;
            updateBar.Visible = false;
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 315);
            Controls.Add(updateBar);
            Controls.Add(btnControl);
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
        private Button btnControl;
        private ProgressBar updateBar;
    }
}