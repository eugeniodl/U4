using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassForm
{
    // Clase para realizar suma
    internal class Addition<T> : IOperation<T> where T : struct, IConvertible
    {
        public T Operate(T a, T b)
        {
            throw new NotImplementedException();
        }
    }
}
