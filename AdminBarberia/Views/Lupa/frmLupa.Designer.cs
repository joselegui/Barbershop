namespace AdminBarberia.Views.Lupa
{
    partial class frmLupa
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
            this.panelLupa = new System.Windows.Forms.Panel();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLupa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLupa
            // 
            this.panelLupa.BackColor = System.Drawing.Color.DimGray;
            this.panelLupa.Controls.Add(this.picLupa);
            this.panelLupa.Location = new System.Drawing.Point(11, 12);
            this.panelLupa.Name = "panelLupa";
            this.panelLupa.Size = new System.Drawing.Size(299, 296);
            this.panelLupa.TabIndex = 0;
            this.panelLupa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLupa_MouseDown);
            this.panelLupa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLupa_MouseMove);
            // 
            // picLupa
            // 
            this.picLupa.Location = new System.Drawing.Point(11, 13);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(277, 269);
            this.picLupa.TabIndex = 0;
            this.picLupa.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.panelLupa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLupa";
            this.Text = "frmLupa";
            this.Load += new System.EventHandler(this.frmLupa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLupa_KeyDown);
            this.panelLupa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLupa;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.Timer timer1;
    }
}