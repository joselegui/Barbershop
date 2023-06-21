﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBarberia.Views.Alert
{
    public partial class FrmAlertBox : Form
    {
        public FrmAlertBox()
        {
            InitializeComponent();
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            LineAlerBox.Width += 4;
            if (LineAlerBox.Width == 500)
                this.Close();
        }

        private void FrmAlertBox_Load(object sender, EventArgs e)
        {
            PositionBox();
            for (int i = 0; i < 500; i++)
               timerAnimation.Start();
        }

        public Color BackColorAlertBox
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color ColorAlertBox
        {
            get { return LineAlerBox.BackColor; }
            set { LineAlerBox.BackColor = lblTitleAlertBox.ForeColor = lblTextAlertBox.ForeColor = value; }
        }

        public Image IconAlertBox
        {
            get { return ptbIconsAlert.Image; }
            set { ptbIconsAlert.Image = value; }
        }

        public string TitleAlertBox
        {
            get { return lblTitleAlertBox.Text; }
            set { lblTitleAlertBox.Text = value; }
        }

        public string TextAlertBox
        {
            get { return lblTextAlertBox.Text; }
            set { lblTextAlertBox.Text = value; }
        }

        private void PositionBox()
        {
            int xPos = 0; int yPos = 0;
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;

            this.Location = new Point(xPos - this.Width, yPos - this.Height);
        }
    }
}
