using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.db_ToDoList
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int ID_User { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
