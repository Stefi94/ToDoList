using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.db_ToDoList;

namespace ToDoList.Services
{
    public class Category_
    {
        public bool AddCategory(string nameCategory) { 

            if (CheckCategory(nameCategory)) {

                return false; //I can't add
            }
            else {
                using(var context = new Context())
                {
                    var category = new Categories() { CategoryName = nameCategory };
                    context.Categories.Add(category);
                    context.SaveChanges();
                }

                return true; //I can add new categ.
            }
        }
        public void EditCategory() { //todo ciało metody edytuj kategorie
        }
        public void RemoveCategory() { //todo ciało metody usuń kategorię, usuń tylko jesli nigdzie nie występuje
            
        }
        private bool CheckCategory(string nameCategory)
        {
            using (var context = new Context())
            {
                if (context.Categories.Where(x => x.CategoryName.ToUpper() == nameCategory.ToUpper()).Any())
                    return true;
                else
                    return false;
            }
        }
    }
}
