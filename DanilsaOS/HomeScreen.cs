using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanilsaOS
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            options.Hide();
            /*panel1.BackColor = Color.FromArgb(80, 255, 255, 255);
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;*/
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            iconStart.BackgroundImage = new System.Drawing.Bitmap(@"C:\Users\hp\source\repos\DanilsaOS\images\start-hover.png");
            iconStart.BackgroundImageLayout = ImageLayout.Stretch;
            iconStart.BackColor = Color.Thistle;
            btnStart.BackColor = Color.Thistle;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            iconStart.BackgroundImage = new System.Drawing.Bitmap(@"C:\Users\hp\source\repos\DanilsaOS\images\start.png");
            iconStart.BackgroundImageLayout = ImageLayout.Stretch;
            iconStart.BackColor = Color.LightGray;
            btnStart.BackColor = Color.LightGray;
        }

        private void btnStart_MouseClick(object sender, MouseEventArgs e)
        {
            if (options.Visible == false)
            {
                options.Show();
            }
            else
            {
                options.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void powerOff_MouseHover(object sender, EventArgs e)
        {
            powerOff.BackColor = Color.LightGray;
        }

        private void powerOff_MouseLeave(object sender, EventArgs e)
        {
            powerOff.BackColor = Color.White;
        }



        private void iconStart_MouseHover(object sender, EventArgs e)
        {
            iconStart.BackgroundImage = new System.Drawing.Bitmap(@"C:\Users\hp\source\repos\DanilsaOS\images\start-hover.png");
            iconStart.BackgroundImageLayout = ImageLayout.Stretch;
            iconStart.BackColor = Color.Thistle;
            btnStart.BackColor = Color.Thistle;
        }
        private void iconStart_MouseLeave(object sender, EventArgs e)
        {
            iconStart.BackgroundImage = new System.Drawing.Bitmap(@"C:\Users\hp\source\repos\DanilsaOS\images\start.png");
            iconStart.BackgroundImageLayout = ImageLayout.Stretch;
            iconStart.BackColor = Color.LightGray;
            btnStart.BackColor = Color.LightGray;
        }



        private void notesOptions_MouseHover(object sender, EventArgs e)
        {

            notesOptions.BackColor = Color.White;
            notesOptions.BackColor = Color.White;
        }
        private void notesOptions_MouseLeave(object sender, EventArgs e)
        {
          
            notesOptions.BackColor = Color.Thistle;
            notesOptions.BackColor = Color.Thistle;
        }

        private void notesOptions_Click(object sender, EventArgs e)
        {
            options.Hide();
            var notes = new NotesApp();
            notes.Show();

        }

        private void powerOff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void powerOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconStart_Click(object sender, EventArgs e)
        {
            if (options.Visible == false)
            {
                options.Show();
            }
            else
            {
                options.Hide();
            }
        }
    }
}
