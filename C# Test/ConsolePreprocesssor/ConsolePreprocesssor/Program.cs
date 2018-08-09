#define Trace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePreprocesssor
{
    class Program
    {
        static void Main(string[] args)
        {
#if (DEBUG)
            Console.WriteLine("Hello DEBUG");
#warning DEBUG IS defined
#elif (Trace)
            Console.WriteLine("Hello Trace");
#else
#error realse is defined
            Console.WriteLine("Hello Realsee");
#endif
            #region Hello JIKEXUEYUAN
            Console.ReadLine();
            #endregion
            
        }
    }
}
