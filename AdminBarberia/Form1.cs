using AdminBarberia.Views.Empleados;
using AdminBarberia.Views.Locales;
using AdminBarberia.Views.Turnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBarberia
{
    public partial class Home : Form
    {
        private Form currentChildForm;


        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();       
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEmpleados());
        }

        #region OpenFroms
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(childForm);
            PanelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }
        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmTurnos());

            frmTurnos turnos = new frmTurnos();

            turnos.ShowDialog();
              
        }

        private void btnLocales_Click(object sender, EventArgs e)
        {
            FrmLocales Locales = new FrmLocales();
            Locales.ShowDialog();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
