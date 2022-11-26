using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter6
{
    class GenericMethodApp
    {
        static void Swap<DataType>(ref DataType x,ref DataType y)
        {
            DataType temp;
            temp = x; x = y; y = temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
