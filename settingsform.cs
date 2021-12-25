using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SaveDatHelper
{
    public partial class settingsform : Form
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

        public settingsform()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //roundcorner
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            tb_1.Text = SaveDatHelper.Properties.Settings.Default.FolderLocS;
            tb_2.Text = SaveDatHelper.Properties.Settings.Default.GTLocS;
            //roundedbuttons
            
            btn_browse2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_browse2.Width, btn_browse2.Height, 30, 30));
            btn_browse1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_browse1.Width, btn_browse1.Height, 30, 30));
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 30, 30));
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
                Point currrentScreenPos = PointToScreen(e.Location);
                Location = new Point(currrentScreenPos.X - offset.X, currrentScreenPos.Y - offset.Y);
            }
        }

        private void e_mouseup(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
       //   mainform mainForm = new mainform();
       //   mainForm.Show();
            this.Hide();
        }

        

        private void tb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_browse1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    tb_1.Text = fbd.SelectedPath;
            }
        }

        private void btn_browse2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    tb_2.Text = fbd.SelectedPath;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveDatHelper.Properties.Settings.Default.FolderLocS = tb_1.Text;
            SaveDatHelper.Properties.Settings.Default.GTLocS = tb_2.Text;
            SaveDatHelper.Properties.Settings.Default.Save();
        }
    }
}
