using Student.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.EntityFramework
{
    public class StudentDBContext : DbContext
    {
        public DbSet<StudentInfo> Students { get; set; }

        public StudentDBContext() : base("name=DefaultConnection") 
        {
        }
    }
}
