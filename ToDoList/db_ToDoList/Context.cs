using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.db_ToDoList
{
    public class Context : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Users> Users { get; set; }


        public Context() : base("Server=(localdb)\\mssqllocaldb;Database=MvcMovieContext-2;Trusted_Connection=True;MultipleActiveResultSets=true")
        {

        }

    }
}
