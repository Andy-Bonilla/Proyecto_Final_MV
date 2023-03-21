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
        public MenuNew()
        {
            InitializeComponent();
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

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            #region muestra formulario
            pnlPrincipal.Controls.Clear();//Limpiamos panel
            Form Pantalla = null;//Definimos variable pantalla

            Pantalla = new Forms.Creditos();//Pantalla es igual al form Creditos
            Pantalla.TopLevel = false;//Definimos como pantalla secundaria
            pnlPrincipal.Controls.Add(Pantalla);//Añadimos la pantalla al panel
            Pantalla.Show();//Mostramos la pantalla
            #endregion
            dplMenu();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 48)
            {
                dplMenu(false);
            }
            else 
            {
                dplMenu();
            }            
        }

        private void MenuNew_Load(object sender, EventArgs e)
        {
            dplMenu();
        }

        private void dplMenu(bool ini = true)
        {
            if (ini)
            {
                btnMenu.Location = new Point(56, 41);
                pnlMenu.Width = 48;
            }
            else
            {
                btnMenu.Location = new Point(308, 41);
                pnlMenu.Width = 300;
            }
        }

        private void btnCuadratica_Click(object sender, EventArgs e)
        {
            #region muestra formulario
            pnlPrincipal.Controls.Clear();//Limpiamos panel
            Form Pantalla = null;//Definimos variable pantalla

            Pantalla = new Forms.Cuadratica();//Pantalla es igual al form Creditos
            Pantalla.TopLevel = false;//Definimos como pantalla secundaria
            pnlPrincipal.Controls.Add(Pantalla);//Añadimos la pantalla al panel
            Pantalla.Show();//Mostramos la pantalla
            #endregion
            dplMenu();
        }
    }
}
