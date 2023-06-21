namespace AdminBarberia
{
    partial class Login
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
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.txtUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckBoxPass = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(142)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "BARBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(142)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE BARBER";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtPassword.LineIdleColor = System.Drawing.Color.DimGray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(38, 398);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(285, 33);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btnEnter
            // 
            this.btnEnter.Animated = true;
            this.btnEnter.BorderRadius = 20;
            this.btnEnter.CheckedState.Parent = this.btnEnter;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.CustomImages.Parent = this.btnEnter;
            this.btnEnter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(142)))), ((int)(((byte)(81)))));
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.HoverState.Parent = this.btnEnter;
            this.btnEnter.Location = new System.Drawing.Point(53, 483);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.ShadowDecoration.Parent = this.btnEnter;
            this.btnEnter.Size = new System.Drawing.Size(255, 41);
            this.btnEnter.TabIndex = 17;
            this.btnEnter.Text = "ENTRAR";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtUser
            // 
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.HintText = "";
            this.txtUser.isPassword = false;
            this.txtUser.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtUser.LineIdleColor = System.Drawing.Color.DimGray;
            this.txtUser.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtUser.LineThickness = 2;
            this.txtUser.Location = new System.Drawing.Point(38, 316);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(285, 33);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::AdminBarberia.Properties.Resources.icons8_delete_50px;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(343, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 18);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminBarberia.Properties.Resources.Barber_shop_logo_design_on_transparent_background_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(89, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CheckBoxPass
            // 
            this.CheckBoxPass.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxPass.CheckedState.Image = global::AdminBarberia.Properties.Resources.icons8_eye_24px;
            this.CheckBoxPass.CheckedState.Parent = this.CheckBoxPass;
            this.CheckBoxPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxPass.HoverState.Parent = this.CheckBoxPass;
            this.CheckBoxPass.Image = global::AdminBarberia.Properties.Resources.icons8_blind_24px;
            this.CheckBoxPass.Location = new System.Drawing.Point(290, 398);
            this.CheckBoxPass.Name = "CheckBoxPass";
            this.CheckBoxPass.PressedState.Parent = this.CheckBoxPass;
            this.CheckBoxPass.Size = new System.Drawing.Size(33, 31);
            this.CheckBoxPass.TabIndex = 21;
            this.CheckBoxPass.CheckedChanged += new System.EventHandler(this.CheckBoxPass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(361, 612);
            this.Controls.Add(this.CheckBoxPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUser;
        private Guna.UI2.WinForms.Guna2ImageCheckBox CheckBoxPass;
    }
}