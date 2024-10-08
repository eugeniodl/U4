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
            var form = new MathOperationForm();
            form.ShowDialog();
        }

        private void btnDecimalSubtract_Click(object sender, EventArgs e)
        {
            var form = new MathOperationForm();
            form.ShowDialog();
        }
    }
}
