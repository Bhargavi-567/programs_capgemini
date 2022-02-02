using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgemini_programs
{
    class Functionoverload
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }


        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }


        static void Main3(String[] args)
        {

            Functionoverload ob = new Functionoverload();

            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + sum1);

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);
        }
    }
}
