using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp
{
    public partial class UserControlBlank : UserControl
    {
        public UserControlBlank()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        DateTime now = DateTime.Now;

        public void days(int numday, int numMonth, int numYear)
        {
            DateTime startofthemonth = new DateTime(numYear, numMonth, 1);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            int prev;
            if(numMonth == 1)
                prev = 31;
            else
                prev = DateTime.DaysInMonth(numYear, numMonth - 1);
            /////////////////////////////////////
            if (dayoftheweek - 1 == 1 && numday == 1)
                lblDaysv1.Text = prev + "";
            /////////////////////////////////////
            if (dayoftheweek - 1 == 2 && numday == 1)
                lblDaysv1.Text = prev -1 + "";
            if (dayoftheweek - 1 == 2 && numday == 2)
                lblDaysv1.Text = prev + "";
            /////////////////////////////////////
            if (dayoftheweek - 1 == 3 && numday == 1)
                lblDaysv1.Text = prev - 2 + "";
            if (dayoftheweek - 1 == 3 && numday == 2)
                lblDaysv1.Text = prev - 1 + "";
            if (dayoftheweek - 1 == 3 && numday == 3)
                lblDaysv1.Text = prev + "";
            /////////////////////////////////////
            if (dayoftheweek - 1 == 4 && numday == 1)
                lblDaysv1.Text = prev - 3 + "";
            if (dayoftheweek - 1 == 4 && numday == 2)
                lblDaysv1.Text = prev - 2 + "";
            if (dayoftheweek - 1 == 4 && numday == 3)
                lblDaysv1.Text = prev - 1 + "";
            if (dayoftheweek - 1 == 4 && numday == 4)
                lblDaysv1.Text = prev + "";
            /////////////////////////////////////
            if (dayoftheweek - 1 == 5 && numday == 1)
                lblDaysv1.Text = prev - 4 + "";
            if (dayoftheweek - 1 == 5 && numday == 2)
                lblDaysv1.Text = prev - 3 + "";
            if (dayoftheweek - 1 == 5 && numday == 3)
                lblDaysv1.Text = prev - 2 + "";
            if (dayoftheweek - 1 == 5 && numday == 4)
                lblDaysv1.Text = prev - 1 + "";
            if (dayoftheweek - 1 == 5 && numday == 5)
                lblDaysv1.Text = prev + "";
            /////////////////////////////////////
            if (dayoftheweek - 1 == 6 && numday == 1)
                lblDaysv1.Text = prev - 5 + "";
            if (dayoftheweek - 1 == 6 && numday == 2)
                lblDaysv1.Text = prev - 4 + "";
            if (dayoftheweek - 1 == 6 && numday == 3)
                lblDaysv1.Text = prev - 3 + "";
            if (dayoftheweek - 1 == 6 && numday == 4)
                lblDaysv1.Text = prev - 2 + "";
            if (dayoftheweek - 1 == 6 && numday == 5)
                lblDaysv1.Text = prev - 1 + "";
            if (dayoftheweek - 1 == 6 && numday == 6)
                lblDaysv1.Text = prev + "";
        }
    }
}
