
namespace ToDoList
{
    partial class FormRegister
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordRepeat = new System.Windows.Forms.Label();
            this.labelLoginRepeat = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxLoginRepeat = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(76, 72);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(106, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Podaj login lub e-mail";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(76, 169);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Podaj hasło";
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.AutoSize = true;
            this.labelPasswordRepeat.Location = new System.Drawing.Point(76, 220);
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(75, 13);
            this.labelPasswordRepeat.TabIndex = 2;
            this.labelPasswordRepeat.Text = "Powtórz hasło";
            // 
            // labelLoginRepeat
            // 
            this.labelLoginRepeat.AutoSize = true;
            this.labelLoginRepeat.Location = new System.Drawing.Point(76, 119);
            this.labelLoginRepeat.Name = "labelLoginRepeat";
            this.labelLoginRepeat.Size = new System.Drawing.Size(117, 13);
            this.labelLoginRepeat.TabIndex = 3;
            this.labelLoginRepeat.Text = "Powtórz login lub e-mail";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(197, 287);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(110, 59);
            this.buttonRegistration.TabIndex = 4;
            this.buttonRegistration.Text = "Zarejestruj nowego użytkownika";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(261, 72);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(162, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxLoginRepeat
            // 
            this.textBoxLoginRepeat.Location = new System.Drawing.Point(261, 119);
            this.textBoxLoginRepeat.Name = "textBoxLoginRepeat";
            this.textBoxLoginRepeat.Size = new System.Drawing.Size(162, 20);
            this.textBoxLoginRepeat.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(261, 162);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(162, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxPasswordRepeat
            // 
            this.textBoxPasswordRepeat.Location = new System.Drawing.Point(261, 213);
            this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            this.textBoxPasswordRepeat.PasswordChar = '*';
            this.textBoxPasswordRepeat.Size = new System.Drawing.Size(162, 20);
            this.textBoxPasswordRepeat.TabIndex = 8;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 411);
            this.Controls.Add(this.textBoxPasswordRepeat);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLoginRepeat);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.labelLoginRepeat);
            this.Controls.Add(this.labelPasswordRepeat);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Name = "FormRegister";
            this.Text = "Zarejestruj nowego użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordRepeat;
        private System.Windows.Forms.Label labelLoginRepeat;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxLoginRepeat;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordRepeat;
    }
}