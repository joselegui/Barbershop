using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace AdminBarberia.Controllers
{
    class Validation
    {
        public void Sololetras(KeyPressEventArgs e, Guna2TextBox guna2TextBox)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar) || (e.KeyChar == 39))
                {
                    e.Handled = false;
                    guna2TextBox.IconRight = Properties.Resources.check;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    guna2TextBox.IconRight = Properties.Resources.check;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                    guna2TextBox.IconRight = Properties.Resources.check;
                }
                else
                {
                    e.Handled = true;
                    guna2TextBox.IconRight = Properties.Resources.close;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
        }

        public void Solonumeros(KeyPressEventArgs e, Guna2TextBox guna2TextBox)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                    guna2TextBox.IconRight = Properties.Resources.check;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    guna2TextBox.IconRight = Properties.Resources.check;
                   
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                    guna2TextBox.IconRight = Properties.Resources.check;
                }
                else
                {
                    e.Handled = true;
                    guna2TextBox.IconRight = Properties.Resources.close;
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.ToString()); }
        }

    }
}
