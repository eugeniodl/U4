﻿using System.Collections;

// Crear un ArrayList
ArrayList miAL = new ArrayList();

// Agregar elementos de diferentes tipos
miAL.Add(1); // Entero
miAL.Add("Programación"); // Cadena
miAL.Add("!");

// Mostrar las propiedades y valores del ArrayList.
Console.WriteLine("miAL");
Console.WriteLine("Cantidad: {0}", miAL.Count);
Console.WriteLine("Capacidad: {0}", miAL.Capacity);
Console.WriteLine("Valores");
ImprimirValores(miAL);

void ImprimirValores(IEnumerable miColeccion)
{
    // Recorrer y mostrar los elementos
    foreach (var item in miColeccion)
        Console.WriteLine("{0}", item);
    Console.WriteLine();
}

Console.WriteLine("---------------------------------------");

// Crear una cola (Queue)
Queue miQ = new Queue();

// Agregar elementos
miQ.Enqueue("Primero");
miQ.Enqueue("Segundo");
miQ.Enqueue("Tercero");

// Mostrar las propiedades y valores de la Queue
Console.WriteLine("miQ");
Console.WriteLine("\tCantidad: {0}", miQ.Count);
Console.WriteLine("\tValores");
ImprimirValores(miQ);

// Remover y mostrar el primer elemento
Console.WriteLine($"Elemento removido: {miQ.Dequeue()}");
ImprimirValores(miQ);

// Mostrar el siguiente elemento en la cola sin removerlo
Console.WriteLine($"Siguiente en la cola: {miQ.Peek()}");
ImprimirValores(miQ);

Console.WriteLine("----------------------");

// Crear una pila (Stack)
Stack miS = new Stack();

// Agregar elementos
miS.Push("Primero");
miS.Push("Segundo");
miS.Push("Tercero");

// Muestra las propiedades y valores de la Pila
Console.WriteLine("miS");
Console.WriteLine("\tCantidad: {0}", miS.Count);
Console.WriteLine("\tValores:");
ImprimirValores(miS);

// Remover y mostrar el último elemento
Console.WriteLine($"Elemento removido: {miS.Pop()}");
ImprimirValores(miS);

// Mostrar el siguiento elemento en la pila removerlo
Console.WriteLine($"Siguiente en la pila: {miS.Peek()}");
ImprimirValores(miS);

Console.WriteLine("---------------------------");

// Crear una Hashtable
Hashtable abrirCon = new Hashtable();

// Agregar algunos elementos a la Hashtable.
// No hay claves duplicadas, pero algunos de los valores
// son duplicados
abrirCon.Add("txt", "notepad.exe");
abrirCon.Add("bmp", "paint.exe");
abrirCon.Add("dib", "paint.exe");
abrirCon.Add("rtf", "wordpad.exe");

// El método Add lanza una excepción 
// si la nueva clave ya está en la Hashtable
try
{
    abrirCon.Add("txt", "winword.exe");
}
catch
{
    Console.WriteLine("Ya existe un elemento con la Clave = \"txt\".");
}

// La propiedad Item es la predeterminada,
// por lo que puede omitir su nombre al acceder a los elementos.
Console.WriteLine("Para la clave = \"rtf\", el valor es {0}", abrirCon["rtf"]);

// La propiedad Item predeterminada se puede usar para cambiar el valor
// asociado a una clave
abrirCon["rtf"] = "winword.exe";

// Si una clave no existe, al establecer la propieda Item predeterminada
// para esa clave, se agrega un nuevo par clave/valor
abrirCon["doc"] = "winword.exe";

// ContainsKey se puede usar para probar claves antes de insertarlas.
if (!abrirCon.ContainsKey("ht"))
{
    abrirCon.Add("ht", "hypertrm.exe");
    Console.WriteLine("Valor agregado para la clave = \"ht\": {0}", abrirCon["ht"]);
}

// Cuando usa foreach para enumerar los elementos de la Hashtable,
// los elementos se recuperan como objetos KeyValuePair.
Console.WriteLine();
foreach (DictionaryEntry de in abrirCon)
{
    Console.WriteLine("Clave = {0}, Valor = {1}", de.Key, de.Value);
}

// Para obtener solo los valores, use la propiedad Values.
ICollection valueColl = abrirCon.Values;

// Los elementos de la colección ValueCollection están fuertemente tipados
// con el tipo especificado para los valores de la Hashtable.
Console.WriteLine();
foreach(string s in valueColl)
{
    Console.WriteLine("Valor = {0}", s);
}

// Para obtener solo los valores, use la propiedad Keys.
ICollection keyColl = abrirCon.Keys;

// Los elementos de la colección KeyCollection están fuertemente tipados
// con el tipo especificado para las claves de la Hashtable.
Console.WriteLine();
foreach (string s in keyColl)
{
    Console.WriteLine("Clave = {0}", s);
}

// Usa el método Remove para eliminar un par clave/valor.
Console.WriteLine("\nEliminar(\"doc\")");
abrirCon.Remove("doc");

if(!abrirCon.ContainsKey("doc"))
{
    Console.WriteLine("La clave \"doc\" no se encuentra.");
}