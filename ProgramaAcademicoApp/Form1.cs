namespace ProgramaAcademicoApp
{
    public partial class Form1 : Form
    {
        private ProgramaAcademicoControlador _programaAcademicoControlador;
        public Form1()
        {
            InitializeComponent();
            _programaAcademicoControlador = new ProgramaAcademicoControlador();
        }

        private void btnMostrarAsignaturas_Click(object sender, EventArgs e)
        {
            // Obtenemos el programa académico y estudiantes
            var programaAcademico =
                _programaAcademicoControlador.ObtenerProgramaAcademico();
            var estudiantes = programaAcademico.Estudiantes;

            lstAsignaturas.Items.Clear();

            // Filtrar asignaturas con notas mayores a 85
            var asignaturasMayoresA85 = estudiantes
                .SelectMany(e => e.Asignaturas)
                .Where(a => a.Nota > 85)
                .ToList();

            lstAsignaturas.Items.Add("Asignaturas con notas mayores a 85");
            foreach (var asignatura in asignaturasMayoresA85)
            {
                lstAsignaturas.Items.Add(asignatura);
            }

            // Filtrar asignaturas de estudiantes nacidos antes de 1995
            // Filtrar asignaturas con notas menores o iguales a 75
            // Filtrar asignaturas con notas impares
            // Filtrar asignaturas de Juan
            // Filtrar asignaturas por encima del promedio
        }

        private void btnMostrarEstudiantes_Click(object sender, EventArgs e)
        {
            // Obtenemos el programa académico y estudiantes
            var programaAcademico = 
                _programaAcademicoControlador.ObtenerProgramaAcademico();
            var estudiantes = programaAcademico.Estudiantes;

            lstEstudiantes.Items.Clear();

            // Filtrar estudiantes nacidos después del 1º de enero del 2000
            var estudiantesNacidosDespuesDe2000 = estudiantes
                .Where(e => e.FechaDeNacimiento > new DateTime(2000, 1, 1))
                .ToList();

            lstEstudiantes.Items.Add("Estudiantes nacidos después del 1º de enero del 2000");
            foreach (var estudiante in estudiantesNacidosDespuesDe2000)
            {
                lstEstudiantes.Items.Add(estudiante);
            }

            // Filtrar estudiantes cuyo nombre comienza con "M"
            // Filtrar estudiantes que tienen más de 3 asignaturas
            // Filtrar estudiantes que no tienen asignaturas
            // Filtrar estudiantes que han tomado más de dos asignaturas con nota menor a 70
            // Filtrar estudiantes que han aprobado todas sus asignaturas
        }
    }
}