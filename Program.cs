using System;
using System.Collections.Generic;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }
        }

        private static string twoStrings(string s1, string s2)
        {
            HashSet<char> s1Set= new HashSet<char>();
            foreach (var item in s1.ToCharArray())
            {
                s1Set.Add(item);

            }

            foreach (var item in s2.ToCharArray())
            {
                if (s1Set.Contains(item))
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}
