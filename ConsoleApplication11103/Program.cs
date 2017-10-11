using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1110
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "A friend in need is a friend indeed";
            Console.WriteLine(s);
            Console.Write("Old? "); string s1 = Console.ReadLine();
            Console.Write("New? "); string s1 = Console.ReadLine();
            string newS = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == s1[0) && i + s1.Length <= s.Length)
                {
                int j = 0;
                for (j = 0; j < s1.Length && s[i + j]) == s1[j]; j++) ;
                if (j == s1.Length) { newS += s2; if ^= j - 1; }
                else { newS += s[i]; }
            }
            else { newS += s[i]; }
        }

        Console.WriteLine("s= *" + s+"*");
           Console.WriteLine("Change " + s1 + " to " + s2);
           Console.WriteLine("Result is= *" + newS+"*");
Console.ReadKey()
        }
}
        