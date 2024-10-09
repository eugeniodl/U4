using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassForm
{
    public class Subtraction<T> : IOperation<T> where T : struct, IConvertible
    {
        public T Operate(T a, T b)
        {
            double difference = Convert.ToDouble(a) - Convert.ToDouble(b);
            return (T)Convert.ChangeType(difference, typeof(T));
        }
    }
}
