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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }
        public FormCategory(string buttonCategory)
        {
            InitializeComponent();
            btnAddEditDelCat.Text = buttonCategory;
        }

        private void btnAddEditDelCat_Click(object sender, EventArgs e)
        {
            if(btnAddEditDelCat.Text == "Dodaj")
            {
                MessageBox.Show("Dodałeś nową kategorię");
                this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
