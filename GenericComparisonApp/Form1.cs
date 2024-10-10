namespace GenericComparisonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            CompareValues<int>();
        }

        private void CompareValues<T>() where T : IComparable<T>
        {
            try
            {
                T value1 = (T)Convert.ChangeType(txtInput1.Text, typeof(T));
                T value2 = (T)Convert.ChangeType(txtInput2.Text, typeof(T));

                // Comparar los valores usando IComparable<T>
                int comparissonResult = value1.CompareTo(value2);

                // Mostrar el resultado de la comparación
                if (comparissonResult > 0)
                {
                    lblResult.Text = "El primer valor es mayor que el segundo.";
                }
                else if (comparissonResult < 0)
                {
                    lblResult.Text = "El primer valor es menor que el segundo";
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
            catch(Exception ex)
            {
                lblResult.Text = $"Error inesperado: {ex.Message}";
                lblResult.ForeColor = Color.Red;
            }
        }
    }
}