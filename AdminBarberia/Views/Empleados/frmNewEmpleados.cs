using AdminBarberia.Controllers;
using AdminBarberia.Views.Alert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBarberia.Views.Empleados
{
    public partial class frmNewEmpleados : Form
    {
        Validation validation = new Validation();

        public frmNewEmpleados()
        {
            InitializeComponent();

            cbbEspecialidad.Items.Add("Peluquero unixes");
            cbbEspecialidad.Items.Add("Barbero");
            cbbEspecialidad.Items.Add("Colorista");
            cbbEspecialidad.Items.Add("Peinador");

            

        }
        private void frmNewEmpleados_Load(object sender, EventArgs e)
        {
            txtName.Select();
            this.ActiveControl = txtName;
            txtName.Focus();

           

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbPhoto.ImageLocation = openFileDialog.FileName;
                ptbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtLastName.Text.Trim() != String.Empty) && (txtLegajo.Text.Trim() != String.Empty) && (txtName.Text.Trim() != String.Empty) &&
                (txtTel.Text.Trim() != String.Empty))
            {
                if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
                {
                    lblRequerido4.Visible = true;
                    lblRequerido4.Text = "Porfavor ingrese un EMAIL, valido";
                }
                else
                {
                    ValidateEmail(txtEmail.Text);
                    AlertBoxArton(Color.LightGreen, Color.SeaGreen, "Guardando empleado nuevo", "Se esta guardando los datos del empledo...", Properties.Resources.check);
                    ResetTexbox();
                }
            }
            else
            {
                AlertBoxArton(Color.LightGoldenrodYellow, Color.Gold, "Advertencia", "Complete todos los campos obligatorios...", Properties.Resources.warning);
            }
        }

        void AlertBoxArton(Color backColor, Color color, string title, string text, Image icon)
        {
            FrmAlertBox Alert = new FrmAlertBox();
            Alert.BackColor = backColor;
            Alert.ColorAlertBox = color;
            Alert.TitleAlertBox = title;
            Alert.TextAlertBox = text;
            Alert.IconAlertBox = icon;

            Alert.ShowDialog();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

        }

        public void ValidateEmail(string email)
        {
            Regex mRegxExpression;

            mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
            txtEmail.IconRight = Properties.Resources.check;
            if (!mRegxExpression.IsMatch(email.Trim()))
            {
                txtEmail.IconRight = Properties.Resources.close;
                txtEmail.Focus();
            }
        }
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.Sololetras(e, txtLastName);
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.Sololetras(e, txtName);
        }
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.Solonumeros(e, txtTel);
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text);
            txtName.SelectionStart = txtName.Text.Length;
        }

        public void ResetTexbox()
        {
            txtLastName.Text = "";
            txtLastName.IconRight = null;
            txtLastName.Select();
            this.ActiveControl = txtLastName;
            txtLastName.Focus();

            txtName.Text = "";
            txtName.IconRight = null;

            txtTel.Text = "";
            txtTel.IconRight = null;

            txtLegajo.Text = "";
            txtDireccion.Text = "";

            txtEmail.Text = "";
            txtEmail.IconRight = null;

            lblRequerido4.Text = "";
        }

        private void cbbEspecialidad_TextChanged(object sender, EventArgs e)
        {
            if (cbbEspecialidad.SelectedIndex < 0)
                cbbEspecialidad.Text = "--Select one of the answers--";
        }

        private void cbbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
