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
    public partial class Herencia : Form
    {
        private utileria utl = new utileria();

        public Herencia()
        {
            InitializeComponent();
            utl.txtSoloNumeros(txtHerencia);
        }

        private void Herencia_Load(object sender, EventArgs e)
        {
            txtHerencia.MaxLength = 6;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            utl.StyleBtn(btnCalc, Color.White, Color.Black, 250, 65, true, Color.DarkGreen, 25, "Cooper Black");
            utl.StyleBtn(btnLimp, Color.White, Color.Black, 250, 65, true, Color.DarkRed, 25, "Cooper Black");
            utl.StyleBtn(btnRegre, Color.White, Color.Black, 125, 40, true, Color.DarkRed, 15, "Cooper Black");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtHerencia.Text == "")
            {
                MessageBox.Show("Por favor, rellene los espacios vacíos.", "Error #1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double herencia = Convert.ToDouble(txtHerencia.Text);
                double juan, luis, rosa, ab1, ab2, ab3, abogadototal;
                juan = herencia / 3;
                luis = (4 * herencia) / 9;
                rosa = (2 * herencia) / 9;
                ab1 = ParteAbo(juan, herencia);
                ab2 = ParteAbo(luis, herencia);
                ab3 = ParteAbo(rosa, herencia);
                abogadototal = ab1 + ab2 + ab3;
                txtJuan.Text = Math.Round(juan, 2).ToString();
                txtLuis.Text = Math.Round(luis, 2).ToString();
                txtRosa.Text = Math.Round(rosa, 2).ToString();
                txtAbogado.Text = Math.Round(abogadototal, 2).ToString();
            }

        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            Control[] txts = new Control[] { txtHerencia, txtLuis, txtJuan, txtRosa, txtAbogado };
            utl.LimpTxt(txts);
        }

        private double ParteAbo(double parte, double herencia)
        {
            double pp;
            if (parte >= (herencia / 3))
            {
                pp = parte * 0.05;
            }
            else
            {
                pp = parte * 0.03;
            }
            return pp;
        }

        private void btnRegre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
