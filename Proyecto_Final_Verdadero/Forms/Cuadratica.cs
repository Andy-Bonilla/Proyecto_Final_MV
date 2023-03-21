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
        }

        #region Asignacion De Variables
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            this.a = (txtA.Text == "") ? "a" : txtA.Text;
            AsignarValores();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            this.c = (txtC.Text == "") ? "c" : txtC.Text;
            AsignarValores();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
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
        }

        //Boton De Regreso Al Menu
        private void button1_Click(object sender, EventArgs e)
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
