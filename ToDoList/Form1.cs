using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class FormMainWindow : Form
    {
        private string buttonCategory;
        public FormMainWindow()
        {
            InitializeComponent();
            var formLogIn = new FormLogIn();
            formLogIn.ShowDialog();

        }

   

      
        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wyloguj",  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //wylogowanie

            }
        }

        private void LogOutAndCloseProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "Czy na pewno chcesz się wylogować i zamknąć program?", "Wyloguj i zamknij", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //wylogowanie
                this.Close();
            }
        }

        private void ChangeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formChangeLogin = new FormChangeLogin();
            formChangeLogin.ShowDialog();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formChangePassword = new FormChangePassword();
            formChangePassword.ShowDialog();
        }

        private void DeleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDeleteAccount = new FormDeleteAccount();
            formDeleteAccount.ShowDialog();
        }

        private void AddCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCategory = "Dodaj";
            ShowCategory(buttonCategory);
            
        }

        private void EditCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCategory = "Edytuj";
            ShowCategory(buttonCategory);

        }

        private void DeleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCategory = "Usuń";
            ShowCategory(buttonCategory);

        }
        private void ShowCategory(string Action)
        {
            var formCategory = new FormCategory(Action);
            formCategory.ShowDialog();
        }
    }
}
