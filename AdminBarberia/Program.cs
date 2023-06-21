using AdminBarberia.Views.Empleados;
using AdminBarberia.Views.Turnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBarberia
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
            //Application.Run(new Login());
            //Application.Run(new frmEmpleados());
            //Application.Run(new Views.Turnos.frmTurnos());
            //Application.Run(new frmEventTurno());
        }
    }
}
