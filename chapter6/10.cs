//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;
//namespace chapter6
//{
//    internal class _10
//    {
//        static void ThreadBody()
//        {
//            for(int i = 0; i < 5; i++)
//            {
//                Console.WriteLine(DateTime.Now.Second + " : " + i);
//                Thread.Sleep(1000);
//            }
//        }
//        public static void Main(String[] args)
//        {
//            ThreadStart ts = new ThreadStart(ThreadBody);
//            Thread t = new Thread(ts);
//            Console.WriteLine("*** Start of Main");
//            t.Start();
//            Console.WriteLine("*** End of Main");
//        }
//    }
//}
