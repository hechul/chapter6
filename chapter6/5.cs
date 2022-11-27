#define CSHARP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace chapter6
{
    class conditionAttrApp
    {
        [Conditional("CSHARP")]
        public static void CsharpMethod()
        {
            Console.WriteLine("In the CSharp Method ...");
        }
        [Conditional("JAVA")]
        public static void JAVAMethod()
        {
            Console.WriteLine("In the JAVA Method ...");

        }
    }
    internal class Class1
    {public static void Main(String[] args)
        {
            conditionAttrApp.CsharpMethod();
            conditionAttrApp.JAVAMethod();

        }
    }
}
