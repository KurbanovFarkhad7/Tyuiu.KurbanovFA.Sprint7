using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
{
    public partial class FormSuppliers : Form
    {
        public FormSuppliers()
        {
            InitializeComponent();
        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void buttonGoMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fmain = new FormMain();
            fmain.ShowDialog();
        }
    }
}
