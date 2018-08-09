using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Task<Int32> t = new Task<Int32>(n => Sum((Int32)n), 1000);
            t.Start();
            //t.Wait();
            Task cwt = t.ContinueWith(task => Console.WriteLine("The result is {0}",t.Result));
            Console.ReadKey();
        }

        private static Int32 Sum(Int32 n)
        {
            Int32 sum = 0;
            for (; n > 0; --n)
                checked{ sum += n;} //结果溢出，抛出异常
            return sum;
        }
    
    }
    
}
