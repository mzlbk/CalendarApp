using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalendarApp
{
    public partial class frmMain : Form
    {
        int month, year, mouseX, mouseY;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        //Form Yüklenirken Load Etme
        public void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthName + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for(int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                ucblank.days(i, this.month, this.year);
                daycontainer.Controls.Add(ucblank);
            }
            for(int i = 1; i<=days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i, this.month, this.year);
                daycontainer.Controls.Add(ucdays);
            }
        }
        //Form Yüklenirken Load Etme
        //**********************************************************************
        //Next Butonu Basınca
        private void btnNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month != 12)
            {
                month++;
                String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthName + " " + year;
                DateTime startofthemonth = new DateTime(year, month, 1);
                int days = DateTime.DaysInMonth(year, month);
                int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
                for (int i = 1; i < dayoftheweek; i++)
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    ucblank.days(i, this.month, this.year);
                    daycontainer.Controls.Add(ucblank);
                }
                for (int i = 1; i <= days; i++)
                {
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.days(i, this.month, this.year);
                    daycontainer.Controls.Add(ucdays);
                }
            }
            else if(month == 12)
            {
                year++;
                month = 1;
                String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthName + " " + year;
                DateTime startofthemonth = new DateTime(year, month, 1);
                int days = DateTime.DaysInMonth(year, month);
                int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
                for (int i = 1; i < dayoftheweek; i++)
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    ucblank.days(i, this.month, this.year);
                    daycontainer.Controls.Add(ucblank);
                }
                for (int i = 1; i <= days; i++)
                {
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.days(i, this.month, this.year);
                    daycontainer.Controls.Add(ucdays);
                }
            }
        }
        //Next Butonu Basınca
        //**********************************************************************
        //Previous Butonu Basınca
        private void btnPrev_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if(month != 1)
            {
                month--;
                String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthName + " " + year;
                DateTime startofthemonth = new DateTime(year, month, 1);
                int days = DateTime.DaysInMonth(year, month);
                int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
                for (int i = 1; i < dayoftheweek; i++)
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    ucblank.days(i, this.month, this.year);
                    daycontainer.Controls.Add(ucblank);
                }
                for (int i = 1; i <= days; i++)
                {
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.days(i, this.month, this.year);
                    daycontainer.Controls.Add(ucdays);
                }
            }
            else if(month == 1)
            {
                year--;
                month = 12;
                String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthName + " " + year;
                DateTime startofthemonth = new DateTime(year, month, 1);
                int days = DateTime.DaysInMonth(year, month);
                int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
                for (int i = 1; i < dayoftheweek; i++)
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    ucblank.days(i, this.month, this.year);
                    daycontainer.Controls.Add(ucblank);
                }
                for (int i = 1; i <= days; i++)
                {
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.days(i, this.month, this.year);
                    daycontainer.Controls.Add(ucdays);
                }
            }
        }
        //Previous Butonu Basınca
        //**********************************************************************
        //FORM TASARIMI ve SAĞA SOLA KAYDIRMA İŞLEMLERİ
        private void btnX_Click(object sender, EventArgs e)
        {
            var durum = MessageBox.Show("Emin Misin..?", "Böyle Mükemmel Bir Uygulamadan Çıkış Yapmak İstiyor Musun..?",  MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(durum == DialogResult.OK)
            {
                var durum2 = MessageBox.Show("Eminim?", "Bak Emin Misin AMK..?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(durum2 == DialogResult.OK)
                {
                    MessageBox.Show("İyi O Zaman Siktirip Gidiniz!!", "SİKTİRGİT");
                    Application.Exit();
                }
            }
        }
        private void btnSimge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = MousePosition.X - this.Left;
            mouseY = MousePosition.Y - this.Top;
            timerMove.Enabled = true;
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            timerMove.Enabled = false;
        }
        private void timerMove_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - mouseX;
            this.Top = MousePosition.Y - mouseY;
        }
        //FORM TASARIMI ve SAĞA SOLA KAYDIRMA İŞLEMLERİ
        //**********************************************************************
    }
}
