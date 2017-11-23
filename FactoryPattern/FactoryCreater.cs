using FactoryPattern.DriveClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FactoryCreater
    {
        /// <summary>
        /// Function Excuter : For Sample
        /// </summary>
        public void ExcuteFunction()
        {
            // Creating first class object using factory create method
            BaseClass factoryFirstObj = this.CreateandReturnObj(FoctoryObjects.First);
            factoryFirstObj.ReturnMe();

            // Getting first class property value.
            FirstClass firstObj = new FirstClass();
            int firstNumber = firstObj.C;
        }


        /// <summary>
        /// Factory Creator Method
        /// </summary>
        /// <param name="foctoryObjects">Factory Drive Class Enum</param>
        /// <returns></returns>
        public BaseClass CreateandReturnObj(FoctoryObjects foctoryObjects)
        {
            BaseClass baseObj = null;

            switch (foctoryObjects)
            {
                case FoctoryObjects.First:
                    baseObj = new FirstClass();
                    break;
                case FoctoryObjects.Second:
                    baseObj = new SecondClass();
                    break;
                case FoctoryObjects.Thired:
                    baseObj = new ThiredClass();
                    break;
                case FoctoryObjects.Forth:
                    baseObj = new ForthClass();
                    break;
            }
            return baseObj;
        }
    }
}
