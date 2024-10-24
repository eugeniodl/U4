// Crear una lista de estudiantes
List<Estudiante> estudiantes = new List<Estudiante>
{
    new Estudiante{ Nombre = "Ana", Edad = 22, Nota = 8.5 },
    new Estudiante{ Nombre = "Luis", Edad = 19, Nota = 7.2 },
    new Estudiante{ Nombre = "Carlos", Edad = 23, Nota = 9.1 },
    new Estudiante{ Nombre = "Lucía", Edad = 21, Nota = 5.9 },
    new Estudiante{ Nombre = "Miguel", Edad = 20, Nota = 6.8 },
};

// Filtrar los estudiantes que tienen una nota mayor o igual a 6 (aprobados)
var estudiantesAprobados = estudiantes
    .Where(e => e.Nota >= 6) // Filtrar por nota
    .OrderBy(e => e.Nombre) // Ordenar por nombre
    .Select(e => new { e.Nombre, e.Nota }); // Seleccionar solo el nombre y la nota

Console.WriteLine("Estudiantes aprobados");
foreach (var estudiante in estudiantesAprobados)
{
    Console.WriteLine($"{estudiante.Nombre} - Nota: {estudiante.Nota}");
}
Console.WriteLine();

// Filtrar estudiantes mayores de 20 años
var mayoresDe20 = estudiantes.Where(e => e.Edad > 20).ToList();

Console.WriteLine("Estudiantes mayores de 20 años");
foreach (var e in mayoresDe20)
    Console.WriteLine(e);
Console.WriteLine();

// Obtener el estudiante con la nota más alta
var mejorEstudiante = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();

Console.WriteLine($"El estudiante con la nota más alta es: {mejorEstudiante}");
Console.WriteLine();

// Obtener el promedio de las notas
var promedioNotas = estudiantes.Average(e => e.Nota);

Console.WriteLine($"El promedio de las notas es {promedioNotas}");

// Filtrar estudiantes con notas superiores al promedio
var estudiantesSuperioresAlPromedio = estudiantes
    .Where(e => e.Nota > promedioNotas).ToList();

// Filtrar estudiantes cuyo nombre comienza con 'L'
var estudiantesConL = estudiantes.Where(e => e.Nombre.StartsWith("L")).ToList();

// Filtrar estudiantes cuyo nombre tiene más de 3 letras
var estudiantesNombresLargos = estudiantes
    .Where(e => e.Nombre.Length > 3);

// Filtrar estudiantes con edad impar
var estudiantesEdadImpar = estudiantes
    .Where(e => e.Edad % 2 != 0);

// Filtrar estudiantes con nombre que contiene la letra 'a'
var estudiantesConA = estudiantes
    .Where(e => e.Nombre.Contains("a"));

// Filtrar estudiantes que son mayores de 18 pero menores de 23
var estudiantesEntre18y23 = estudiantes
    .Where(e => e.Edad > 18 && e.Edad < 23);

// Contar el número de estudiantes
var totalEstudiantes = estudiantes.Count();
