using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.db_ToDoList
{
    [Table("Tasks")]
    public class Tasks
    {
        [Key]
        public int ID_Task { get; set; }
        [ForeignKey("User")]
        public int ID_User_FK { get; set; }
        [ForeignKey("Category")]
        public int ID_Category_FK { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DateLimit { get; set; }

        public Users User { get; set; }
        public Categories Category { get; set; }


    }
}
