namespace MyGame
{
    partial class MainScene
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
            PlayerPictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PlayerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PlayerPictureBox
            // 
            PlayerPictureBox.BackColor = Color.Transparent;
            PlayerPictureBox.Enabled = false;
            PlayerPictureBox.Image = Properties.Resources.heart_removebg_preview;
            PlayerPictureBox.Location = new Point(502, 359);
            PlayerPictureBox.Name = "PlayerPictureBox";
            PlayerPictureBox.Size = new Size(26, 28);
            PlayerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PlayerPictureBox.TabIndex = 5;
            PlayerPictureBox.TabStop = false;
            PlayerPictureBox.Click += pictureBox2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += PerTick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(502, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MainScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1049, 621);
            Controls.Add(pictureBox1);
            Controls.Add(PlayerPictureBox);
            DoubleBuffered = true;
            Name = "MainScene";
            Text = "Main Scene";
            KeyDown += KeyIsPressed;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)PlayerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox PlayerPictureBox;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}