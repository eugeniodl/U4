namespace GestionElementosApp
{
    public partial class Form1 : Form
    {
        // Definici�n de las colecciones gen�ricas
        private Stack<string> _stack;
        private SortedList<string, string> _sortedList;
        private LinkedList<string> _linkedList;

        public Form1()
        {
            InitializeComponent();

            // Inicializamos las colecciones
            _stack = new Stack<string>();
            _sortedList = new SortedList<string, string>();
            _linkedList = new LinkedList<string>();
        }

        private void btnAgregarLinkedList_Click(object sender, EventArgs e)
        {
            // Agregar un elemento a la lista enlazada (LinkedList)
            string elemento = txtElemento.Text.Trim();
            if(!string.IsNullOrEmpty(elemento))
            {
                _linkedList.AddLast(elemento);
                ActualizarListBox();
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor v�lido.");
            }

        }

        private void ActualizarListBox()
        {
            // Actualizar el ListBox con los elementos de las colecciones
            lstColecciones.Items.Clear();

            // Mostrar contenido de la lista enlazada
            lstColecciones.Items.Add("\nLista Enlazada (LinkedList)");
            foreach (var item in _linkedList)
            {
                lstColecciones.Items.Add(item);
            }
        }
    }
}