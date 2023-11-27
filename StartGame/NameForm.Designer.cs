namespace StartGame
{
    partial class NameForm
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
            BtnConfirmName = new Button();
            txtBoxNameEntry = new TextBox();
            lblEnterName = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // BtnConfirmName
            // 
            BtnConfirmName.Location = new Point(98, 101);
            BtnConfirmName.Name = "BtnConfirmName";
            BtnConfirmName.Size = new Size(75, 23);
            BtnConfirmName.TabIndex = 0;
            BtnConfirmName.Text = "Confirm";
            BtnConfirmName.UseVisualStyleBackColor = true;
            BtnConfirmName.Click += ConfirmBtn_Click;
            // 
            // txtBoxNameEntry
            // 
            txtBoxNameEntry.Location = new Point(12, 57);
            txtBoxNameEntry.Name = "txtBoxNameEntry";
            txtBoxNameEntry.Size = new Size(250, 23);
            txtBoxNameEntry.TabIndex = 1;
            // 
            // lblEnterName
            // 
            lblEnterName.AutoSize = true;
            lblEnterName.Location = new Point(12, 39);
            lblEnterName.Name = "lblEnterName";
            lblEnterName.Size = new Size(72, 15);
            lblEnterName.TabIndex = 2;
            lblEnterName.Text = "Enter Name:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 83);
            lblError.Name = "lblError";
            lblError.Size = new Size(32, 15);
            lblError.TabIndex = 3;
            lblError.Text = "Error";
            // 
            // NameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 147);
            ControlBox = false;
            Controls.Add(lblError);
            Controls.Add(lblEnterName);
            Controls.Add(txtBoxNameEntry);
            Controls.Add(BtnConfirmName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NameForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConfirmName;
        private TextBox txtBoxNameEntry;
        private Label lblEnterName;
        private Label lblError;
    }
}