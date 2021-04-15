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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            // najpierw sprawdza czy taki login istnieje już w bazie
            // porównuje login i hasło z obu textboxów czy użytkownik podał dwa razy to samo
            // rejestruje użytkownika
            // przekazuje login i hasło oraz zamyka okno
            // wykonuje logowanie z przekazanymi parametrami i zamyka okno logowania

            MessageBox.Show("Poprawnie dodano nowego użytkownika");

            this.Close();
        }
    }
}
