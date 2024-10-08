// Definición de la clase genérica
public class GenericClass<T>
{
    private T genericMember;
    // Constructor que inicializa el valor genérico
    public GenericClass(T value)
    {
       genericMember = value;
    }

    // Método que devuelve el valor del parámetro
    public T GetValue()
    {
        return genericMember;
    }
}

