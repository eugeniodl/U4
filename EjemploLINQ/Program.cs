// Crear una lista de estudantes
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Estudiante> estudiantes = new List<Estudiante>
{
    new Estudiante{ Nombre = "Ana", Edad = 22, Nota = 8.5 },
    new Estudiante{ Nombre = "Luis", Edad = 19, Nota = 7.2 },
    new Estudiante{ Nombre = "Carlos", Edad = 23, Nota = 9.1 },
    new Estudiante{ Nombre = "Lucía", Edad = 21, Nota = 5.9 },
    new Estudiante{ Nombre = "Miguel", Edad = 20, Nota = 6.8 },
};

// Filtrar los estudiantes que tienen una nota mayor o igual a 7 (aprobados)
var estudiantesAprobados = estudiantes
                           .Where(e => e.Nota >= 7)
                           .OrderBy(e => e.Nombre)
                           .Select(e => new { e.Nombre, e.Nota });

Console.WriteLine("Estudiantes aprobados ordenados por nombre:");
foreach (var estudiante in estudiantesAprobados)
{
    Console.WriteLine($"{estudiante.Nombre} - Nota: {estudiante.Nota}");
}
Console.WriteLine();
// Filtrar los estudiantes mayores a 20 años
var mayoresDe20 = estudiantes
    .Where(e => e.Edad > 20).ToList();

Console.WriteLine("Estudiantes mayores a 20 años");
foreach (var e in mayoresDe20)
    Console.WriteLine(e);
Console.WriteLine();
// Filtrar los estudiantes cuyo nombre comienza con 'L'
var estudiantesConL = estudiantes
    .Where(e => e.Nombre.StartsWith("L")).ToList();

Console.WriteLine("Estudiantes cuyo nombre comienza con 'L'");
foreach (var item in estudiantesConL)
{
    Console.WriteLine(item);
}
Console.WriteLine();
// Obtener el estudiante más joven
var estudianteMasJoven = estudiantes.OrderBy(e => e.Edad).FirstOrDefault();

Console.WriteLine($"Estudiante más joven: {estudianteMasJoven}");

// Obtener el promedio de las notas
var promedioNotas = estudiantes.Average(e => e.Nota);
Console.WriteLine();
Console.WriteLine($"Promedio de las notas: {promedioNotas}");

// Filtrar estudiantes con notas superiores al promedio
var estudiantesSuperioresAPromedio = estudiantes
    .Where(e => e.Nota > promedioNotas).ToList();

// Filtrar estudiantes con nombre que contiene la letra 'a'
var estudiantesConA = estudiantes.Where(e => e.Nombre.Contains("a")).ToList();

// Filtrar estudiantes cuyos nombres son únicos
var nombresUnicos = estudiantes.Select(e => e.Nombre).Distinct().ToList();

// Filtrar estudiantes con edad impar
// Filtrar estudiantes que son mayores de 18 pero menores de 23
// Filtrar estudiantes cuyo nombre tiene más de 3 letras
var estudiantesNombresLargos = estudiantes
                               .Where(e => e.Nombre.Length > 3).ToList();
Console.WriteLine("Estudiantes cuyo nombre tiene más de 3 letras");
foreach (var item in estudiantesNombresLargos)
{
    Console.WriteLine(item);
}
Console.WriteLine();
// Contar el número de estudiantes
// Obtener el estudiante con la nota más alta
