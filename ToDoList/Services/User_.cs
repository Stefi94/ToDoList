using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.db_ToDoList;

namespace ToDoList.Services
{
    public class User_
    {
        //todo ciała metod w klasie user, wyloguj, usuń użytkownika, zmien login i hasło
        private bool CheckLogin(string login)
        {
            using (var context = new Context())
            {
               if( context.Users.Where(x => x.Login == login).FirstOrDefault() == null)
                    return false; //this login isn't exist in DB
               else
                    return true; //this login is exist in DB
            }
        }

        public bool AddUser(string login, string password) {
            if (CheckLogin(login) == false)
            {
                using (var context = new Context())
                {
                    var user = new Users() { Login = login, Password = password };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                return true;
            }
            else {
                MessageBox.Show($"Podany login: {login} już jest zajęty. Wybierz inny");
                return false;
            }
        }
        public void LogIn(string login, string password) {
            //todo login dokończyć
        
        }
        public void LogOut() { }
        public void RemoveUser() { }
        public void ChangePassword() { }
        public void ChangeNameUser() { }
    }
}
