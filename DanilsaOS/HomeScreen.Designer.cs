namespace DanilsaOS
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            panel1 = new Panel();
            btnStart = new Panel();
            iconStart = new Panel();
            options = new Panel();
            label3 = new Label();
            notesOptions = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            powerOff = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            btnStart.SuspendLayout();
            options.SuspendLayout();
            notesOptions.SuspendLayout();
            powerOff.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnStart);
            panel1.Location = new Point(0, 710);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 60);
            panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LightGray;
            btnStart.Controls.Add(iconStart);
            btnStart.Location = new Point(0, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(80, 60);
            btnStart.TabIndex = 1;
            btnStart.MouseClick += btnStart_MouseClick;
            btnStart.MouseLeave += btnStart_MouseLeave;
            btnStart.MouseHover += btnStart_MouseHover;
            // 
            // iconStart
            // 
            iconStart.BackColor = Color.LightGray;
            iconStart.BackgroundImage = (Image)resources.GetObject("iconStart.BackgroundImage");
            iconStart.BackgroundImageLayout = ImageLayout.Stretch;
            iconStart.Location = new Point(9, 1);
            iconStart.Name = "iconStart";
            iconStart.Size = new Size(60, 60);
            iconStart.TabIndex = 2;
            iconStart.Click += iconStart_Click;
            iconStart.MouseHover += iconStart_MouseHover;
            // 
            // options
            // 
            options.Controls.Add(label3);
            options.Controls.Add(notesOptions);
            options.Controls.Add(powerOff);
            options.Location = new Point(0, 395);
            options.Name = "options";
            options.Size = new Size(242, 316);
            options.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(70, 19);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 2;
            label3.Text = "Más utilizadas";
            // 
            // notesOptions
            // 
            notesOptions.BackColor = Color.Thistle;
            notesOptions.Controls.Add(panel5);
            notesOptions.Controls.Add(label2);
            notesOptions.Location = new Point(0, 53);
            notesOptions.Name = "notesOptions";
            notesOptions.Size = new Size(242, 42);
            notesOptions.TabIndex = 3;
            notesOptions.Click += notesOptions_Click;
            notesOptions.MouseLeave += notesOptions_MouseLeave;
            notesOptions.MouseHover += notesOptions_MouseHover;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(70, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(20, 20);
            panel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(98, 14);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Notas";
            // 
            // powerOff
            // 
            powerOff.BackColor = Color.White;
            powerOff.Controls.Add(panel3);
            powerOff.Controls.Add(label1);
            powerOff.Location = new Point(0, 274);
            powerOff.Name = "powerOff";
            powerOff.Size = new Size(242, 42);
            powerOff.TabIndex = 2;
            powerOff.Click += powerOff_Click;
            powerOff.Paint += powerOff_Paint;
            powerOff.MouseLeave += powerOff_MouseLeave;
            powerOff.MouseHover += powerOff_MouseHover;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(70, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 20);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(98, 14);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Apagar";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(1125, 710);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 60);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(117, 14);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 0;
            label4.Text = "01:03 a. m.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(115, 29);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 1;
            label5.Text = "12/02/2024";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(72, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 20);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(29, 22);
            panel6.Name = "panel6";
            panel6.Size = new Size(20, 20);
            panel6.TabIndex = 3;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1360, 770);
            Controls.Add(panel2);
            Controls.Add(options);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            btnStart.ResumeLayout(false);
            options.ResumeLayout(false);
            options.PerformLayout();
            notesOptions.ResumeLayout(false);
            notesOptions.PerformLayout();
            powerOff.ResumeLayout(false);
            powerOff.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel btnStart;
        private Panel iconStart;
        private Panel options;
        private Panel powerOff;
        private Label label1;
        private Panel panel3;
        private Panel notesOptions;
        private Panel panel5;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Panel panel6;
        private Panel panel4;
    }
}