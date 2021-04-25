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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                if (textBoxLogin.Text.Equals(textBoxLoginRepeat.Text) && textBoxPassword.Text.Equals(textBoxPasswordRepeat.Text))
                {
                    if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
                    {
                        if (textBoxLogin.Text.Length >= 8 && textBoxPassword.Text.Length >= 8)
                        {
                            User_ user = new User_();
                            if (user.AddUser(textBoxLogin.Text, textBoxPassword.Text) == true)
                            {

                                MessageBox.Show("Poprawnie dodano nowego użytkownika");

                                this.Close();

                            }
                        }
                        else
                            MessageBox.Show("Login i hasło muszą składać się z conajmniej 8 znaków");
                    }
                    else
                        MessageBox.Show("Pola login i hasło nie mogą być puste");
                }
                else
                    MessageBox.Show("należy podać dwa razy taki sam login i hasło");
            }
            else MessageBox.Show("Login i hasło musi się składać z tekstu");
        }
    }
}
