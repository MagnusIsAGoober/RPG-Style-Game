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
            Title = new Label();
            StartGameBtn = new Button();
            tblActionLayout = new TableLayoutPanel();
            BtnAttack = new Button();
            tbGameLog = new TextBox();
            btnMulti = new Button();
            btnHeal = new Button();
            btnGuard = new Button();
            tblActionLayout.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(221, 47);
            Title.Name = "Title";
            Title.Size = new Size(348, 54);
            Title.TabIndex = 0;
            Title.Text = "My Epic RPG";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartGameBtn
            // 
            StartGameBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartGameBtn.Location = new Point(317, 311);
            StartGameBtn.Name = "StartGameBtn";
            StartGameBtn.Size = new Size(149, 36);
            StartGameBtn.TabIndex = 1;
            StartGameBtn.Text = "Start Game";
            StartGameBtn.UseVisualStyleBackColor = true;
            StartGameBtn.Click += StartGameBtn_Click;
            // 
            // tblActionLayout
            // 
            tblActionLayout.ColumnCount = 2;
            tblActionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActionLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActionLayout.Controls.Add(btnGuard, 0, 1);
            tblActionLayout.Controls.Add(btnHeal, 0, 1);
            tblActionLayout.Controls.Add(BtnAttack, 0, 0);
            tblActionLayout.Controls.Add(btnMulti, 1, 0);
            tblActionLayout.Dock = DockStyle.Bottom;
            tblActionLayout.Location = new Point(0, 365);
            tblActionLayout.Name = "tblActionLayout";
            tblActionLayout.RowCount = 2;
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblActionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblActionLayout.Size = new Size(800, 85);
            tblActionLayout.TabIndex = 3;
            tblActionLayout.Visible = false;
            // 
            // BtnAttack
            // 
            BtnAttack.Dock = DockStyle.Fill;
            BtnAttack.Location = new Point(3, 3);
            BtnAttack.Name = "BtnAttack";
            BtnAttack.Size = new Size(394, 36);
            BtnAttack.TabIndex = 0;
            BtnAttack.Text = "Attack";
            BtnAttack.UseVisualStyleBackColor = true;
            // 
            // tbGameLog
            // 
            tbGameLog.BackColor = SystemColors.ScrollBar;
            tbGameLog.Font = new Font("Trebuchet MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbGameLog.ForeColor = SystemColors.WindowText;
            tbGameLog.Location = new Point(123, 104);
            tbGameLog.Multiline = true;
            tbGameLog.Name = "tbGameLog";
            tbGameLog.Size = new Size(536, 201);
            tbGameLog.TabIndex = 4;
            // 
            // btnMulti
            // 
            btnMulti.Dock = DockStyle.Fill;
            btnMulti.Location = new Point(403, 3);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(394, 36);
            btnMulti.TabIndex = 1;
            btnMulti.Text = "Multi";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnHeal
            // 
            btnHeal.Dock = DockStyle.Fill;
            btnHeal.Location = new Point(403, 45);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(394, 37);
            btnHeal.TabIndex = 2;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = true;
            // 
            // btnGuard
            // 
            btnGuard.Dock = DockStyle.Fill;
            btnGuard.Location = new Point(3, 45);
            btnGuard.Name = "btnGuard";
            btnGuard.Size = new Size(394, 37);
            btnGuard.TabIndex = 3;
            btnGuard.Text = "Guard";
            btnGuard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbGameLog);
            Controls.Add(tblActionLayout);
            Controls.Add(StartGameBtn);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Title";
            tblActionLayout.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button StartGameBtn;
        private TableLayoutPanel tblActionLayout;
        private Button BtnAttack;
        private TextBox tbGameLog;
        private Button btnGuard;
        private Button btnHeal;
        private Button btnMulti;
    }
}