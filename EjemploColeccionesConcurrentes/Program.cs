using System.Collections.Concurrent;

// ConcurrentDictionary<TKey, TValue>
ConcurrentDictionary<int, string> estudiantes = new ConcurrentDictionary<int, string>();

// Agregar elementos
estudiantes.TryAdd(1, "Juan");
estudiantes.TryAdd(2, "Lucía");

// Actualizar o agregar un nuevo valor
estudiantes.AddOrUpdate(1, "María", (key, oldValue) => "María");

// Obtener el valor asociado a una clave
if (estudiantes.TryGetValue(1, out string nombre))
{
    Console.WriteLine($"Estudiante con ID 1: {nombre}");  // Salida: Estudiante con ID 1: María
}

// ConcurrentQueue<T>
ConcurrentQueue<int> cola = new ConcurrentQueue<int>();
cola.Enqueue(10);
cola.Enqueue(20);
cola.Enqueue(30);

// Procesar elementos
if (cola.TryDequeue(out int result))
{
    Console.WriteLine(result);  // Salida: 10
}

// ConcurrentStack<T>
ConcurrentStack<string> pila = new ConcurrentStack<string>();
pila.Push("Elemento 1");
pila.Push("Elemento 2");
pila.Push("Elemento 3");

// Procesar elementos
if (pila.TryPop(out string valor))
{
    Console.WriteLine(valor);  // Salida: Elemento 3
}

// ConcurrentBag<T>
ConcurrentBag<int> bolsa = new ConcurrentBag<int>();
bolsa.Add(5);
bolsa.Add(10);
bolsa.Add(15);

// Procesar elementos
if (bolsa.TryTake(out int valorBolsa))
{
    Console.WriteLine(valorBolsa);  // Salida: 15 (o cualquier otro elemento, no hay un orden garantizado)
}

// BlockingCollection<T>
BlockingCollection<int> coleccion = new BlockingCollection<int>();

// Productor: Agrega elementos a la colección
var productor = Task.Factory.StartNew(() =>
{
    for (int i = 0; i < 5; i++)
    {
        coleccion.Add(i);
        Console.WriteLine($"Elemento agregado: {i}");
    }
    coleccion.CompleteAdding();
});

// Consumidor: Procesa elementos de la colección
var consumidor = Task.Factory.StartNew(() =>
{
    foreach (var item in coleccion.GetConsumingEnumerable())
    {
        Console.WriteLine($"Elemento procesado: {item}");
    }
});

// Esperar a que las tareas finalicen
Task.WaitAll(productor, consumidor);