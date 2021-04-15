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
    public partial class FormDeleteAccount : Form
    {
        public FormDeleteAccount()
        {
            InitializeComponent();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Konto zostało trwale, nieodwracalnie usunięte");
            this.Close();
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
