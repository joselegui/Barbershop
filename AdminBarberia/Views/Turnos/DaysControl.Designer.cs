namespace AdminBarberia.Views.Turnos
{
    partial class DaysControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDays.Location = new System.Drawing.Point(3, 15);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(29, 20);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "00";
            // 
            // DaysControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblDays);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DaysControl";
            this.Size = new System.Drawing.Size(105, 94);
            this.Load += new System.EventHandler(this.DaysControl_Load);
            this.Click += new System.EventHandler(this.DaysControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
    }
}
