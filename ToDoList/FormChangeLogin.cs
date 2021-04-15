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
    public partial class FormChangeLogin : Form
    {
        public FormChangeLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeLogin_Click(object sender, EventArgs e)
        {
            //komunikat czy się udało czy nie
            // jesli się udało zamyka okno
            this.Close();
        }
    }
}
