namespace GestionElementosApp
{
    public partial class Form1 : Form
    {
        // Definición de las colecciones genéricas
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
            if (!string.IsNullOrEmpty(elemento))
            {
                _linkedList.AddLast(elemento);
                ActualizarListBox();
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
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

            // Mostrar contenido de la lista ordenada
            lstColecciones.Items.Add("\nLista Ordenada (SortedList) - Clave-Valor:");
            foreach (var entry in _sortedList)
            {
                lstColecciones.Items.Add($"Clave: {entry.Key}, Valor: {entry.Value}");
            }

            // Mostrar contenido de la pila
            lstColecciones.Items.Add("\nPila (Stack)");
            foreach (var item in _stack)
            {
                lstColecciones.Items.Add(item);
            }
        }

        private void btnAgregarSortedList_Click(object sender, EventArgs e)
        {
            // Agregar un par clave-valor a la lista ordenada (SortedList)
            string clave = txtElemento.Text.Trim();
            string valor = txtValor.Text.Trim();

            if (!string.IsNullOrEmpty(clave) && !string.IsNullOrEmpty(valor))
            {
                if (!_sortedList.ContainsKey(clave))
                {
                    _sortedList.Add(clave, valor);
                    ActualizarListBox();
                    txtElemento.Clear();
                    txtValor.Clear();
                }
                else
                {
                    MessageBox.Show("La clave ya existe.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una clave y un valor válidos.");
            }

        }

        private void btnAgregarStack_Click(object sender, EventArgs e)
        {
            // Agregar un elemento a la pila (Stack)
            string elemento = txtElemento.Text.Trim();
            if (!string.IsNullOrEmpty(elemento))
            {
                _stack.Push(elemento);
                ActualizarListBox();
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }

        private void btnProcesarStack_Click(object sender, EventArgs e)
        {
            // Procesar (remover) el último elemento de la Pila (Stack)
            if(_stack.Count > 0)
            {
                string procesado = _stack.Pop();
                MessageBox.Show($"Elemento procesado: {procesado}");
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("No ha elementos en la pila.");
            }
        }
    }
}