namespace ProgramaAcademicoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrarAsignaturas = new Button();
            lstAsignaturas = new ListBox();
            lstEstudiantes = new ListBox();
            btnMostrarEstudiantes = new Button();
            SuspendLayout();
            // 
            // btnMostrarAsignaturas
            // 
            btnMostrarAsignaturas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrarAsignaturas.Location = new Point(28, 44);
            btnMostrarAsignaturas.Name = "btnMostrarAsignaturas";
            btnMostrarAsignaturas.Size = new Size(195, 52);
            btnMostrarAsignaturas.TabIndex = 0;
            btnMostrarAsignaturas.Text = "Mostrar Asignaturas";
            btnMostrarAsignaturas.UseVisualStyleBackColor = true;
            btnMostrarAsignaturas.Click += btnMostrarAsignaturas_Click;
            // 
            // lstAsignaturas
            // 
            lstAsignaturas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstAsignaturas.FormattingEnabled = true;
            lstAsignaturas.ItemHeight = 21;
            lstAsignaturas.Location = new Point(258, 44);
            lstAsignaturas.Name = "lstAsignaturas";
            lstAsignaturas.Size = new Size(417, 151);
            lstAsignaturas.TabIndex = 1;
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.ItemHeight = 21;
            lstEstudiantes.Location = new Point(258, 232);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(417, 151);
            lstEstudiantes.TabIndex = 3;
            // 
            // btnMostrarEstudiantes
            // 
            btnMostrarEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrarEstudiantes.Location = new Point(28, 232);
            btnMostrarEstudiantes.Name = "btnMostrarEstudiantes";
            btnMostrarEstudiantes.Size = new Size(195, 52);
            btnMostrarEstudiantes.TabIndex = 2;
            btnMostrarEstudiantes.Text = "Mostrar Estudiantes";
            btnMostrarEstudiantes.UseVisualStyleBackColor = true;
            btnMostrarEstudiantes.Click += btnMostrarEstudiantes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 419);
            Controls.Add(lstEstudiantes);
            Controls.Add(btnMostrarEstudiantes);
            Controls.Add(lstAsignaturas);
            Controls.Add(btnMostrarAsignaturas);
            Name = "Form1";
            Text = "ProgramaAsignaturaApp";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarAsignaturas;
        private ListBox lstAsignaturas;
        private ListBox lstEstudiantes;
        private Button btnMostrarEstudiantes;
    }
}