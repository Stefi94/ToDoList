using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.db_ToDoList
{

   [Table("Categories")]
   public class Categories
    {
        [Key]
        public int ID_Category { get; set; }
        public string CategoryName { get; set; }

    }
}
