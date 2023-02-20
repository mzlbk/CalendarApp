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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        int mouseX, mouseY;
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
    }
}
