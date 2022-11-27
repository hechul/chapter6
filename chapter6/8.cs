//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace chapter6
//{
//    internal class _8
//    {
//        static int Count = 0;

//        public static void Main(String[] args)
//        {
//            while (true)
//            {
//                try
//                {
//                    if (++Count == 1) throw new Exception();
//                    if (Count == 3) break;
//                    Console.WriteLine(Count + ") No exception");
//                }catch (Exception)
//                {
//                    Console.WriteLine(Count + ") Exception thrown");
//                }
//                finally
//                {
//                    Console.WriteLine(Count + ") int finally clause");

//                }
//            }
//            Console.WriteLine("Main program ends");
//        }
//    }
//}
