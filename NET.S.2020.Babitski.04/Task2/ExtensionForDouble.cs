using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class ExtensionForDouble
    {
        const string formatter = "{0,25:E16}{1,23:X2}";
        public static string ConvertToBitString(this Double number)
        {
            long longvalue = BitConverter.DoubleToInt64Bits(number);
            string str = Convert.ToString(longvalue, 2);
            if (number > 0)
                str = 0 + str;
            return str;
        }
    }
}
