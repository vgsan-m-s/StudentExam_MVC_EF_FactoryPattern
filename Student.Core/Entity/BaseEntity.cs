using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Core.Entity
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
