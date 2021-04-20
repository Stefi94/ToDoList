using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.db_ToDoList;
using ToDoList.Services;

namespace ToDoList
{
    public partial class FormMainWindow : Form
    {
        private string buttonCategory;
        private int ordinalNumber = 1;
        public FormMainWindow()
        {
            InitializeComponent();
            var formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
            if (LoggedUser.UserIsLogged)
            {
                labelWhoIsLogged.Text = "Zalogowany jako " + LoggedUser.UserLogin;
                labelWhoIsLogged.ForeColor = Color.Green;
                ShowListTask();
            }
        }

        private void ShowListTask()
        {
            Task_ list = new Task_();
            List<Tasks> taskList =  list.FindTask();
            foreach (var elem in taskList)
            {
                var element = new ListViewItem(new string[] {ordinalNumber++.ToString(),elem.Category.CategoryName, elem.Title, elem.Content, elem.CreateDate.ToString(), elem.DateLimit.ToString() } );
                listViewTask.Items.Add(element);
            }
        }
       
 
      
        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wyloguj",  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoggedUser.UserLogOut();
                listViewTask.Items.Clear();
                labelWhoIsLogged.Text = "Użytkownik został wylogowany";
                labelWhoIsLogged.ForeColor = Color.Red;
                var formLogIn = new FormLogIn();
                formLogIn.ShowDialog();
                if (LoggedUser.UserIsLogged)
                {
                    labelWhoIsLogged.Text = "Zalogowany jako " + LoggedUser.UserLogin;
                    labelWhoIsLogged.ForeColor = Color.Green;
                    ShowListTask();
                }

            }
        }

        private void LogOutAndCloseProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "Czy na pewno chcesz się wylogować i zamknąć program?", "Wyloguj i zamknij", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoggedUser.UserLogOut();
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

        private void AddTaskRepeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo stworzyć form dla dodawania nowych powtarzających się zadań
            // np raz w tygodniu, ile razy powtórzyć, raz w miesiącu, codziennie, co parę dni, np co dwa 5 dni itp.
            // zastanawiam sie jak rozwiązać nietypową częstotliwość, np poniedziałek i środa, albo wtorek i niedziela
            //użytkownik musi podać liczbę lub wybrać z listy ile razy należy powtórzyć zadanie
        }

        private void AddTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo dodaj nowe zadanie  wywołuje tą samą metodę co button btnAddTask
            //todo okienko form dla zwykłych zadań
        }

        private void btnShowEdit_Click(object sender, EventArgs e)
        {

        }


        private void btnShowEdit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
