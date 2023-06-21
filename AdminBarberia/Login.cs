using System;
using AdminBarberia.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminBarberia.Views.Alert;

namespace AdminBarberia
{
    public partial class Login : Form
    {
        string user = "Admin";
        string pass = "Pass.001";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            this.txtUser.HintText = "*Usuario";
            this.txtPassword.HintText = "*Password";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtPassword.isPassword = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text.Trim() == String.Empty) || (this.txtPassword.Text.Trim() == String.Empty))
            {
                AlertBoxArton(Color.LightGoldenrodYellow, Color.Gold, "Advertencia", "Complete los campos obligatorios...", Properties.Resources.warning);
                return;
            }

            if (this.txtUser.Text == user && this.txtPassword.Text == pass)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
                AlertBoxArton(Color.LightPink, Color.DarkRed, "ERROR", "Usuario y/o contraseña. Incorrectas...", Properties.Resources.close);
        }

        private void CheckBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPass.Checked == true)
            {
                this.txtPassword.isPassword = false;
            }
            else { this.txtPassword.isPassword = true; }
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
    }
}
