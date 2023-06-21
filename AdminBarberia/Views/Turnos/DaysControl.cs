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
    public partial class DaysControl : UserControl
    {
        #region Variables

        public static string staticDay;

        #endregion
        public DaysControl()
        {
            InitializeComponent();
        }

        private void DaysControl_Load(object sender, EventArgs e)
        {
            
        }

        public void Days(int munDay)
        {
            lblDays.Text = munDay + "";
        }

        private void DaysControl_Click(object sender, EventArgs e)
        {
            staticDay = lblDays.Text;
            frmEventTurno frmEvent = new frmEventTurno();
            frmEvent.ShowDialog();
        }
    }
}
