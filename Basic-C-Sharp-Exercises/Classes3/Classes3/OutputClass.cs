using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class OutputClass
    {
        // void method that outputs an integer
        public void method1 (int num, out int numHalved) 
        {
            numHalved = num / 2;
        }

        // method with output parameters
        public void method2 (int num, out int plusTwo, out int plusThree)
        {
            plusTwo = num + 2;
            plusThree = num + 3;
        }

        // overload a method
        public int method3(int num1)
        {
            return num1 * 2;
        }

        public int method3(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
