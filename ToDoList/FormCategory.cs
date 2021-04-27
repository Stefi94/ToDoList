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
    public partial class FormCategory : Form
    {
        private Category_ category;
        public FormCategory()
        {
            InitializeComponent();
         
        }
        public FormCategory(string buttonCategory)
        {
            InitializeComponent();
            btnAddEditDelCat.Text = buttonCategory;
            category = new Category_();
            if (btnAddEditDelCat.Text == "Dodaj")
            {
                labelNameCat.Visible = false;
                cbNameCategory.Visible = false;
                this.Text = "Dodaj kategorię";

            }
            else
            {
                labelNameCat.Visible = true;
                cbNameCategory.Visible = true;
                setComboBox();
                this.Text = "Edytuj kategorię";

                if (btnAddEditDelCat.Text == "Usuń")
                {
                    textBoxNameCategory.Visible = false;
                    labelNameCategory.Visible = false;
                    this.Text = "Usuń kategorię";
                }
            }
        }

        private void btnAddEditDelCat_Click(object sender, EventArgs e)
        {
            string nameCategory = textBoxNameCategory.Text;

            if(btnAddEditDelCat.Text == "Dodaj")
            {


                nameCategory = category.CheckText(textBoxNameCategory.Text);

                if (nameCategory != "")
                {
                    if (category.AddCategory(nameCategory))
                    {
                        MessageBox.Show("Dodałeś nową kategorię");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Podana kategoria już istnieje w bazie, nie dodano jej drugi raz");
                }
               
            }
            if (btnAddEditDelCat.Text == "Edytuj") 
            {
                //in this case nameCategory is a new name category
                nameCategory = category.CheckText(textBoxNameCategory.Text);

                if (nameCategory != cbNameCategory.Text)
                    if (nameCategory != "")
                    {
                        //cbNameCategory is a old category name
                        if (category.EditCategory(cbNameCategory.Text, nameCategory))
                        {
                            MessageBox.Show($"Poprawnie zmieniono nazwę kategorii na {nameCategory} ");
                            this.Close();
                        }

                        else
                            MessageBox.Show("nie można zmienić nazwy kategorii, ponieważ podana kategoria już istnieje w bazie");
                    }
                    else
                        MessageBox.Show("Nie wprowadzono żadnych zmian");
                  
               
               
            }
            if(btnAddEditDelCat.Text == "Usuń")
            {
                MessageBox.Show("Usunąłeś kategorię");
                this.Close();
            }
        }
        private void setComboBox()
        {
            using (var context = new Context())
            {
                var listCategory = context.Categories.Where(x => x.ID_Category > 0).Select(x => x.CategoryName).ToArray();
                foreach (var item in listCategory)
                {
                    cbNameCategory.Items.Add(item);
                }
                
            }
          
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNameCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNameCategory.Text = cbNameCategory.Text;

        }
    }
}
