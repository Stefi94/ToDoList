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
               if( !context.Users.Where(x => x.Login == login).Any())
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
            if (CheckLogin(login))
            {
                using (var context = new Context())
                {
                         
                    var userID = context.Users.Where(x=> x.Login == login && x.Password == password).Select(x => x.ID_User).FirstOrDefault();
                    if (userID != 0)
                    {
                        LoggedUser.SetUser(login, userID);         
                    }
                    else
                    MessageBox.Show( "Złe hasło");
                }
            }
            else
                MessageBox.Show("Nie ma takiego użytkownika");
        
        }
        public void LogOut() {
            LoggedUser.UserLogOut();
                
        }
        public void RemoveUser() { }
        public void ChangePassword() { }
        public void ChangeNameUser() { }
    }
}
