using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBarberia.Views.Turnos
{
    public partial class frmTurnos : Form
    {
        #region variables

        int month, year;

        public static int staticMonth, staticYear;

        #endregion
        public frmTurnos()
        {
            InitializeComponent();
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            DisplayDays();
        }

        private void DisplayDays() 
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthName+ " " +year;


            staticMonth = month;
            staticYear = year;

            DateTime startofthememoth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthememoth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ConterDaysControls dControls = new ConterDaysControls();

                fLPMes.Controls.Add(dControls);
            }

            for (int i = 1; i <= days; i++)
            {
                DaysControl daysControl = new DaysControl();

                daysControl.Days(i);
                fLPMes.Controls.Add(daysControl);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fLPMes.Controls.Clear();

            month--;

            staticMonth = month;
            staticYear = year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthName + " " + year;

            DateTime startofthememoth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthememoth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ConterDaysControls dControls = new ConterDaysControls();

                fLPMes.Controls.Add(dControls);
            }

            for (int i = 1; i <= days; i++)
            {
                DaysControl daysControl = new DaysControl();

                daysControl.Days(i);
                fLPMes.Controls.Add(daysControl);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            fLPMes.Controls.Clear();

            month++;

            staticMonth = month;
            staticYear = year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthName + " " + year;

            DateTime startofthememoth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthememoth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ConterDaysControls dControls = new ConterDaysControls();

                fLPMes.Controls.Add(dControls);
            }

            for (int i = 1; i <= days; i++)
            {
                DaysControl daysControl = new DaysControl();

                daysControl.Days(i);
                fLPMes.Controls.Add(daysControl);
            }
        }
    }
}
