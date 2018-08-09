using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass mycl = new myClass();
            mycl.sayhello();
            function1();
            helpAttribute hattr;
            foreach ( var attr in typeof(anyClass).GetCustomAttributes(true))
            {
                hattr = attr as helpAttribute;
                if ( hattr!=null)
                {
                    Console.WriteLine(hattr.Description);
                }
            }
            Console.ReadLine();
        }

        [Obsolete("Don't use old method", false/*true*/)]
        static void function1()
        {
            Console.WriteLine("I'm function1");
        }
    }
    class myClass
    {
        [Conditional("DEBUG")]
        public void sayhello()
        {
            Console.WriteLine("Hello");
        }
    }

    //
    [AttributeUsage(AttributeTargets.Class,AllowMultiple=false,Inherited=false)]
    class helpAttribute:Attribute
    {
        protected string description;
        public helpAttribute(string description_in)
        {
            this.description = description_in;
        }
        public string Description
        {
            get
            {
                return this.description;
            }
        }
        public string name
        {
            get;
            set;
        }
    }

    [help("this is a sample calss for attribute",name="Jikexueyuan")]
    public class anyClass
    {

    }
}
