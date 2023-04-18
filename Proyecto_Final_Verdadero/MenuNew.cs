using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Verdadero
{
    public partial class MenuNew : Form
    {
        //Llamamos nuetro archivo de utileria para usar las funciones que declaramos en el.
        private utileria utl = new utileria();

        public MenuNew()
        {
            InitializeComponent();
        }

        private void MenuNew_Load(object sender, EventArgs e)
        {
        }

        #region Eventos
        //Click en el boton para cerrar formulario
        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Click en el boton para minimizar el formulario
        private void pcbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Botones

        //Boton que llama el menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 40)
            {
                dplMenu();
            }
            else
            {
                dplMenu(false);
            }
        }

        //Boton que manda a llamar los creditos
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            utl.MostrarForm(pnlPrincipal, new Forms.Creditos());
            if (pnlMenu.Width == 280)
            {
                dplMenu(false);
            }
        }

        //Boton que llama el Form Cuadratica
        private void btnCuadratica_Click(object sender, EventArgs e)
        {
            //Mostramos formulario desde nuestra Funcion de utileria.
            utl.MostrarForm(pnlPrincipal, new Forms.Cuadratica());
            if (pnlMenu.Width == 280)
            {
                dplMenu(false);
            }
        }

        #endregion

        #region Funciones

        //Funcion que expande y encoge el menu lateral
        private void dplMenu(bool ini = true)
        {
            if (ini)
            {
                btnMenu.Left += 240;
                pnlMenu.Width += 240;
            }
            else
            {
                btnMenu.Left -= 240;
                pnlMenu.Width -= 240;
            }
        }

        #endregion

        private void btnCajero_Click(object sender, EventArgs e)
        {
            //Mostramos formulario en panel desde clase utileria
            utl.MostrarForm(pnlPrincipal, new Forms.Cajero());
            if (pnlMenu.Width == 280)
            {
                dplMenu(false);
            }
        }

        private void btnAgudos_Click(object sender, EventArgs e)
        {
            //Mostramos formulario en panel desde clase utileria
            utl.MostrarForm(pnlPrincipal, new Forms.Angulos());
            if (pnlMenu.Width == 280)
            {
                dplMenu(false);
            }
        }

        private void btnCramer_Click(object sender, EventArgs e)
        {
            //Mostramos formulario en panel desde clase utileria
            utl.MostrarForm(pnlPrincipal, new Forms.Cramer());
            if (pnlMenu.Width == 280)
            {
                dplMenu(false);
            }
        }

        private void btnHerencia_Click(object sender, EventArgs e)
        {
            utl.MostrarForm(pnlPrincipal, new Forms.Herencia());
            if (pnlMenu.Width == 280)
            {
                dplMenu(false);
            }
        }
    }
}
