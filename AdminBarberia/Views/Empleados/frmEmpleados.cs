using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBarberia.Views.Empleados
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();


            var dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Contacto");
            dt.Columns.Add("Email");
            dt.Columns.Add("Acciones");

            dt.Rows.Add("NombreTest1","ApellidoTest1", 1212121245, "Test@test.com");
            dt.Rows.Add("NombreTest2","ApellidoTest2", 1623445456, "Test@test.com");
            dt.Rows.Add("NombreTest1", "ApellidoTest1", 1212121245, "Test@test.com");
            dt.Rows.Add("NombreTest2", "ApellidoTest2", 1623445456, "Test@test.com");
            dt.Rows.Add("NombreTest1", "ApellidoTest1", 1212121245, "Test@test.com");
            dt.Rows.Add("NombreTest2", "ApellidoTest2", 1623445456, "Test@test.com");


            tablaEmpleados.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            tablaEmpleados.DataSource = dt;
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmNewEmpleados newEmpleados = new frmNewEmpleados();
            newEmpleados.ShowDialog();  
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        #region Image Colukmn  
        public static Image MakeCircleImage(Image img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            using (GraphicsPath gpImg = new GraphicsPath())
            {
                gpImg.AddEllipse(0, 0, img.Width, img.Height);
                using (Graphics grp = Graphics.FromImage(bmp))
                {
                    grp.Clear(Color.White);
                    grp.SetClip(gpImg);
                    grp.DrawImage(img, Point.Empty);
                }
            }
            return bmp;
        }

        #endregion Image Colukmn 


    }
}
