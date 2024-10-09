using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassForm
{
    // Clase para realizar suma, permitiendo conversiones
    public class Addition<T> : IOperation<T> where T : struct, IConvertible
    {
        public T Operate(T a, T b)
        {
            // Convertir a double para realizar la operación de suma
            double sum = Convert.ToDouble(a) + Convert.ToDouble(b);

            // Convertir el resultado de nuevo al tipo T
            return (T)Convert.ChangeType(sum, typeof(T));
        }
    }
}
