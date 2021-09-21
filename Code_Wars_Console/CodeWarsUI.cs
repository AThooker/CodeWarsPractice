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
            Console.WriteLine(console.AddBinarySum(3,4));
            Console.ReadLine();
        }
        public bool IsSquare(int n)
        {
            //Is n square or nah
            return Math.Sqrt(n) % 1 == 0;
        }
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
    }
}
