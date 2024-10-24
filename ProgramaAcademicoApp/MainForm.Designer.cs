namespace ProgramaAcademicoApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrarEstudiantes = new Button();
            lstEstudiantes = new ListBox();
            lstAsignaturas = new ListBox();
            btnMostrarAsignaturas = new Button();
            SuspendLayout();
            // 
            // btnMostrarEstudiantes
            // 
            btnMostrarEstudiantes.Location = new Point(27, 39);
            btnMostrarEstudiantes.Name = "btnMostrarEstudiantes";
            btnMostrarEstudiantes.Size = new Size(118, 40);
            btnMostrarEstudiantes.TabIndex = 0;
            btnMostrarEstudiantes.Text = "Mostrar Estudiantes";
            btnMostrarEstudiantes.UseVisualStyleBackColor = true;
            btnMostrarEstudiantes.Click += btnMostrarEstudiantes_Click;
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.ItemHeight = 15;
            lstEstudiantes.Location = new Point(175, 39);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(432, 154);
            lstEstudiantes.TabIndex = 1;
            // 
            // lstAsignaturas
            // 
            lstAsignaturas.FormattingEnabled = true;
            lstAsignaturas.ItemHeight = 15;
            lstAsignaturas.Location = new Point(175, 217);
            lstAsignaturas.Name = "lstAsignaturas";
            lstAsignaturas.Size = new Size(432, 154);
            lstAsignaturas.TabIndex = 3;
            // 
            // btnMostrarAsignaturas
            // 
            btnMostrarAsignaturas.Location = new Point(27, 217);
            btnMostrarAsignaturas.Name = "btnMostrarAsignaturas";
            btnMostrarAsignaturas.Size = new Size(118, 40);
            btnMostrarAsignaturas.TabIndex = 2;
            btnMostrarAsignaturas.Text = "Mostrar Asignaturas";
            btnMostrarAsignaturas.UseVisualStyleBackColor = true;
            btnMostrarAsignaturas.Click += btnMostrarAsignaturas_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 407);
            Controls.Add(lstAsignaturas);
            Controls.Add(btnMostrarAsignaturas);
            Controls.Add(lstEstudiantes);
            Controls.Add(btnMostrarEstudiantes);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarEstudiantes;
        private ListBox lstEstudiantes;
        private ListBox lstAsignaturas;
        private Button btnMostrarAsignaturas;
    }
}