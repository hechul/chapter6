﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//interface IGenericInterface<T>
//{
//    void SetValue(T x);
//    string GetValueType();
//}
//class GenericClass<T> : IGenericInterface<T>
//{
//    private T value;
//    public void SetValue(T x)
//    {
//        value = x;
//    }
//    public String GetValueType()
//    {
//        return value.GetType().ToString();
//    }
//}

//namespace chapter6
//{
//    internal class _4
//    {
//        public static void Main(String[] args)
//        {
//            GenericClass<Int32> gInteger = new GenericClass<Int32>();
//            GenericClass<String> gString = new GenericClass<String>();
//            gInteger.SetValue(10);
//            gString.SetValue("Text");
//            Console.WriteLine(gInteger.GetValueType());
//            Console.WriteLine(gString.GetValueType());
//        }
//    }
//}
