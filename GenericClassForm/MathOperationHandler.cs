using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassForm
{
    // Clase no genérica que encapsula la operación
    public class MathOperationHandler
    {
        private object _operation; // Almacena la operación
        private Type _operationType; // Almacena el tipo de dato

        // Método para asignar una operación genérica
        public void SetOperation<T>(IOperation<T> operation)
        {
            _operation = operation;
            _operationType = typeof(T);
        }

        // Método para obtener el tipo de operación
        public Type GetOperationType()
        {
            return _operationType;
        }

        // Método para ejecutar la operación
        public string PerformOperation<T>(T value1, T value2)
        {
            var op = (IOperation<T>)_operation;
            T result = op.Operate(value1, value2);
            return result.ToString();
        }

    }
}
