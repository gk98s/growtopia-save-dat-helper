using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace SaveDatHelper

{

    public class AutoSecure
    {
        
    }

    public partial class Mainform : Form
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

        public Mainform()
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
            if (File.Exists(GTL + "\\save.dat"))
            {
            if (File.Exists(FL + "\\save.dat"))
                {
                    File.Delete(FL + "\\save.dat");
                    File.Copy(GTL + "\\save.dat", FL + "\\save.dat");
                    MessageBox.Show("Successfully saved", "Overwrite");
                }
            else
                {
                    File.Copy(GTL + "\\save.dat", FL + "\\save.dat");
                    MessageBox.Show("Successfully saved", "Successful");
                }
            }
            else
            {
                MessageBox.Show("There's no file named save.dat in your GT Location. That's probably because you secured it. Try going to options and click \"Back\" and try again.", "Error");
            }
        }

        private void btn_secure_Click(object sender, EventArgs e)
        {
            if (File.Exists(FL + "\\save.dat"))
            {
                if (File.Exists(GTL + "\\save.dat"))
                {
                    File.Delete(GTL + "\\save.dat");
                    MessageBox.Show("Successfully secured.", "Successful");
                }
                else
                {
                    MessageBox.Show("There's no file named save.dat in your GT Location. That's probably because you already secured it.", "Error");
                }
            }
            else
            {
                MessageBox.Show("There's nothing named save.dat in your Folder. Please make sure to save before securing.", "Error");
            }
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            if (File.Exists(FL + "\\save.dat"))
            {
            if (File.Exists(GTL + "\\save.dat"))
                {
                    MessageBox.Show("Successfully replaced.", "Overwrite");
                    File.Delete(GTL + "\\save.dat");
                    File.Copy(FL + "\\save.dat", GTL + "\\save.dat");
                }
            else
                {
                    File.Copy(FL + "\\save.dat", GTL + "\\save.dat");
                    MessageBox.Show("Successfully replaced.", "Successful");
                }
            }
            else
            {
                MessageBox.Show("There's nothing named save.dat in your Folder. Please make sure to save before replacing.", "Error");
            }
        }
    }
}
