using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class math
    {
        public int timesTwo(int input)
        {
            return input * 2;
        }

        public int timesFive(int input)
        {
            return input * 5;
        }

        public int timesTen(int input)
        {
            return input * 10;
        }

        public int timesTen(decimal input)
        {
            return Convert.ToInt32(input * 10);
        }

        public int timesTen(string input)
        {
            return Convert.ToInt32(input) * 10;
        }



    }
}
