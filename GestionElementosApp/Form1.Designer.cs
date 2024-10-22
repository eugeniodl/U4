namespace GestionElementosApp
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
            label1 = new Label();
            txtElemento = new TextBox();
            txtValor = new TextBox();
            label2 = new Label();
            btnAgregarLinkedList = new Button();
            btnAgregarSortedList = new Button();
            btnAgregarStack = new Button();
            btnProcesarStack = new Button();
            lstColecciones = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 66);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Elemento";
            // 
            // txtElemento
            // 
            txtElemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtElemento.Location = new Point(122, 63);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(100, 29);
            txtElemento.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(122, 114);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 29);
            txtValor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 119);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 2;
            label2.Text = "Valor";
            // 
            // btnAgregarLinkedList
            // 
            btnAgregarLinkedList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarLinkedList.Location = new Point(240, 57);
            btnAgregarLinkedList.Name = "btnAgregarLinkedList";
            btnAgregarLinkedList.Size = new Size(175, 38);
            btnAgregarLinkedList.TabIndex = 4;
            btnAgregarLinkedList.Text = "Agregar a LinkedList";
            btnAgregarLinkedList.UseVisualStyleBackColor = true;
            btnAgregarLinkedList.Click += btnAgregarLinkedList_Click;
            // 
            // btnAgregarSortedList
            // 
            btnAgregarSortedList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarSortedList.Location = new Point(240, 111);
            btnAgregarSortedList.Name = "btnAgregarSortedList";
            btnAgregarSortedList.Size = new Size(175, 36);
            btnAgregarSortedList.TabIndex = 5;
            btnAgregarSortedList.Text = "Agregar a SortedList";
            btnAgregarSortedList.UseVisualStyleBackColor = true;
            // 
            // btnAgregarStack
            // 
            btnAgregarStack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarStack.Location = new Point(59, 168);
            btnAgregarStack.Name = "btnAgregarStack";
            btnAgregarStack.Size = new Size(163, 44);
            btnAgregarStack.TabIndex = 6;
            btnAgregarStack.Text = "Agregar a Stack";
            btnAgregarStack.UseVisualStyleBackColor = true;
            // 
            // btnProcesarStack
            // 
            btnProcesarStack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcesarStack.Location = new Point(240, 168);
            btnProcesarStack.Name = "btnProcesarStack";
            btnProcesarStack.Size = new Size(157, 44);
            btnProcesarStack.TabIndex = 7;
            btnProcesarStack.Text = "Procesar Stack";
            btnProcesarStack.UseVisualStyleBackColor = true;
            // 
            // lstColecciones
            // 
            lstColecciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstColecciones.FormattingEnabled = true;
            lstColecciones.ItemHeight = 21;
            lstColecciones.Location = new Point(31, 231);
            lstColecciones.Name = "lstColecciones";
            lstColecciones.Size = new Size(384, 214);
            lstColecciones.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 479);
            Controls.Add(lstColecciones);
            Controls.Add(btnProcesarStack);
            Controls.Add(btnAgregarStack);
            Controls.Add(btnAgregarSortedList);
            Controls.Add(btnAgregarLinkedList);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(txtElemento);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Gestión de Elementos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtElemento;
        private TextBox txtValor;
        private Label label2;
        private Button btnAgregarLinkedList;
        private Button btnAgregarSortedList;
        private Button btnAgregarStack;
        private Button btnProcesarStack;
        private ListBox lstColecciones;
    }
}