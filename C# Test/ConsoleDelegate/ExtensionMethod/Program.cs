using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public enum Grades { F=0,D=1,C=2,B=3,A=2};
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 45, 52, 3, 8, 12, 1, 36 };
            var result = ints.OrderBy(g => g);
            foreach(var i in result)
            {
                Console.Write("{0}  ", i);
            }
            Console.WriteLine();
            StringCount();


            var g1 = Grades.D;
            var g2 = Grades.F;
            var g3 = Grades.A;

            Extensions.minPassing = Grades.C;
            Console.WriteLine("first {0} a Passing grade", g1.Passing() ? "is" : "not is");
            Console.WriteLine("Second {0} a Passing grade", g2.Passing() ? "is" : "not is");
            Console.WriteLine("Third {0} a Passing grade", g3.Passing() ? "is" : "not is");

            Console.ReadLine();
        }
        static void StringCount()
        {
            string s = "This is jikexuyuan C# course!";
            int i = s.WordCount();
            Console.WriteLine("word count is {0}:",i);
        }
    }
    public static class StringExtension
    {
        public static int WordCount(this string s)
        {
            return s.Split(new char[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    public static class Extensions
    {
        public static Grades minPassing = Grades.D;
        public static bool Passing(this Grades grade)
        {
            return grade >= minPassing;
        }
    }
}
