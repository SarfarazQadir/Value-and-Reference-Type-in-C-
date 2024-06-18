using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_Reference_Type_in_C_
{
    internal class Student
    {
        public int Calculate_value(int a)
        {
            a = 20 + 89;
            return a;
        }

        public int Calculate_value_byref(ref int b)
        {
            b = b * b;
            return b;
        }
    }
}
