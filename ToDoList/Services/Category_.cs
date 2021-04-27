using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public bool EditCategory(string oldCategory, string newCategory) {
            if (CheckCategory(newCategory)) {
                return false;
            }
            else
            {
                using(var context = new Context())
                {
                    var editCategory = context.Categories.Where(x => x.CategoryName == oldCategory).FirstOrDefault();
                    if (editCategory != null)
                    {
                        editCategory.CategoryName = newCategory;
                        context.SaveChanges();
                        return true;
                    }
                    else
                        return false;

                }
                
            }

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
        public string CheckText(string nameCategory)
        {
            nameCategory = nameCategory.Trim();
            if (!string.IsNullOrWhiteSpace(nameCategory))
            {
                if (nameCategory.Length > 3)
                {
                    return nameCategory;
                }
                else
                {
                    MessageBox.Show("Nazwa kategorii musi mieć conajmniej 4 znaki");
                    return "";
                }

            }
            else
            {
                MessageBox.Show("Nie można ustawić kategorii z białych znaków.");
                return "";
            }
        }
    }
}
