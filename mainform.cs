using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace SaveDatHelper

{
    public partial class mainform : Form
    {

        bool mouseDown;
        private Point offset;

        //roundedcorners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );  //roundedcorners end

        public mainform()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //roundedcorners
        }
        //settings.settings variables
        string GTL = SaveDatHelper.Properties.Settings.Default.GTLocS;
        string FL = SaveDatHelper.Properties.Settings.Default.FolderLocS;
        //settings.settings variables end

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //roundedbuttons
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0,0, btn_save.Width, btn_save.Height, 30, 30));
            btn_replace.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_replace.Width, btn_replace.Height, 30, 30));
            btn_secure.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_secure.Width, btn_secure.Height, 30, 30));
            btn_settings.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_settings.Width, btn_settings.Height, 30, 30));
            //roundedbuttons
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

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settingsform settingsForm = new settingsform();
       //   this.Hide();
            settingsForm.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_secure_Click(object sender, EventArgs e)
        {
            if (File.Exists(FL + "")) ;
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {

        }
    }
}
