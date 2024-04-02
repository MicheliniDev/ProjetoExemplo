using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExemplo
{
    public partial class frmExercicio : Form
    {
        public frmExercicio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txt1.Text);
            num2 = Convert.ToDouble(txt2.Text);
            result = num1 + num2;
            txtResultado.Text = result.ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txtResultado.Clear();
            txt1.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
