using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace chapter6
{
    class ThreadProperty
    {
        public void ThreadBody()
        {
            Thread myself = Thread.CurrentThread;
            for(int i=0; i < 3; i++)
            {
                Console.WriteLine("{0} is activated => {1}", myself.Name, i);
                Thread.Sleep(1000);
            }
        }
    }
    internal class _11
    {
        public static void Main(String[] args)
        {
            ThreadProperty obj = new ThreadProperty();
            ThreadStart ts = new ThreadStart(obj.ThreadBody);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Name = "Apple"; 
            t2.Name = "Orange";
            t1.Start();
            t2.Start();
        }
    }
}
