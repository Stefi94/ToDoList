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
    public partial class FormDeleteAccount : Form
    {
        private bool deleteOrNot;
        public FormDeleteAccount()
        {
            InitializeComponent();
        }
        public bool DeleteOrNot()
        {
            return deleteOrNot;
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var user = new User_();
            if (user.RemoveUser(textBoxLogin.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Konto zostało trwale, nieodwracalnie usunięte");
                LoggedUser.UserLogOut();
                deleteOrNot = true;
                this.Close();
            }
            else
            {
              
                MessageBox.Show("Nie udało się usunąć konta, być może takie konto nie istnieje lub wpisałeś złe hasło");
                deleteOrNot = false;
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
