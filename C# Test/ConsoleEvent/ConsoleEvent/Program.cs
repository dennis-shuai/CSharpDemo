using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEvent
{
    class Program
    {

       
        static void Main(string[] args)
        {
            var e = new EventTest(5);
            e.setValue(100);
            e.changeNum += new EventTest.numMantipulationHander(EventTest.EventFired);
            e.setValue(200);

            I i = new myEvent();
            i.myEvent1 += new myDelegate(f);
            i.FireAnyway();
            Console.ReadLine();
        }
        private static void f()
        {
            Console.WriteLine("event tigger");
        }
    }
    class EventTest
    {
        private int value;
        public delegate void numMantipulationHander();
        public event numMantipulationHander changeNum;
        public EventTest(int i)
        {
            setValue(i);
        }
        protected virtual void onNumchanged()
        {
            if (changeNum != null)
            {
                changeNum();
            }
            else
            {
                Console.WriteLine("Event fired!");
            }
        }
        public static void EventFired()
        {
            Console.WriteLine("Bind Event Fired");
        }
        public void setValue(int n)
        {
            if (value != n)
            {
                value = n;
                onNumchanged();
            }
        }
    }
    public delegate void myDelegate();
    public interface I
    {
        event myDelegate myEvent1;
        void FireAnyway();
    }

    class myEvent:I
    {
        public event myDelegate myEvent1;
        public void FireAnyway()
        {
            if (myEvent1!=null)
            {
                myEvent1();
            }
        }
    }
}
