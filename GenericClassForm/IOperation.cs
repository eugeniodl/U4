using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassForm
{
    public interface IOperation<T>
    {
        T Operate(T a, T b);
    }
}
