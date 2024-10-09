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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnIntSum_Click(object sender, EventArgs e)
        {
            var mathOperationHandler = new MathOperationHandler();
            mathOperationHandler.SetOperation(new Addition<int>());
            var form = new MathOperationForm(mathOperationHandler);
            form.ShowDialog();
        }
    }
}
