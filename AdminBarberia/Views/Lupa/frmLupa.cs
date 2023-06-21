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

namespace AdminBarberia.Views.Lupa
{
    public partial class frmLupa : Form
    {
        Graphics GraphicsCapture;
        Bitmap ImageTempolary;
        Point frmMove;
        Boolean MoverMouse;
        int Zoom = 1;


        public frmLupa()
        {
            InitializeComponent();

            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        private void frmLupa_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int AnchoImagen = picLupa.Width;
            int AltoImagen = picLupa.Height;

            int MuseX = MousePosition.X;
            int MuseY = MousePosition.Y;


            ImageTempolary = new Bitmap(AnchoImagen / Zoom, AltoImagen / Zoom, System.Drawing.Imaging.PixelFormat.Format64bppPArgb);
            GraphicsCapture = this.CreateGraphics();
            GraphicsCapture = Graphics.FromImage(ImageTempolary);

            GraphicsCapture.CopyFromScreen(MuseX-AnchoImagen/(Zoom*2),MuseY-AltoImagen/(Zoom*2),0,0,picLupa.Size);


            Bitmap NewImage = new Bitmap(AnchoImagen,AltoImagen);
            GraphicsCapture = Graphics.FromImage(NewImage);
            GraphicsCapture.SmoothingMode= System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            GraphicsCapture.DrawImage(ImageTempolary, new Rectangle(0,0,AnchoImagen,AltoImagen));
            picLupa.Image = NewImage;


            Rectangle rectangleP = new Rectangle(0, 0, AnchoImagen, AltoImagen);
            GraphicsPath pathp = new GraphicsPath();
            pathp.AddEllipse(rectangleP);
            picLupa.Region = new Region(pathp);


            Rectangle rectangle = new Rectangle(0,0 , panelLupa.Width, panelLupa.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rectangle);
            panelLupa.Region = new Region(path);

            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
        }

        private void panelLupa_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverMouse)
                Location = new Point(Cursor.Position.X - frmMove.X, Cursor.Position.Y - frmMove.Y);
        }

        private void panelLupa_MouseDown(object sender, MouseEventArgs e)
        {
            frmMove = new Point(Cursor.Position.X - frmMove.X, Cursor.Position.Y - frmMove.Y);
            MoverMouse = true;
        }

        private void frmLupa_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode & Keys.Z) == Keys.Z) 
            {
                Zoom++;
            }

            if ((e.KeyCode & Keys.ControlKey) == Keys.ControlKey)
            {
                if(Zoom > 1) { Zoom--; }
            }

            if ((e.KeyCode & Keys.Escape) == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
