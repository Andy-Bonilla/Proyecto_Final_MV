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
    public partial class Cramer : Form
    {
        private utileria utl = new utileria();

        public string a = "a", b = "b", c = "c", d = "d";

        private void Cramer_Load(object sender, EventArgs e)
        {
            utl.StyleBtn(btnCalc, Color.White, Color.Black, 373, 90, true, Color.DarkGreen, 25, "Cooper Black");
            utl.StyleBtn(btnLimp, Color.White, Color.Black, 373, 90, true, Color.DarkRed, 25, "Cooper Black");
            utl.StyleBtn(btnRegre, Color.White, Color.Black, 125, 40, true, Color.DarkRed, 15, "Cooper Black");
        }

        #region Cambiando Imagen
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            txtA.MaxLength = 2;
            this.a = (txtA.Text == "") ? "a" : txtA.Text;
            AsignarValores();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            txtB.MaxLength = 2;
            this.b = (txtB.Text == "") ? "b" : txtB.Text;
            AsignarValores();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            txtC.MaxLength = 2;
            this.c = (txtC.Text == "") ? "c" : txtC.Text;
            AsignarValores();
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
            txtD.MaxLength = 2;
            this.d = (txtD.Text == "") ? "d" : txtD.Text;
            AsignarValores();
        }
        #endregion

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            double d = Convert.ToDouble(txtD.Text);

            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "")
            {
                MessageBox.Show("Por favor, rellene los espacios vacíos.", "Error #1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double det = (a * d) - (b * c);
                txtDet.Text = Math.Round(det, 2).ToString();
            }
        }

        private void btnRegre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            Control[] txts = new Control[] { txtA, txtB, txtC, txtD, txtDet };
            utl.LimpTxt(txts);
        }

        public Cramer()
        {
            InitializeComponent();
        }

        private void AsignarValores()
        {
            lblA.Text = this.a;
            lblB.Text = this.b;
            lblC.Text = this.c;
            lblD.Text = this.d;
        }
    }
}
