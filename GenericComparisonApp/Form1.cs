namespace GenericComparisonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        // Evento del botón de comparación
        private void btnCompare_Click(object sender, EventArgs e)
        {
            CompareValues<decimal>(); // Puede cambiar el tipo genérico aquí (int, double, etc.)
        }

        // Método genérico para comparar dos valores
        private void CompareValues<T>() where T: IComparable<T>
        {
            try
            {
                // Convertir los valores ingresados al tipo genérico T
                T value1 = (T)Convert.ChangeType(txtValue1.Text, typeof(T));
                T value2 = (T)Convert.ChangeType(txtValue2.Text, typeof(T));

                // Comparar los valores usando IComparable<T>
                int comparisonResult = value1.CompareTo(value2);

                // Mostrar el resultado de la comparación
                if (comparisonResult > 0)
                {
                    lblResult.Text = "El primer valor es mayor que el segundo.";
                }
                else if (comparisonResult < 0)
                {
                    lblResult.Text = "El primer valor es menor que el segundo.";
                }
                else
                {
                    lblResult.Text = "Ambos valores son iguales";
                }
                lblResult.ForeColor = Color.Green;
            }
            catch (InvalidCastException)
            {
                lblResult.Text = "Error: No se pueden convertir los valores al tipo especificado.";
                lblResult.ForeColor = Color.Red;
            }
            catch(FormatException)
            {
                lblResult.Text = "Error: El formato de uno o ambos valores es incorrecto.";
                lblResult.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error inesperado: {ex.Message}";
                lblResult.ForeColor = Color.Red;
            }
        }
    }
}