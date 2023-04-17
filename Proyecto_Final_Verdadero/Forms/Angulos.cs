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
    public partial class Angulos : Form
    {
        private utileria utl = new utileria();

        public Angulos()
        {
            InitializeComponent();
        }

        private void Angulos_Load(object sender, EventArgs e)
        {
            utl.txtSoloNumeros(txtCo);
            utl.txtSoloNumeros(txtCa);
            txtCo.MaxLength = 2;
            txtCa.MaxLength = 2;
            utl.StyleBtn(btnCalc, Color.White, Color.Black, 200, 60, true, Color.DarkGreen, 25, "Cooper Black");
            utl.StyleBtn(btnLimp, Color.White, Color.Black, 200, 60, true, Color.DarkRed, 25, "Cooper Black");
            utl.StyleBtn(btnRegre, Color.White, Color.Black, 125, 40, true, Color.DarkRed, 15, "Cooper Black");
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            Control[] txts = new Control[] { txtCo, txtCa, txtAb, txtAc, txtH };
            utl.LimpTxt(txts);
        }

        private void btnRegre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtCa.Text == "" || txtCo.Text == "")
            {
                MessageBox.Show("Por favor, rellene los espacios vacíos.", "Error #1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Solicitar las longitudes de los catetos al usuario
                double catOpuesto = Convert.ToDouble(txtCo.Text);
                double catAdyacente = Convert.ToDouble(txtCa.Text);

                // Calcular los ángulos agudos B, C e Hipotenusa utilizando trigonometría
                double anguloB = Math.Atan(catOpuesto / catAdyacente) * (180 / Math.PI);
                double anguloC = 90 - anguloB;
                double hipotenusa = Math.Sqrt(Math.Pow(catOpuesto, 2) + Math.Pow(catAdyacente, 2));

                // Mostrar los resultados
                txtAb.Text = Math.Round(anguloB, 2).ToString();
                txtAc.Text = Math.Round(anguloC, 2).ToString();
                txtH.Text = Math.Round(hipotenusa, 2).ToString();
            }

        }
    }

}
