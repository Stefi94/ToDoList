using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Services;

namespace ToDoList
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (LoggedUser.UserIsLogged)
            {
                if (textBoxNewPassword.Text.Equals(textBoxNewPasswordRepeat.Text))
                {
                    if (textBoxNewPassword.Text.Length > 7)
                    {
                        var changePassword = new User_();
                        if (changePassword.ChangePassword(textBoxOldPassword.Text, textBoxNewPassword.Text))
                            this.Close();
                    }
                    else
                        MessageBox.Show("Nowy hasło musi mieć conajmniej 8 znaków");
                }
                else
                    MessageBox.Show("Musisz podać dwa razy takie samo hasło");

            }
            else
            {
                MessageBox.Show("Aby zmienić login, musisz być zalogowany");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
