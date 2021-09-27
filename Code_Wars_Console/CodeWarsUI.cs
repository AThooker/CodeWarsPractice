using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars_Console
{
    public class CodeWarsUI
    {
        static void Main(string[] args)
        {
            CodeWarsUI console = new CodeWarsUI();
            //Console.WriteLine(console.IsSquare(25));
            //Console.WriteLine(console.AddBinarySum(3,4));
            //Console.WriteLine(console.IsTriangle(1,2,3));
            //Console.WriteLine(console.DuplicateEncode("abnsoooo"));
            //Console.WriteLine(console.XorOTester("jfal;gjjg"));
            //Console.WriteLine(console.IsIsogram("shouldGiveUsFalse"));
            //string[] walkDirections = { "n", "s", "n", "s", "n", "s", "n", "s", "n", "n"};
            //Console.WriteLine(walkDirections.Length);
            //Console.WriteLine(console.WalkChallenge(walkDirections));
            Console.WriteLine(console.HighAndLow("1 3 9 4 5 -5 -50 347 25"));
            Console.ReadLine();
        }
        public bool IsSquare(int n)
        {
            //Is n square or nah
            return Math.Sqrt(n) % 1 == 0;
        }

        //Take in two integers and return their sum in binary value (i.e. 4,6 would return 1010)
        public string AddBinarySum(int x, int y)
        {
            //int sum = x + y;
            //string binaryNum = Convert.ToString(sum, 2);
            //return binaryNum;
            return Convert.ToString(x + y, 2);
        }

        //if friend has 4 letters in their name, return a list with their name on it
        public IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> friends = new List<string>();
            foreach (var name in names)
            {
                if (name.Length == 4)
                {
                    friends.Add(name);
                }
            }
            return friends;
        }

        //Takes in three int, return true if triangle can be built with sides of given int's, must be greater than 0
        public bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c && a + c > b && b + c > a);
            //if(a <= 0 || b <= 0 || c <= 0)
            //{
            //    return false;
            //}
            //return a + b > c && a + c > b && b + c > a;
        }

        //convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string
        public string DuplicateEncode(string word)
        {
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }

        //Method to test if string has the same amount of X's and O's. Case insensitive and string can contain any char

        public bool XorOTester(string input)
        {
            return input.ToLower().Count(x => x == 'x') == input.ToLower().Count(o => o == 'o');
            //int xCount = 0;
            //int oCount = 0;
            //string lowInput = input.ToLower();
            //foreach (char letter in lowInput)
            //{
            //    if (letter == 'x')
            //    {
            //        xCount += 1;
            //    }
            //    else if (letter == 'o')
            //    {
            //        oCount += 1;
            //    }
            //}
            //return xCount == oCount;
        }

        //Test if string is isogram (word or string containing only unique characters)

        public bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() < str.Length ? true : false;
            //char[] lowerString = str.ToLower().ToCharArray();
            //foreach (char letter in lowerString)
            //{
            //    int count = 0;
            //    for (int i = 0; i < lowerString.Length - 1; i++)
            //    {
            //        if (letter == lowerString[i])
            //        {
            //            count++;
            //            if (count > 1)
            //            {
            //                return false;
            //            }
            //        }
            //    }
            //}
            //return true;
        }

        //Take in a string array of one letter words representing directions, each directions takes one minute to walk, determine if the walk takes exactly 10 minutes, if so, return true. You have to end up back at the same place (there has to be the same amount of norths as souths, same for easts/wests
        public bool WalkChallenge(string[] walk)
        {
            int northCount = walk.Count(n => n == "n");
            int southCount = walk.Count(s => s == "s");
            int eastCount = walk.Count(e => e == "e");
            int westCount = walk.Count(w => w == "w");

            return northCount == southCount && eastCount == westCount && walk.Length == 10;

        }

        //Given string of spaced numbers, have to return highest and lowest in a new string, output must be two numbers separated by single space (highest num first)

        public string HighAndLow(string numbers)
        {
            //Kata answer below just performs code lines 135/136 together
            string[] newStringArray = numbers.Split(' ');
            int[] intArray = Array.ConvertAll(newStringArray, s => int.Parse(s));
            return $"{intArray.Max()} {intArray.Min()}";

            //Kata answer
            //var splitAndParsed = numbers.Split().Select(int.Parse);
            //return splitAndParsed.Max() + " " + splitAndParsed.Min();
        }

    }
}
