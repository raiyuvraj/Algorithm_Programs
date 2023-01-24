using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    internal class Permutations_Of_String
    {
        public static void Permute(string str, string ans)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(ans + " ");
                return;
            }
            for(int i=0; i<str.Length; i++) 
            {
                char ch = str[i];
                string left_substr =str.Substring(0, i);
                string right_substr =str.Substring(i+1);
                string rest = left_substr + right_substr;
                Permute(rest, ans + ch);
            }
        }
        public static void Main(string[] args)
        {
            string str = "XYZ";
            string ans = "";

            Console.WriteLine("\nAll possible permutes are :");
            Permute(str, ans);

        }

    }
}
