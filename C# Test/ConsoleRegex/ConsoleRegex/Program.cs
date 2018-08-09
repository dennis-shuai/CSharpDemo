using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "abc123abc";
            string pattern ="abc";
            Console.WriteLine(Regex.IsMatch(s1, pattern));

            string[] values = { "111-22-3333", "111-2-3333" };
            pattern = @"^\d{3}-\d{2}-\d{4}$";
            foreach(var val in values)
            {
                if (Regex.IsMatch(val,pattern))
                {
                    Console.WriteLine("{0} is match pattern",val);
                }else
                    Console.WriteLine("{0} is not match pattern", val);
            }

            RegexMatch();
            RegexReplace();
            RegexSplit();
            Matchs();
            Console.ReadLine();
        }
        static void RegexMatch()
        {
            var input = "This is jikexueyuan jikexueyuan !";
            var pattern = @"\b(\w+)\w(\1)\b";
            Match match = Regex.Match(input, pattern);

            while (match.Success)
            {
                Console.WriteLine("duplication {0} found ",match.Groups[1].Value);
                match = match.NextMatch();

            }
        }
        static void RegexReplace()
        {
            var input = "total cost: 103.64";
            var pattern = @"\b\d+\.\d{2}\b";
            string replacement = "$$$&";
            Console.WriteLine( Regex.Replace(input, pattern,replacement));

            
        }
        static void RegexSplit()
        {
            var input = "1. Egg 2. Bread 3. Milk 4. Coffee";
            var pattern = @"\b\d{1,2}\.\s";
            foreach ( string item in Regex.Split(input,pattern))
            {
                if(!String.IsNullOrEmpty(item))
                {

                    Console.WriteLine(item);
                }
            }
          
        }

        static void Matchs()
        {
            MatchCollection matches;
            Regex r = new Regex("abc");
            matches =r.Matches("abc123abc");
            foreach(Match ma in matches)
            {
                Console.WriteLine("{0} found in index {1}", ma.Value, ma.Index);
            }

        }


    }
}
