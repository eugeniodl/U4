using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaAcademicoApp
{
    public partial class MainForm : Form
    {
        ProgramaAcademicoControlador _programaAcademico;

        public MainForm()
        {
            InitializeComponent();
            _programaAcademico = new ProgramaAcademicoControlador();
        }

        private void btnMostrarAsignaturas_Click(object sender, EventArgs e)
        {
            // Obtenemos el programa académico y estudiantes
            var programaAcademico = _programaAcademico.ObtenerProgramaAcademico();
            var estudiantes = programaAcademico.Estudiantes;

            lstAsignaturas.Items.Clear();

            // Filtar asignaturas con notas mayores a 85
            var asignaturasMayoresDe85 = estudiantes
                .SelectMany(e => e.Asignaturas)
                .Where(a => a.Nota > 85)
                .ToList();

            // Filtrar asignaturas de estudiantes nacidos antes de 1995
            // Filtrar asignaturas con notas menores o iguales a 75
            // Filtrar asignaturas con notas impares
            // Filtrar asignaturas del estudiante Juan
            // Filtrar asignaturas con notas por encima del promedio
            // Filtrar asignaturas cuyos nombres tienen más de 10 caracteres

            foreach (var asignatura in asignaturasMayoresDe85)
            {
                lstAsignaturas.Items.Add(asignatura.ToString());
            }
        }

        private void btnMostrarEstudiantes_Click(object sender, EventArgs e)
        {
            // Obtenemos el programa académico
            var programaAcademico = _programaAcademico.ObtenerProgramaAcademico();
            var estudiantes = programaAcademico.Estudiantes;

            lstEstudiantes.Items.Clear();

            // Filtrar estudiantes nacidos después del 1 de enero de 2000
            var estudiantesNacidosDespuésDe2000 = estudiantes
                .Where(e => e.FechaDeNacimiento > new DateTime(2000, 1, 1)).ToList();

            foreach (var estudiante in estudiantesNacidosDespuésDe2000)
            {
                lstEstudiantes.Items.Add(estudiante.ToString());
            }
        }
    }
}
