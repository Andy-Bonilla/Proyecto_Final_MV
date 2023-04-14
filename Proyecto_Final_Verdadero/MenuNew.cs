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
            Pantalla.FormBorderStyle = FormBorderStyle.None;
            Pantalla.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(Pantalla);//Añadimos la pantalla al panel
            pnlPrincipal.Tag = Pantalla;
            Pantalla.Show();//Mostramos la pantalla
            #endregion
            dplMenu();
        }

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

        private void MenuNew_Load(object sender, EventArgs e)
        {
        }

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
