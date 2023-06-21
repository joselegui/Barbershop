namespace AdminBarberia.Views.Turnos
{
    partial class frmEventTurno
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
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDetalle = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbEmpleados = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle del turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleado";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderRadius = 6;
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFecha.DefaultText = "";
            this.txtFecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFecha.DisabledState.Parent = this.txtFecha;
            this.txtFecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFecha.Enabled = false;
            this.txtFecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFecha.FocusedState.Parent = this.txtFecha;
            this.txtFecha.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFecha.HoverState.Parent = this.txtFecha;
            this.txtFecha.Location = new System.Drawing.Point(16, 44);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.PasswordChar = '\0';
            this.txtFecha.PlaceholderText = "";
            this.txtFecha.SelectedText = "";
            this.txtFecha.ShadowDecoration.Parent = this.txtFecha;
            this.txtFecha.Size = new System.Drawing.Size(176, 36);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDetalle
            // 
            this.txtDetalle.BorderRadius = 6;
            this.txtDetalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetalle.DefaultText = "";
            this.txtDetalle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDetalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDetalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetalle.DisabledState.Parent = this.txtDetalle;
            this.txtDetalle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetalle.FocusedState.Parent = this.txtDetalle;
            this.txtDetalle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.Color.Black;
            this.txtDetalle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetalle.HoverState.Parent = this.txtDetalle;
            this.txtDetalle.Location = new System.Drawing.Point(16, 130);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.PasswordChar = '\0';
            this.txtDetalle.PlaceholderText = "";
            this.txtDetalle.SelectedText = "";
            this.txtDetalle.ShadowDecoration.Parent = this.txtDetalle;
            this.txtDetalle.Size = new System.Drawing.Size(316, 43);
            this.txtDetalle.TabIndex = 4;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.cbEmpleados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.FocusedColor = System.Drawing.Color.Empty;
            this.cbEmpleados.FocusedState.Parent = this.cbEmpleados;
            this.cbEmpleados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.HoverState.Parent = this.cbEmpleados;
            this.cbEmpleados.ItemHeight = 30;
            this.cbEmpleados.ItemsAppearance.Parent = this.cbEmpleados;
            this.cbEmpleados.Location = new System.Drawing.Point(16, 215);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.ShadowDecoration.Parent = this.cbEmpleados;
            this.cbEmpleados.Size = new System.Drawing.Size(316, 36);
            this.cbEmpleados.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbEmpleados.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::AdminBarberia.Properties.Resources.icons8_delete_50px;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(471, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 6;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Image = global::AdminBarberia.Properties.Resources.icons8_save_30px;
            this.btnGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuardar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGuardar.Location = new System.Drawing.Point(350, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(146, 45);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEventTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(508, 268);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEventTurno";
            this.Load += new System.EventHandler(this.frmEventTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cbEmpleados;
        private Guna.UI2.WinForms.Guna2TextBox txtDetalle;
        private Guna.UI2.WinForms.Guna2TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
    }
}