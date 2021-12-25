using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SaveDatHelper

{
    public partial class Form1 : Form
    {

        bool mouseDown;
        private Point offset;

        //roundcorner
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );  //roundcorner end

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //roundcorner
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void e_mousedown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void e_mousemove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currrentScreenPos =  PointToScreen(e.Location);
                Location = new Point(currrentScreenPos.X - offset.X, currrentScreenPos.Y - offset.Y);
            }
        }

        private void e_mouseup(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
