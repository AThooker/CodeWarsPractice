using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars_Console_02
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            var seq = new List<double>(signature);
            if (n == 0) return new double[0];
            for(int i = 3; i <= n; i++)
            {
                seq.Add(seq[i - 1] + seq[i - 2] + seq[i - 3]);
            }
            return seq.Take(n).ToArray();
        }

        public static string ROT13(string s)
        {
            char[] array = s.ToCharArray();
            for(int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];
                if(number >= 'a' && number <= 'z')
                {
                    if(number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if(number >= 'A' && number <= 'Z')
                {
                    if(number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    }
}
