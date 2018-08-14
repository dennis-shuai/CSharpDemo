using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    class Program
    {
        delegate void testDelegate(string x);
        delegate TResult Fun<Targ0, TResult>(Targ0 x);
        static void Main(string[] args)
        {
            testDelegate td1 = new testDelegate(write);
            td1("Hello Delegate");

            testDelegate td2 = (x) => { Console.WriteLine(x); };

            td2("Hello Anonymous ");

            testDelegate td3 = x => { Console.WriteLine(x); };

            td3("Hello Anonymous  Function");

            lamda();

            Console.ReadLine();
        }
        static void write(string x)
        {
            Console.WriteLine(x);
        }
        static void lamda()
        {
            Func<int, Boolean> myFunc = x => x == 5;
            Console.WriteLine(myFunc(4));
        }
    }
}
