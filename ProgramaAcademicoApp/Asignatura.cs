// Clase Asignatura
public class Asignatura
{
    public string NombreAsignatura { get; set; }
    public int Nota { get; set; }

    public Asignatura(string nombreAsignatura, int nota)
    {
        NombreAsignatura = nombreAsignatura;
        Nota = nota;
    }

    public override string ToString()
    {
        return $"{NombreAsignatura}, Nota: {Nota}";
    }
}