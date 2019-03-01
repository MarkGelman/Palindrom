using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
            static void Main()
            {
                int count = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (InputNumber(Console.ReadLine()))
                        count++;
                }
                Console.WriteLine(count);
            }

            static bool InputNumber(string str)
            {
                long num = long.Parse(str);
                long b = 0;
                /*str = str + ".";
                int len = str.IndexOf('.')-1;*/
                long number = num;
                while (number > 0)
                {
                    b = b * 10 + number % 10;
                    number /= 10;
                }
                if (num == b) return true;
                return false;
            }

        
    }
}
