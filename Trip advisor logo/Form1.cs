using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_advisor_logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Brush and Pen Set-Up
            Graphics Logo = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black, 30);
            SolidBrush Yellow = new SolidBrush(Color.Yellow);
            SolidBrush Black = new SolidBrush(Color.Black);
            SolidBrush LightBlue = new SolidBrush(Color.LightBlue);
            SolidBrush OrangeRed = new SolidBrush(Color.OrangeRed);
            SolidBrush Green = new SolidBrush(Color.ForestGreen);
            //Color Background
            Logo.Clear(Color.LightBlue);
            //Ears
            Logo.FillPie(Black, 500, 50, 120, 120, 100, 60);
            Logo.FillPie(Black, 200, 55, 120, 120, 370, 60);
            //Yellow elipse for forehead
            Logo.DrawEllipse(BlackPen, 275, 110, 275, 165);
            Logo.FillEllipse(Yellow, 275, 110, 275, 165);
            //Yellow Cover-up
            Logo.FillPie(LightBlue, 333, 160, 160, 160, 60, 60);
            //Beak
            Logo.FillPie(Black, 356, 240, 120, 120, 240, 60);
            //White elipse for eyes
            SolidBrush White = new SolidBrush(Color.White);
            Logo.DrawEllipse(BlackPen, 250, 145, 150, 150);
            Logo.FillEllipse(White, 250, 145, 150, 150);
            Logo.DrawEllipse(BlackPen, 428, 145, 150, 150);
            Logo.FillEllipse(White, 428, 145, 150, 150);
            //Pupals
            Logo.DrawEllipse(BlackPen, 285, 180, 75, 75);
            Logo.FillEllipse(White, 285, 180, 75, 75);
            Logo.DrawEllipse(BlackPen, 465, 180, 75, 75);
            Logo.FillEllipse(White, 465, 180, 75, 75);
            //Orange eye
            Logo.FillEllipse(OrangeRed, 306, 200, 32, 32);
            //Green eye
            Logo.FillEllipse(Green, 486, 200, 32, 32);
            // String setup
            Font drawFont = new Font("Source Sans Pro", 25, FontStyle.Bold);
            //Trip String
            //Logo.RotateTransform(90);
            Logo.DrawString("Trip", drawFont, Black, 320, 360);
            //Advisor String
            Logo.DrawString("Advisor", drawFont, Green, 380, 360);
            //
        }
    }
}
