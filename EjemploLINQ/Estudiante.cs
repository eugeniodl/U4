public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Nota { get; set; }

    public override string ToString()
    {
        return $"{Nombre} - Edad: {Edad}, Nota: {Nota}";
    }
}

