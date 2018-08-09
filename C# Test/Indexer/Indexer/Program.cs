using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer iIndex = new Indexer();
            Console.WriteLine(iIndex[3]);
            Console.WriteLine(iIndex["Item:2"]);
            IndexerClass newindexer = new IndexerClass();
            newindexer[10] = 10;
            Console.WriteLine(newindexer[10]);
            Console.ReadLine();
        }
    }
     class IndexerClass: iSomeInterface
     {
         private int[] arr = new int[100];
         public int this[int index]
         {
             get
             {
                 return arr[index];

             }
             set
             {
                 arr[index] = value;
             }
         }
     }
    class Indexer 
    {
        private string[] namelist = new string[10];
        public Indexer()
        {
            for (int i=0 ;i<10;i++)
            {
                namelist[i] = "Item:"+i.ToString();
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= namelist.Count())
                {
                    tmp = namelist[index];
                }
                else
                    tmp = "";
                return tmp;
            }
        }
        public int this[string Name]
        {
            get
            {
                int index = 0;
                for (; index < namelist.Count();index++ )
                { 
                     if (namelist[index] == Name)
                     {
                         return index;
                     }
                }
                return -1;
                   
            }
        }
      
    }

    public interface iSomeInterface
    {
        int this[int index]
        {
            get;
            set;
        }
    }
}
