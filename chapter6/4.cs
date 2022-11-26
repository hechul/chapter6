using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IGenericInterface<T>
{
    void SetValue(T x);
    string GetValueType();
}
class GenericClass<T> : IGenericInterface<T>
{
    private T value;
    public void SetValue(T x)
    {
        value = x;
    }
}

namespace chapter6
{
    internal class _4
    {
        public static void main(String[] args)
        {
            
        }
    }
}
