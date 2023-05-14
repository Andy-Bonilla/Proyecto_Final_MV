using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Verdadero.Forms
{
    public partial class Ordenamiento : Form
    {
        public Ordenamiento()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[3];
            numeros[0] = Convert.ToInt32(txtNum1.Text);
            numeros[1] = Convert.ToInt32(txtNum2.Text);
            numeros[2] = Convert.ToInt32(txtNum3.Text);

            Array.Sort(numeros);

            label3.Text = numeros[0] + " --- " + numeros[1] + " --- " + numeros[2];
        }
    }
}
