using AdminBarberia.Views.Lupa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBarberia.Views.Locales
{
    public partial class FrmLocales : Form
    {
        public FrmLocales()
        {
            InitializeComponent();
        }

        private void FrmLocales_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void PtbHomeCenter_Click(object sender, EventArgs e)
        {
            frmLupa lupa = new frmLupa();
            lupa.Show();
        }

        private void PtbHomeCenter_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
