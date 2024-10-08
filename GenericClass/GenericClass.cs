// Definición de la clase genérica
public class GenericClass<T>
{
    private readonly T _value;

    // Constructor que inicializa el valor genérico
    public GenericClass(T value)
    {
        _value = value;
    }

    // Método que devuelve el valor genérico
    public T GetValue()
    {
        return _value;
    }
}

