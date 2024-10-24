public class ProgramaAcademico
{
    public string NombreProgramaAcademico { get; set; }
    public List<Estudiante> Estudiantes { get; set;}

    public ProgramaAcademico(string nombreProgramaAcademico)
    {
        NombreProgramaAcademico = nombreProgramaAcademico;
        Estudiantes = new List<Estudiante>();
    }
}

