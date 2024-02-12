namespace DanilsaOS
{
    partial class LockScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockScreen));
            panel1 = new Panel();
            date = new Label();
            hour = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelLock = new Panel();
            panelLock2 = new Panel();
            panel2 = new Panel();
            error = new Label();
            login = new Panel();
            panel3 = new Panel();
            txtPass = new TextBox();
            lblUser = new Label();
            exit = new Panel();
            panel1.SuspendLayout();
            panelLock.SuspendLayout();
            panelLock2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(date);
            panel1.Controls.Add(hour);
            panel1.Location = new Point(504, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 100);
            panel1.TabIndex = 0;
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.Transparent;
            date.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date.ForeColor = SystemColors.ButtonHighlight;
            date.Location = new Point(122, 58);
            date.Name = "date";
            date.Size = new Size(209, 22);
            date.TabIndex = 1;
            date.Text = "lunes, 12 de febrero";
            // 
            // hour
            // 
            hour.AutoSize = true;
            hour.BackColor = Color.Transparent;
            hour.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hour.ForeColor = SystemColors.ButtonHighlight;
            hour.Location = new Point(150, 21);
            hour.Name = "hour";
            hour.Size = new Size(141, 27);
            hour.TabIndex = 0;
            hour.Text = "01:03 a. m.";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panelLock
            // 
            panelLock.BackColor = Color.Transparent;
            panelLock.Controls.Add(panelLock2);
            panelLock.Controls.Add(panel1);
            panelLock.Location = new Point(-13, -1);
            panelLock.Name = "panelLock";
            panelLock.Size = new Size(1360, 807);
            panelLock.TabIndex = 1;
            panelLock.Paint += panelLock_Paint;
            panelLock.MouseClick += panelLock_MouseClick;
            // 
            // panelLock2
            // 
            panelLock2.BackColor = Color.Transparent;
            panelLock2.Controls.Add(panel2);
            panelLock2.Location = new Point(13, 0);
            panelLock2.Name = "panelLock2";
            panelLock2.Size = new Size(1370, 795);
            panelLock2.TabIndex = 2;
            panelLock2.Paint += panelLock2_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(error);
            panel2.Controls.Add(login);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(lblUser);
            panel2.Location = new Point(502, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 302);
            panel2.TabIndex = 5;
            // 
            // error
            // 
            error.AutoSize = true;
            error.BackColor = Color.LightGray;
            error.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            error.ForeColor = Color.Crimson;
            error.Location = new Point(73, 268);
            error.Name = "error";
            error.Size = new Size(195, 17);
            error.TabIndex = 5;
            error.Text = "~contraseña incorrecta~";
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.BackgroundImage = (Image)resources.GetObject("login.BackgroundImage");
            login.BackgroundImageLayout = ImageLayout.Stretch;
            login.Location = new Point(282, 227);
            login.Name = "login";
            login.Size = new Size(35, 35);
            login.TabIndex = 3;
            login.MouseClick += login_MouseClick;
            login.MouseLeave += login_MouseLeave;
            login.MouseHover += login_MouseHover;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(105, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(129, 129);
            panel3.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightGray;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = SystemColors.ControlDarkDark;
            txtPass.HideSelection = false;
            txtPass.Location = new Point(59, 232);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.PlaceholderText = "contraseña";
            txtPass.Size = new Size(220, 26);
            txtPass.TabIndex = 4;
            txtPass.MouseHover += txtPass_MouseHover;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.ButtonHighlight;
            lblUser.Location = new Point(84, 189);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(171, 27);
            lblUser.TabIndex = 3;
            lblUser.Text = "Hola, Danilsa";
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            exit.Location = new Point(1279, 692);
            exit.Name = "exit";
            exit.Size = new Size(50, 50);
            exit.TabIndex = 2;
            exit.MouseClick += exit_MouseClick;
            exit.MouseLeave += exit_MouseLeave;
            exit.MouseHover += exit_MouseHover;
            // 
            // LockScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1360, 788);
            Controls.Add(exit);
            Controls.Add(panelLock);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LockScreen";
            Load += Form1_Load;
            Click += Form1_Click;
            MouseClick += Form1_MouseClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLock.ResumeLayout(false);
            panelLock2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label date;
        private Label hour;
        private System.Windows.Forms.Timer timer1;
        private Panel panelLock;
        private Panel panelLock2;
        private Panel panel3;
        private Panel exit;
        private TextBox txtPass;
        private Label lblUser;
        private Panel panel2;
        private Panel login;
        private Label error;
    }
}
