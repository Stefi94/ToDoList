
namespace ToDoList
{
    partial class FormChangeLogin
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
            this.btnChangeLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelNewLogin = new System.Windows.Forms.Label();
            this.labelNewLoginRepeat = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxNewLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewLoginRepeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChangeLogin
            // 
            this.btnChangeLogin.Location = new System.Drawing.Point(163, 237);
            this.btnChangeLogin.Name = "btnChangeLogin";
            this.btnChangeLogin.Size = new System.Drawing.Size(75, 23);
            this.btnChangeLogin.TabIndex = 0;
            this.btnChangeLogin.Text = "Zmień login";
            this.btnChangeLogin.UseVisualStyleBackColor = true;
            this.btnChangeLogin.Click += new System.EventHandler(this.btnChangeLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelNewLogin
            // 
            this.labelNewLogin.AutoSize = true;
            this.labelNewLogin.Location = new System.Drawing.Point(61, 45);
            this.labelNewLogin.Name = "labelNewLogin";
            this.labelNewLogin.Size = new System.Drawing.Size(87, 13);
            this.labelNewLogin.TabIndex = 2;
            this.labelNewLogin.Text = "Podaj nowy login";
            // 
            // labelNewLoginRepeat
            // 
            this.labelNewLoginRepeat.AutoSize = true;
            this.labelNewLoginRepeat.Location = new System.Drawing.Point(61, 93);
            this.labelNewLoginRepeat.Name = "labelNewLoginRepeat";
            this.labelNewLoginRepeat.Size = new System.Drawing.Size(98, 13);
            this.labelNewLoginRepeat.TabIndex = 3;
            this.labelNewLoginRepeat.Text = "Powtórz nowy login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(61, 143);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Podaj hasło";
            // 
            // textBoxNewLogin
            // 
            this.textBoxNewLogin.Location = new System.Drawing.Point(202, 45);
            this.textBoxNewLogin.Name = "textBoxNewLogin";
            this.textBoxNewLogin.Size = new System.Drawing.Size(153, 20);
            this.textBoxNewLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(202, 140);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(153, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxNewLoginRepeat
            // 
            this.textBoxNewLoginRepeat.Location = new System.Drawing.Point(202, 93);
            this.textBoxNewLoginRepeat.Name = "textBoxNewLoginRepeat";
            this.textBoxNewLoginRepeat.Size = new System.Drawing.Size(153, 20);
            this.textBoxNewLoginRepeat.TabIndex = 7;
            // 
            // FormChangeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 299);
            this.Controls.Add(this.textBoxNewLoginRepeat);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNewLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNewLoginRepeat);
            this.Controls.Add(this.labelNewLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeLogin);
            this.Name = "FormChangeLogin";
            this.Text = "Zmień login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelNewLogin;
        private System.Windows.Forms.Label labelNewLoginRepeat;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNewLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxNewLoginRepeat;
    }
}