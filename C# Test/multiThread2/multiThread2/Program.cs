using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace multiThread2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadA = new Thread(ThreadMethod);     //执行的必须是无返回值的方法 
            threadA.Name = "小A";
            Thread threadB = new Thread(ThreadMethod);     //执行的必须是无返回值的方法  
            threadB.Name = "小B";
            threadA.Start();
　　　　　　//threadA.Join();　     
            threadB.Start();
　　　　　　threadB.Join();

            for (int i = 0; i < 10; i++)
            { 
                Console.WriteLine("我是:Main,我循环{1}次", Thread.CurrentThread.Name, i);
                Thread.Sleep(300);          //休眠300毫秒                                                
            }

            Console.ReadKey();
        } 
        public static void ThreadMethod(object parameter)  
        { 
            for (int i = 0; i < 10; i++)
            { 
                Console.WriteLine("我是:{0},我循环{1}次", Thread.CurrentThread.Name,i);
                Thread.Sleep(300);         //休眠300毫秒              
            }
        }
        
    }
}
