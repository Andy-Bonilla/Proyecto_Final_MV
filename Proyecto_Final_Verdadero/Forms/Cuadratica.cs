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
    public partial class Cuadratica : Form
    {
        private utileria utl = new utileria();

        public string a = "a", b = "b", c = "c";

        public Cuadratica()
        {
            InitializeComponent();
            utl.txtSoloNumeros(txtA);
            utl.txtSoloNumeros(txtB);
            utl.txtSoloNumeros(txtC);
        }

        private void Cuadratica_Load(object sender, EventArgs e)
        {
            utl.StyleBtn(btnCalc, Color.White, Color.Black, 202, 95, true, Color.DarkGreen, 25, "Cooper Black");
            utl.StyleBtn(btnLimp, Color.White, Color.Black, 202, 95, true, Color.DarkRed, 25, "Cooper Black");
            utl.StyleBtn(btnRegre, Color.White, Color.Black, 125, 40, true, Color.DarkRed, 15, "Cooper Black");
        }

        #region Asignacion De Variables
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            txtA.MaxLength = 2;
            this.a = (txtA.Text == "") ? "a" : txtA.Text;
            AsignarValores();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            txtC.MaxLength = 2;
            this.c = (txtC.Text == "") ? "c" : txtC.Text;
            AsignarValores();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            txtB.MaxLength = 2;
            this.b = (txtB.Text == "") ? "b" : txtB.Text;
            AsignarValores();
        }
        #endregion

        #region Botones
        //Boton Que Limpia
        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
            {
                MessageBox.Show("Por favor, rellene los espacios vacíos.", "Error #1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                #region Calcular Cuadratica
                //Pasamos los valores a numeros
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);

                //Calculamos la cuadratica
                double raiz = b * b - 4 * a * c;
                double sol1 = (-b + Math.Sqrt(raiz)) / (2 * a);
                double sol2 = (-b - Math.Sqrt(raiz)) / (2 * a);

                //Por si la solucion no esta dentro de los reales
                if (raiz >= 0)
                {
                    //Le damos salida a los datos
                    txtX1.Text = Math.Round(sol1, 2).ToString();
                    txtX2.Text = Math.Round(sol2, 2).ToString();
                }
                else
                {
                    MessageBox.Show("La solución no existe dentro de los número reales.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                #endregion
            }
        }

        //Boton De Regreso Al Menu
        private void btnRegre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos Propios
        //Cambios De Valores En La Imagen
        private void AsignarValores()
        {
            lblB1.Text = "-(" + this.b + ")±";
            lblRaiz.Text = "(" + this.b + ")²- 4(" + this.a + ")(" + this.c + ")";
            lblDeno.Text = "2(" + this.a + ")";
        }
        #endregion

    }
}
