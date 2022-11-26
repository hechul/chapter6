//using System;
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace chapter6
//{
//    class GenericMethodApp
//    {
//        static void Swap<DataType>(ref DataType x, ref DataType y)
//        {
//            DataType temp;
//            temp = x; x = y; y = temp;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 1, b = 2; double c = 1.5, d = 2.5;
//            Console.WriteLine("Before : a = {0}, b = {1}", a, b);
//            Swap<int>(ref a, ref b);
//            Console.WriteLine("After : a = {0}, b = {1}", a, b);
//        }
//    }
//}