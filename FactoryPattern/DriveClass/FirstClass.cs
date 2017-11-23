using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.DriveClass
{
    public class FirstClass : BaseClass
    {
        public int C { get; set; }

        public override string ReturnMe()
        {
            return "I'm first";
        }
    }
}
