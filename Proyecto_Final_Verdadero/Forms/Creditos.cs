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
    public partial class Creditos : Form
    {
        utileria utl = new utileria();

        public Creditos()
        {
            InitializeComponent();
        }

        private void Creditos_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            utl.StyleBtn(btnRegre, Color.White, Color.Black, 125, 40, true, Color.DarkRed, 15, "Cooper Black");
            picb1.Width = 250;
            picb1.Height = 250;
        }

        private void btnRegre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
