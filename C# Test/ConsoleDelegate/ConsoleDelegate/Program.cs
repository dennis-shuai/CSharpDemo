using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    delegate int NumberDelegate(int p);
    delegate void D(int p);
    class Program
    {
        static int k = 2;
        static void Main(string[] args)
        {
            
            NumberDelegate numDele = new NumberDelegate(addNum);
            numDele(5);
            myDelegateClass mc = new myDelegateClass();
            NumberDelegate numDele2 = new NumberDelegate(mc.addNum);
            numDele2(15);

            D cd1 = new D(C.M1);
            cd1(-1);
            Console.WriteLine();
            D cd2 = new D(C.M2);
            cd2(-2);
            Console.WriteLine();
            D cd3 = cd1 + cd2;
            cd3(-3);
            Console.WriteLine();
            C c = new C();
            D cd4 =new D(c.M3);
            cd3 += cd4;
            cd3(10);
            Console.WriteLine();
            cd3 += cd1;
            cd3(20);
            Console.WriteLine();
            cd3 -= cd1;
            cd3(30);



            Console.WriteLine("value of num:{0}",k);
            Console.WriteLine("value of Class num:{0}", mc.num);
            Console.ReadLine();
            
        }
        public  static int addNum(int p)
        {
            k += p;
            return k ;
        }
    }
    class myDelegateClass
    {
        public int num = 10;
        public  int addNum(int p)
        {
            num += p;
            return num;
        }

    }
    class C
    {
        public static void M1(int i)
        {
            Console.WriteLine("C.M1:{0}", i);
        }
        public static void M2(int i)
        {
            Console.WriteLine("C.M2:{0}", i);
        }
        public  void M3(int i)
        {
            Console.WriteLine("C.M3:{0}", i);
        }

    }
}
