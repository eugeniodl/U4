using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericClassForm
{
    public partial class MathOperationForm : Form
    {
        private MathOperationHandler _handler;
        public MathOperationForm(MathOperationHandler handler)
        {
            InitializeComponent();
            _handler = handler;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el tipo de operación
                Type operationType = _handler.GetOperationType();

                // Declarar variables dinámicas
                dynamic value1 = null;
                dynamic value2 = null;

                // Convertir entradas a tipo específico
                value1 = Convert.ChangeType(txtInput1.Text, operationType);
                value2 = Convert.ChangeType(txtInput2.Text, operationType);

                // Realizar la operación
                string result = _handler.PerformOperation(value1, value2);

                // Mostrar el resultado
                lblResult.Text = "Result: " + result;
            }
            catch
            {
                lblResult.Text = "Invalid input or type mismatch!";
            }

        }
    }
}
