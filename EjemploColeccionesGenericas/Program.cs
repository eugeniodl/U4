using System.Collections;

// Método para imprimir cualquier colección, incluyendo diccionarios
void ImprimirColeccion<T>(IEnumerable<T> miColeccion, string prueba)
{
    Console.WriteLine($"Imprimiendo colección: {prueba}");
    if( miColeccion is IDictionary dict )
    {
        foreach ( DictionaryEntry entry in dict )
            Console.WriteLine($"Clave: {entry.Key}, Valor: {entry.Value}");
    }
    else
    {
        foreach (var item in miColeccion)
        {
            Console.WriteLine(item);
        }
    }
    Console.WriteLine(); // Línea en blanco para separar colecciones
}

// Ejemplo con List<T>
List<string> nombres = new List<string> { "Ana", "Carlos", "Beatriz" };
ImprimirColeccion(nombres, "List<T>");

// Ejemplo con Queue<T>
Queue<int> numeros = new Queue<int>();
numeros.Enqueue(10);
numeros.Enqueue(20);
numeros.Enqueue(30);
ImprimirColeccion(numeros, "Queue<T>");

// Ejemplo con Stack<T>
Stack<string> libros = new Stack<string>();
libros.Push("Libro 1");
libros.Push("Libro 2");
libros.Push("Libro 3");
ImprimirColeccion(libros, "Stack<T>");

// Ejemplo con LinkedList<T>
LinkedList<string> ciudades = new LinkedList<string>();
ciudades.AddLast("Madrid");
ciudades.AddLast("París");
ciudades.AddFirst("Managua");
ImprimirColeccion(ciudades, "LinkedList<T>");

// Ejemplo con HashSet<T>
HashSet<int> numerosUnicos = new HashSet<int> { 1, 2 };
ImprimirColeccion(numerosUnicos, "HashSet<T>");

// Ejemplo con SortedSet<T>
SortedSet<string> frutas = new SortedSet<string> { "Manzana", "Limón", "Naranja" };
ImprimirColeccion(frutas, "SortedSet<T>");

// Ejemplo con Dictionary<TKey, TValue>
Dictionary<int, string> estudiantes = new Dictionary<int, string>
{
    { 1, "Juan" },
    { 2, "Lucía" }
};
ImprimirColeccion(estudiantes, "Dictionary<TKey, TValue>");

// Ejemplo con SortedList<TKey, TValue>
SortedList<int, string> empleados = new SortedList<int, string>
{
    { 3, "Alberto" },
    { 1, "Beatriz" },
    { 2, "Carlos" }
};
ImprimirColeccion(empleados, "SortedList<TKey, TValue>");
