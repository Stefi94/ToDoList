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
            string nameCategory = textBoxNameCategory.Text.Replace(" ", "");

            if(btnAddEditDelCat.Text == "Dodaj")
            {
                nameCategory.Trim();
                if (category.AddCategory(nameCategory))
                {
                    if(!string.IsNullOrWhiteSpace(nameCategory))
                    {

                    }
                    if (nameCategory.Length > 3)
                    {
                        MessageBox.Show("Dodałeś nową kategorię");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Nazwa kategori musi mieć conajmniej 4 znaki");

                }
                else
                    MessageBox.Show("Podana kategoria już istnieje w bazie, nie dodano jej drugi raz");
            }
            if (btnAddEditDelCat.Text == "Edytuj") 
            {

                MessageBox.Show("Edytowałeś kategorię");
               
                this.Close();
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
