using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Core.Entity
{
    [Table("Student")]
    public class StudentInfo : BaseEntity
    {
        [Index(IsUnique = true)]
        [MaxLength(20)]
        public string Code { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
