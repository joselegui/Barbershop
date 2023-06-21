using AdminBarberia.Views.Alert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBarberia.Views.Turnos
{
    public partial class frmEventTurno : Form
    {
        public frmEventTurno()
        {
            InitializeComponent();
        }

        private void frmEventTurno_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

            txtFecha.Text = DaysControl.staticDay + "/" + frmTurnos.staticMonth + "/" + frmTurnos.staticYear;

            //cbEmpleados.Items.Insert(0, "Prueba");
            cbEmpleados.Items.Add("Argentina");
            cbEmpleados.Items.Add("Tokyo");
            cbEmpleados.Items.Add("Uruguay");
            cbEmpleados.Items.Add("Brazil");
            cbEmpleados.Items.Add("Chile");
            cbEmpleados.Items.Add("EEUU");
            cbEmpleados.Items.Add("España");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AlertBoxArton(Color.LightGreen, Color.SeaGreen,"Guardando turno","Se esta guardando el turno...",Properties.Resources.check);
        }
    }
}
