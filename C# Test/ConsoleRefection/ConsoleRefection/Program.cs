using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRefection
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello Reflection";
            Type t = str.GetType();
            Console.WriteLine(t.FullName);
            Type t2 = Type.GetType("System.String", false, true);
            Console.WriteLine(t2.FullName);

            Type t3 = typeof(String);
            Console.WriteLine(t3.FullName);
            GetMethods(t,BindingFlags.Public|BindingFlags.Instance);
            Console.WriteLine("Copy Method:{0}", t.GetMethod("Copy"));
            Console.ReadLine();
        }
        public static void GetMethods(Type t,BindingFlags f)
        {
            MethodInfo[] mi = t.GetMethods(f);
            foreach( MethodInfo m in mi)
            {
                Console.WriteLine("{0}", m.Name);
            }
        }
    }
}
