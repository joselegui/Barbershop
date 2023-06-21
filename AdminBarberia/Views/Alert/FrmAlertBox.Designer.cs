namespace AdminBarberia.Views.Alert
{
    partial class FrmAlertBox
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblTitleAlertBox = new System.Windows.Forms.Label();
            this.lblTextAlertBox = new System.Windows.Forms.Label();
            this.LineAlerBox = new System.Windows.Forms.Panel();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.ptbIconsAlert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIconsAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblTitleAlertBox
            // 
            this.lblTitleAlertBox.AutoSize = true;
            this.lblTitleAlertBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAlertBox.Location = new System.Drawing.Point(190, 17);
            this.lblTitleAlertBox.Name = "lblTitleAlertBox";
            this.lblTitleAlertBox.Size = new System.Drawing.Size(121, 23);
            this.lblTitleAlertBox.TabIndex = 1;
            this.lblTitleAlertBox.Text = "Title AlertBox";
            // 
            // lblTextAlertBox
            // 
            this.lblTextAlertBox.AutoSize = true;
            this.lblTextAlertBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextAlertBox.Location = new System.Drawing.Point(90, 40);
            this.lblTextAlertBox.Name = "lblTextAlertBox";
            this.lblTextAlertBox.Size = new System.Drawing.Size(109, 23);
            this.lblTextAlertBox.TabIndex = 2;
            this.lblTextAlertBox.Text = "Text AlertBox";
            // 
            // LineAlerBox
            // 
            this.LineAlerBox.BackColor = System.Drawing.Color.Black;
            this.LineAlerBox.Location = new System.Drawing.Point(-1, 76);
            this.LineAlerBox.Name = "LineAlerBox";
            this.LineAlerBox.Size = new System.Drawing.Size(4, 6);
            this.LineAlerBox.TabIndex = 3;
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 10;
            this.timerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // ptbIconsAlert
            // 
            this.ptbIconsAlert.Location = new System.Drawing.Point(12, 17);
            this.ptbIconsAlert.Name = "ptbIconsAlert";
            this.ptbIconsAlert.Size = new System.Drawing.Size(51, 49);
            this.ptbIconsAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIconsAlert.TabIndex = 0;
            this.ptbIconsAlert.TabStop = false;
            // 
            // FrmAlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 82);
            this.Controls.Add(this.LineAlerBox);
            this.Controls.Add(this.lblTextAlertBox);
            this.Controls.Add(this.lblTitleAlertBox);
            this.Controls.Add(this.ptbIconsAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlertBox";
            this.Text = "FrmAlertBox";
            this.Load += new System.EventHandler(this.FrmAlertBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIconsAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel LineAlerBox;
        private System.Windows.Forms.Label lblTextAlertBox;
        private System.Windows.Forms.Label lblTitleAlertBox;
        private System.Windows.Forms.PictureBox ptbIconsAlert;
        private System.Windows.Forms.Timer timerAnimation;
    }
}