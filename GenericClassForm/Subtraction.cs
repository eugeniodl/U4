namespace GenericClassForm
{
    public class Subtraction<T> : IOperation<T> where T : struct, IConvertible
    {
        public T Operate(T a, T b)
        {
            double subtraction = Convert.ToDouble(a) - Convert.ToDouble(b);

            return (T)Convert.ChangeType(subtraction, typeof(T));
        }
    }
}