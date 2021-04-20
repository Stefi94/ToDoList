using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
   public static class LoggedUser
    {
        public static bool UserIsLogged { get; private set; } = false;
        public static string UserLogin { get; set; } = null;
        public static int? UserID { get; set; } = null;
        
        public static void UserLogOut()
        {
            UserIsLogged = false;
            UserLogin = null;
            UserID = null;
        }

      
        public static void SetUser(string login, int? userID)
        {
            UserIsLogged = true;
            UserLogin = login;
            UserID = userID;

        }


    }
}
