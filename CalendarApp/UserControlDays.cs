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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        DateTime now = DateTime.Now;
        
        public void days(int numday, int numMonth, int numYear)
        {
            if(numday == now.Day && numMonth == now.Month && numYear == now.Year)
            {
                this.lblDays.ForeColor = Color.DarkSeaGreen;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            }
            lblDays.Text = numday + "";
        }
    }
}
