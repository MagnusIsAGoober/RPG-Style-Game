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
            gbGameView = new GroupBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            tblActionLayout.SuspendLayout();
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
            Title.Text = "My Epic RPG";
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
            tblActionLayout.Location = new Point(28, 323);
            tblActionLayout.Name = "tblActionLayout";
            tblActionLayout.RowCount = 2;
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblActionLayout.Size = new Size(523, 53);
            tblActionLayout.TabIndex = 3;
            tblActionLayout.Visible = false;
            // 
            // btnGuard
            // 
            btnGuard.Dock = DockStyle.Fill;
            btnGuard.Location = new Point(3, 29);
            btnGuard.Name = "btnGuard";
            btnGuard.Size = new Size(255, 21);
            btnGuard.TabIndex = 3;
            btnGuard.Text = "Guard";
            btnGuard.UseVisualStyleBackColor = true;
            // 
            // btnHeal
            // 
            btnHeal.Dock = DockStyle.Fill;
            btnHeal.Location = new Point(264, 29);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(256, 21);
            btnHeal.TabIndex = 2;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = true;
            // 
            // BtnAttack
            // 
            BtnAttack.Dock = DockStyle.Fill;
            BtnAttack.Location = new Point(3, 3);
            BtnAttack.Name = "BtnAttack";
            BtnAttack.Size = new Size(255, 20);
            BtnAttack.TabIndex = 0;
            BtnAttack.Text = "Attack";
            BtnAttack.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            btnMulti.Dock = DockStyle.Fill;
            btnMulti.Location = new Point(264, 3);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(256, 20);
            btnMulti.TabIndex = 1;
            btnMulti.Text = "Multi";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // gbGameView
            // 
            gbGameView.Controls.Add(textBox1);
            gbGameView.Controls.Add(tblActionLayout);
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.ForeColor = Color.Ivory;
            textBox1.Location = new Point(28, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(523, 295);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(805, 450);
            Controls.Add(gbGameView);
            Controls.Add(StartGameBtn);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Title";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            tblActionLayout.ResumeLayout(false);
            gbGameView.ResumeLayout(false);
            gbGameView.PerformLayout();
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
        private GroupBox gbGameView;
        private System.Windows.Forms.Timer GameTimer;
        private TextBox textBox1;
    }
}