using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.DriveClass
{
    //This is Base Factory Class
    public abstract class BaseClass
    {
        public int A { get; set; }
        public int B { get; set; }

        public abstract string ReturnMe();
    }
}
