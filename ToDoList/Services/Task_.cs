using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ToDoList.db_ToDoList;

namespace ToDoList.Services
{
    public class Task_
    {
        public void AddTask() { //todo metoda dodaj zadanie
        }
        public void RemoveTask() { //todo metoda usuń zadanie
        }
        public void EditTask() { //todo metoda edytuj zadanie
            //pobierz do okna (tego samego formularza co dodajesz zadanie) i w nim edytuj
        }
        public List<Tasks> FindTask() { //todo metoda znajdz zadanie albo będzie przyjmować różne parametry, albo będzie przeciążana
          using(var context = new Context())
            {
                var tasksList = context.Tasks.Where(x => x.ID_User_FK == LoggedUser.UserID).Include(x => x.Category).ToList();
                return tasksList;
            }
        }

        //todo kilka nowych metod dodaj zadania powtarzające się
        //todo metoda usuń wszystkie zadania
        //todo metoda usuń wszystkie zrealizowane zadania
        //todo metoda usuń zadania z przedziału czasu (np. od 2021.01.01 do 2021.01.31)
    }
}
