public class ProgramaAcademicoControlador
{
    private ProgramaAcademico _programaAcademico;

    public ProgramaAcademicoControlador()
    {
        // Inicializamos el programa académico con algunos estudiantes
        // y asignaturas
        _programaAcademico 
            = new ProgramaAcademico("Ingeniería de Sistemas");

        var estudiante1 = new Estudiante("Juan", new DateTime(2001, 5, 15));
        var estudiante2 = new Estudiante("María", new DateTime(2003, 7, 22));

        estudiante1.Asignaturas.Add(new Asignatura("Contabilidad de Costos", 85));
        estudiante1.Asignaturas.Add(new Asignatura("Sociología", 90));

        estudiante2.Asignaturas.Add(new Asignatura("Algebra Lineal", 88));
        estudiante2.Asignaturas.Add(new Asignatura("Matemática", 92));


        _programaAcademico.Estudiantes.Add(estudiante1);
        _programaAcademico.Estudiantes.Add(estudiante2);
    }

    // Devuelve el programa académico
    public ProgramaAcademico ObtenerProgramaAcademico()
    {
        return _programaAcademico;
    }
}

