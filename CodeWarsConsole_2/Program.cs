using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Rot13("abcd:zxyw???"));
            //List<object> testList = new List<object>() { "1", 2, "a", 5 };
            //var getList = GetIntegersFromList(testList);
            //foreach (var item in getList)
            //{
            //    Console.WriteLine(item);
            //}
            List<int> numbers = new List<int>() { 1, 1, 1, 4, 1 };
            Console.WriteLine(GetUnique(numbers));
            Console.ReadLine();
        }
        //ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet.ROT13 is an example of the Caesar cipher.

        //Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
        public static string Rot13(string message)
        {
            char[] charArray = message.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                int numValueOfchar = (int)charArray[i];
                if (numValueOfchar >= 'a' && numValueOfchar <= 'z')
                {
                    if (numValueOfchar > 'm')
                    {
                        numValueOfchar -= 13;
                    }
                    else
                    {
                        numValueOfchar += 13;
                    }
                }
                else if (numValueOfchar >= 'A' && numValueOfchar <= 'Z')
                {
                    if (numValueOfchar > 'M')
                    {
                        numValueOfchar -= 13;
                    }
                    else
                    {
                        numValueOfchar += 13;
                    }
                }
                else
                {
                    numValueOfchar = numValueOfchar;
                }
                charArray[i] = (char)numValueOfchar;
            }
            return new string(charArray);
        }

        //In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();

        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            int[] intArray = numbers.ToArray();
            Array.Sort(intArray);
            if (intArray[0] < intArray[intArray.Length - 1] && intArray[0] < intArray[intArray.Length - 2])
            {
                return intArray[0];
            }
            return intArray[intArray.Length - 1];
            //return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }

        public static string EvenOrOdd(int[] array)
        {
            return array.Sum() % 2 == 0 ? "Even" : "Odd";
        }
    }
}
