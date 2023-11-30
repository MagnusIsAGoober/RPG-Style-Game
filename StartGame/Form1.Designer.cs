namespace StartGame
{
    partial class Form1
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
            Title = new Label();
            StartGameBtn = new Button();
            tblActionLayout = new TableLayoutPanel();
            btnGuard = new Button();
            btnHeal = new Button();
            BtnAttack = new Button();
            btnMulti = new Button();
            pbLevelView = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            gbGameView = new GroupBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            tblActionLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLevelView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbGameView.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.CornflowerBlue;
            Title.Location = new Point(147, -4);
            Title.Name = "Title";
            Title.Size = new Size(348, 54);
            Title.TabIndex = 0;
            Title.Text = "My Epic Game";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += Title_Click;
            // 
            // StartGameBtn
            // 
            StartGameBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartGameBtn.Location = new Point(623, 23);
            StartGameBtn.Name = "StartGameBtn";
            StartGameBtn.Size = new Size(149, 36);
            StartGameBtn.TabIndex = 1;
            StartGameBtn.Text = "Start Game";
            StartGameBtn.UseVisualStyleBackColor = true;
            StartGameBtn.Click += StartGameBtn_Click;
            // 
            // tblActionLayout
            // 
            tblActionLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblActionLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblActionLayout.ColumnCount = 2;
            tblActionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActionLayout.Controls.Add(btnGuard, 0, 1);
            tblActionLayout.Controls.Add(btnHeal, 0, 1);
            tblActionLayout.Controls.Add(BtnAttack, 0, 0);
            tblActionLayout.Controls.Add(btnMulti, 1, 0);
            tblActionLayout.Location = new Point(644, 126);
            tblActionLayout.Name = "tblActionLayout";
            tblActionLayout.RowCount = 2;
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblActionLayout.Size = new Size(116, 289);
            tblActionLayout.TabIndex = 3;
            tblActionLayout.Visible = false;
            // 
            // btnGuard
            // 
            btnGuard.Dock = DockStyle.Fill;
            btnGuard.Location = new Point(3, 147);
            btnGuard.Name = "btnGuard";
            btnGuard.Size = new Size(52, 139);
            btnGuard.TabIndex = 3;
            btnGuard.Text = "Guard";
            btnGuard.UseVisualStyleBackColor = true;
            // 
            // btnHeal
            // 
            btnHeal.Dock = DockStyle.Fill;
            btnHeal.Location = new Point(61, 147);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(52, 139);
            btnHeal.TabIndex = 2;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = true;
            // 
            // BtnAttack
            // 
            BtnAttack.Dock = DockStyle.Fill;
            BtnAttack.Location = new Point(3, 3);
            BtnAttack.Name = "BtnAttack";
            BtnAttack.Size = new Size(52, 138);
            BtnAttack.TabIndex = 0;
            BtnAttack.Text = "Attack";
            BtnAttack.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            btnMulti.Dock = DockStyle.Fill;
            btnMulti.Location = new Point(61, 3);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(52, 138);
            btnMulti.TabIndex = 1;
            btnMulti.Text = "Multi";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // pbLevelView
            // 
            pbLevelView.BackColor = Color.Black;
            pbLevelView.BorderStyle = BorderStyle.FixedSingle;
            pbLevelView.Location = new Point(9, 21);
            pbLevelView.Name = "pbLevelView";
            pbLevelView.Size = new Size(564, 349);
            pbLevelView.TabIndex = 4;
            pbLevelView.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 192, 128);
            label1.Location = new Point(422, 302);
            label1.Name = "label1";
            label1.Size = new Size(141, 54);
            label1.TabIndex = 5;
            label1.Text = "Health";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 192, 128);
            label2.Location = new Point(20, 302);
            label2.Name = "label2";
            label2.Size = new Size(190, 54);
            label2.TabIndex = 6;
            label2.Text = "Movement";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = MyRPG.Properties.Resources.heart_removebg_preview;
            pictureBox2.Location = new Point(291, 229);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // gbGameView
            // 
            gbGameView.Controls.Add(pictureBox2);
            gbGameView.Controls.Add(label1);
            gbGameView.Controls.Add(label2);
            gbGameView.Controls.Add(pbLevelView);
            gbGameView.Location = new Point(22, 44);
            gbGameView.Name = "gbGameView";
            gbGameView.Size = new Size(579, 382);
            gbGameView.TabIndex = 8;
            gbGameView.TabStop = false;
            gbGameView.Text = "gbGameView";
            gbGameView.Visible = false;
            // 
            // GameTimer
            // 
            GameTimer.Tick += MainTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(805, 450);
            Controls.Add(gbGameView);
            Controls.Add(tblActionLayout);
            Controls.Add(StartGameBtn);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Title";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            tblActionLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLevelView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbGameView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Button StartGameBtn;
        private TableLayoutPanel tblActionLayout;
        private Button BtnAttack;
        private Button btnGuard;
        private Button btnHeal;
        private Button btnMulti;
        private PictureBox pbLevelView;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private GroupBox gbGameView;
        private System.Windows.Forms.Timer GameTimer;
    }
}