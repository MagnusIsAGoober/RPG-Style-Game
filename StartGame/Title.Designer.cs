namespace StartGame
{
    partial class Startup
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
            Title = new Label();
            StartGameBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(211, 47);
            Title.Name = "Title";
            Title.Size = new Size(348, 54);
            Title.TabIndex = 0;
            Title.Text = "My Epic RPG";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartGameBtn
            // 
            StartGameBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartGameBtn.Location = new Point(309, 329);
            StartGameBtn.Name = "StartGameBtn";
            StartGameBtn.Size = new Size(149, 53);
            StartGameBtn.TabIndex = 1;
            StartGameBtn.Text = "Start Game";
            StartGameBtn.UseVisualStyleBackColor = true;
            StartGameBtn.Click += StartGameBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(123, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 189);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(StartGameBtn);
            Controls.Add(Title);
            Name = "Startup";
            Text = "Startup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Button StartGameBtn;
        private PictureBox pictureBox1;
    }
}