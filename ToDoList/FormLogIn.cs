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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }
       

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var logIn = new User_();
            logIn.LogIn(textBoxLogin.Text,textBoxPassword.Text);
            if(LoggedUser.UserIsLogged)
            this.Close();
        }
    }
}
