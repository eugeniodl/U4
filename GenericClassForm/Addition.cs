using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassForm
{
    // Clase para realizar suma, permitiendo conversiones
    internal class Addition<T> : IOperation<T> where T : struct, IConvertible
    {
        public T Operate(T a, T b)
        {
            // Convertir a double para realizar la operación suma
            double sum = Convert.ToDouble(a) + Convert.ToDouble(b);

            // Convertir el resultado d enuevo al tipo T
            return (T)Convert.ChangeType(sum, typeof(T));
        }
    }
}
