using System.Windows.Forms;

namespace DanilsaOS
{
    public partial class LockScreen : Form
    {

        public LockScreen()
        {
            InitializeComponent();

            panelLock2.Hide();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel1.BackColor = Color.FromArgb(80, 255, 255, 255);
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            //panelLock2.BackColor = Color.FromArgb(80, 255, 255, 255);
            error.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;

            }
            else
            {
                timer1.Stop();
                this.Hide();
                var login = new HomeScreen();
                login.Show();

            }
        }

        private void panelLock_MouseClick(object sender, MouseEventArgs e)
        {
            panelLock2.Show();
            panel1.Hide();

        }

        private void txtPass_MouseHover(object sender, EventArgs e)
        {
        }

        private void exit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackgroundImage = new System.Drawing.Bitmap(@"C:\Users\hp\source\repos\DanilsaOS\images\power-off-hover.png");
            exit.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void panelLock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLock2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            login.BackgroundImage = new System.Drawing.Bitmap(@"C:\Users\hp\source\repos\DanilsaOS\images\login-hover.png");
            login.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.BackgroundImage = new System.Drawing.Bitmap(@"C:\Users\hp\source\repos\DanilsaOS\images\login.png");
            login.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = new System.Drawing.Bitmap(@"C:\Users\hp\source\repos\DanilsaOS\images\power-off.png");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void login_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "123456")
            {
                error.Text = "";
                var home = new HomeScreen();
                home.Show();
                this.Hide();
               
            }
            else
            {
                error.Text = "~contraseña incorrecta~";
            }
        }
    }
}
