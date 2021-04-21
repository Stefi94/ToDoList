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
    public partial class FormChangeLogin : Form
    {
        public FormChangeLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeLogin_Click(object sender, EventArgs e)
        {
            if (LoggedUser.UserIsLogged)
            {
                if (textBoxNewLogin.Text.Equals(textBoxNewLoginRepeat.Text))
                {
                    if (textBoxNewLogin.Text.Length > 7)
                    {
                        var changeLogin = new User_();
                        if (changeLogin.ChangeNameUser(textBoxNewLogin.Text, textBoxPassword.Text))
                            this.Close();
                    }
                    else
                        MessageBox.Show("Nowy login musi mieć conajmniej 8 znaków");
                }
                else
                    MessageBox.Show("Musisz podać dwa razy taki sam login");

            }
            else
            {
                MessageBox.Show("Aby zmienić login, musisz być zalogowany");
                this.Close();
            }
        }
    }
}
