
namespace ToDoList
{
    partial class FormLogIn
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
            this.labelPasword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(40, 42);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // labelPasword
            // 
            this.labelPasword.AutoSize = true;
            this.labelPasword.Location = new System.Drawing.Point(40, 83);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(39, 13);
            this.labelPasword.TabIndex = 1;
            this.labelPasword.Text = "Hasło:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(113, 42);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(143, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(113, 83);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(143, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(181, 130);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(75, 23);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "Zaloguj";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Location = new System.Drawing.Point(40, 231);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(173, 26);
            this.labelRegister.TabIndex = 5;
            this.labelRegister.Text = "Jeśli nie masz konta, załóż je teraz.\r\nKliknij Zarejestruj się.";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(43, 276);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Zarejestruj się";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 337);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPasword);
            this.Controls.Add(this.labelLogin);
            this.Name = "FormLogIn";
            this.Text = "Zaloguj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPasword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Button buttonRegister;
    }
}