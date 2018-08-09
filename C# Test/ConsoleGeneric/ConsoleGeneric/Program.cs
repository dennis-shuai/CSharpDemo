using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeneric
{
    class Program
    {
        delegate T newDelegate<T>(T n);
        private static int num = 10;
        private static string str = "";
        static void Main(string[] args)
        {
            myGenericArray<int> intArray = new myGenericArray<int>(5);
            for (int i = 0; i < 5; i++)
            {
                intArray.SetItem(i, i * 5);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray.GetItem(i));

            }
            intArray.genericMethod<String>("hello Generic Method");


            myGenericArray<char> charArray = new myGenericArray<char>(5);
            for (int i = 0; i < 5; i++)
            {
                charArray.SetItem(i, (char)(i +97));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(charArray.GetItem(i));

            }

            //myGenericArray<string> strArray = new myGenericArray<String>(5);
            //for (int i = 0; i < 5; i++)
            //{
            //    strArray.SetItem(i, "Hello world"+i.ToString());
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(strArray.GetItem(i));

            //}
            int a = 1;
            int b = 2;
            swap<int>(ref a, ref b);
            Console.WriteLine("a:{0},b:{1}", a, b);

            newDelegate<int> d1 = new newDelegate<int>(mutiply);
            d1(5);

            newDelegate<string> d2 = new newDelegate<string>(sayHello);
            d2("hello Dennis");
            Console.WriteLine("num:{0}", num);
            Console.WriteLine("d2:{0}", str);

            Console.ReadLine();
        }
        private static int mutiply(int p)
        {
            num *= p;
            return num;
        }

        private static string sayHello(string p)
        {
            str = "Xiaoming Say:" + p;
            return str;

        }
        private static void swap<T>(  ref T trf  , ref T tsh)
        {
            T temp= trf;
            trf = tsh;
            tsh = temp;

        }
     
    }
    public class myGenericArray<T> where T:struct
    {
        private T[] array;
        public myGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T GetItem(int index)
        {
            return array[index];
        }
        public void genericMethod<X>(X x)
        {
            Console.WriteLine(x.ToString());
        }
        public void  SetItem(int index,T value)
        {
            array[index] = value;
        }
    }
}
