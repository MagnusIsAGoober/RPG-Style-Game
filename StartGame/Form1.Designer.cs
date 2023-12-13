﻿namespace StartGame
{
    partial class FormMain
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
            lblHealth = new Label();
            pbHealth = new ProgressBar();
            tbGameLog = new RichTextBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            TextColorDialogue = new ColorDialog();
            tblActionLayout.SuspendLayout();
            gbGameView.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Showcard Gothic", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.CornflowerBlue;
            Title.Location = new Point(508, 9);
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
            StartGameBtn.Location = new Point(601, 66);
            StartGameBtn.Name = "StartGameBtn";
            StartGameBtn.Size = new Size(149, 36);
            StartGameBtn.TabIndex = 1;
            StartGameBtn.Text = "Start Game";
            StartGameBtn.UseVisualStyleBackColor = true;
            StartGameBtn.Click += StartGameBtn_Click;
            // 
            // tblActionLayout
            // 
            tblActionLayout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblActionLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblActionLayout.ColumnCount = 2;
            tblActionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActionLayout.Controls.Add(btnGuard, 0, 1);
            tblActionLayout.Controls.Add(btnHeal, 0, 1);
            tblActionLayout.Controls.Add(BtnAttack, 0, 0);
            tblActionLayout.Controls.Add(btnMulti, 1, 0);
            tblActionLayout.Location = new Point(221, 156);
            tblActionLayout.Name = "tblActionLayout";
            tblActionLayout.RowCount = 2;
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblActionLayout.Size = new Size(900, 81);
            tblActionLayout.TabIndex = 3;
            tblActionLayout.Visible = false;
            // 
            // btnGuard
            // 
            btnGuard.Dock = DockStyle.Fill;
            btnGuard.Location = new Point(3, 43);
            btnGuard.Name = "btnGuard";
            btnGuard.Size = new Size(444, 35);
            btnGuard.TabIndex = 3;
            btnGuard.Text = "Guard";
            btnGuard.UseVisualStyleBackColor = true;
            btnGuard.Click += btnGuard_Click;
            // 
            // btnHeal
            // 
            btnHeal.Dock = DockStyle.Fill;
            btnHeal.Location = new Point(453, 43);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(444, 35);
            btnHeal.TabIndex = 2;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = true;
            btnHeal.Click += btnHeal_Click;
            // 
            // BtnAttack
            // 
            BtnAttack.Dock = DockStyle.Fill;
            BtnAttack.Location = new Point(3, 3);
            BtnAttack.Name = "BtnAttack";
            BtnAttack.Size = new Size(444, 34);
            BtnAttack.TabIndex = 0;
            BtnAttack.Text = "Attack";
            BtnAttack.UseVisualStyleBackColor = true;
            BtnAttack.Click += BtnAttack_Click;
            // 
            // btnMulti
            // 
            btnMulti.Dock = DockStyle.Fill;
            btnMulti.Location = new Point(453, 3);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(444, 34);
            btnMulti.TabIndex = 1;
            btnMulti.Text = "Multi";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // gbGameView
            // 
            gbGameView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbGameView.Controls.Add(lblHealth);
            gbGameView.Controls.Add(pbHealth);
            gbGameView.Controls.Add(tblActionLayout);
            gbGameView.Controls.Add(tbGameLog);
            gbGameView.Location = new Point(12, 338);
            gbGameView.Name = "gbGameView";
            gbGameView.Size = new Size(1331, 243);
            gbGameView.TabIndex = 8;
            gbGameView.TabStop = false;
            gbGameView.Text = "gbGameView";
            gbGameView.Visible = false;
            gbGameView.TextChanged += gbGameView_TextChanged;
            // 
            // lblHealth
            // 
            lblHealth.Anchor = AnchorStyles.Bottom;
            lblHealth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHealth.ForeColor = Color.Lime;
            lblHealth.Location = new Point(1155, 160);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(149, 33);
            lblHealth.TabIndex = 10;
            lblHealth.Text = "HEALTH";
            lblHealth.TextAlign = ContentAlignment.MiddleCenter;
            lblHealth.Visible = false;
            // 
            // pbHealth
            // 
            pbHealth.Anchor = AnchorStyles.Bottom;
            pbHealth.ForeColor = Color.FromArgb(128, 255, 128);
            pbHealth.Location = new Point(1155, 196);
            pbHealth.Name = "pbHealth";
            pbHealth.Size = new Size(149, 23);
            pbHealth.TabIndex = 9;
            pbHealth.Value = 100;
            pbHealth.Visible = false;
            // 
            // tbGameLog
            // 
            tbGameLog.Anchor = AnchorStyles.Bottom;
            tbGameLog.BackColor = SystemColors.InactiveCaptionText;
            tbGameLog.BorderStyle = BorderStyle.FixedSingle;
            tbGameLog.ForeColor = SystemColors.Menu;
            tbGameLog.Location = new Point(36, 15);
            tbGameLog.Name = "tbGameLog";
            tbGameLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            tbGameLog.Size = new Size(1259, 135);
            tbGameLog.TabIndex = 11;
            tbGameLog.Text = "";
            tbGameLog.ZoomFactor = 2F;
            tbGameLog.TextChanged += richTextBox1_TextChanged;
            // 
            // GameTimer
            // 
            GameTimer.Tick += MainTimerEvent;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1355, 593);
            Controls.Add(gbGameView);
            Controls.Add(StartGameBtn);
            Controls.Add(Title);
            Name = "FormMain";
            Text = "MainGame";
            Load += FormMain_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            tblActionLayout.ResumeLayout(false);
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
        private GroupBox gbGameView;
        private System.Windows.Forms.Timer GameTimer;
        private ProgressBar pbHealth;
        private Label lblHealth;
        private RichTextBox tbGameLog;
        private ColorDialog TextColorDialogue;
    }
}