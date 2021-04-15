
namespace ToDoList
{
    partial class FormChangePassword
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelNewPasswordRepeat = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPasswordRepeat = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(190, 315);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "Zmień hasło";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(309, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Location = new System.Drawing.Point(55, 81);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(62, 13);
            this.labelOldPassword.TabIndex = 2;
            this.labelOldPassword.Text = "Stare hasło";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(55, 126);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(65, 13);
            this.labelNewPassword.TabIndex = 3;
            this.labelNewPassword.Text = "Nowe hasło";
            // 
            // labelNewPasswordRepeat
            // 
            this.labelNewPasswordRepeat.AutoSize = true;
            this.labelNewPasswordRepeat.Location = new System.Drawing.Point(55, 175);
            this.labelNewPasswordRepeat.Name = "labelNewPasswordRepeat";
            this.labelNewPasswordRepeat.Size = new System.Drawing.Size(104, 13);
            this.labelNewPasswordRepeat.TabIndex = 4;
            this.labelNewPasswordRepeat.Text = "Powtórz nowe hasło";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(190, 74);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(157, 20);
            this.textBoxOldPassword.TabIndex = 5;
            // 
            // textBoxNewPasswordRepeat
            // 
            this.textBoxNewPasswordRepeat.Location = new System.Drawing.Point(190, 172);
            this.textBoxNewPasswordRepeat.Name = "textBoxNewPasswordRepeat";
            this.textBoxNewPasswordRepeat.PasswordChar = '*';
            this.textBoxNewPasswordRepeat.Size = new System.Drawing.Size(157, 20);
            this.textBoxNewPasswordRepeat.TabIndex = 6;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(190, 123);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(157, 20);
            this.textBoxNewPassword.TabIndex = 7;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 378);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewPasswordRepeat);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.labelNewPasswordRepeat);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelOldPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangePassword);
            this.Name = "FormChangePassword";
            this.Text = "Zmień hasło";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelNewPasswordRepeat;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewPasswordRepeat;
        private System.Windows.Forms.TextBox textBoxNewPassword;
    }
}