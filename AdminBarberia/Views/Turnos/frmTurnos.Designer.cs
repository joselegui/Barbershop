namespace AdminBarberia.Views.Turnos
{
    partial class frmTurnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fLPMes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblMonth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domingo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(132, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lunes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(331, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Miercoles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(233, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Martes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(457, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Jueves";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(565, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Viernes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(673, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sabado";
            // 
            // fLPMes
            // 
            this.fLPMes.Location = new System.Drawing.Point(12, 98);
            this.fLPMes.Name = "fLPMes";
            this.fLPMes.Size = new System.Drawing.Size(794, 626);
            this.fLPMes.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::AdminBarberia.Properties.Resources.icons8_back_to_32px;
            this.btnBack.ImageSize = new System.Drawing.Size(45, 45);
            this.btnBack.Location = new System.Drawing.Point(647, 730);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(64, 49);
            this.btnBack.TabIndex = 9;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = global::AdminBarberia.Properties.Resources.icons8_next_page_32px;
            this.btnNext.ImageSize = new System.Drawing.Size(45, 45);
            this.btnNext.Location = new System.Drawing.Point(743, 730);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(64, 49);
            this.btnNext.TabIndex = 8;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::AdminBarberia.Properties.Resources.icons8_delete_50px;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(797, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMonth.Location = new System.Drawing.Point(239, 43);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(351, 26);
            this.lblMonth.TabIndex = 11;
            this.lblMonth.Text = "MONTH YEAR";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(328, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "Turnos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(829, 801);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.fLPMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTurnos";
            this.Load += new System.EventHandler(this.frmTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel fLPMes;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label label5;
    }
}