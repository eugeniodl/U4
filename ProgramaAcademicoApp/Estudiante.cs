public class Estudiante
{
    public string Nombre { get; set; }
    public DateTime FechaDeNacimiento { get; set; }
    public List<Asignatura> Asignaturas { get; set; }

    public Estudiante(string nombre, DateTime fechaDeNacimiento)
    {
        Nombre = nombre;
        FechaDeNacimiento = fechaDeNacimiento;
        Asignaturas = new List<Asignatura>();
    }

    public override string ToString()
    {
        return $"{Nombre}, " +
            $"Fecha de Nacimiento: {FechaDeNacimiento.ToShortDateString()}, " +
            $"Asignaturas: {Asignaturas.Count}";
    }
}

