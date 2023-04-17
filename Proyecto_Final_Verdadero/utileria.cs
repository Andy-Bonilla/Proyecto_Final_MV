using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Verdadero
{
    //ponemos la clase como publica para poder acceder donde sea que se llame.
    public class utileria
    {
        /// <summary>
        /// Funcion que recibe como parametro un TextBox y no permite letras solo numeros.
        /// </summary>
        /// <param name="textbox">TextBox a validar.</param>
        public void txtSoloNumeros(TextBox textbox)
        {
            textbox.KeyPress += new KeyPressEventHandler((sender, e) =>
            {
                // Verificar si la tecla presionada es un número (0-9), un signo negativo o una tecla de control (por ejemplo, retroceso)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }

                // Permitir el signo negativo solo al principio del texto
                if (e.KeyChar == '-')
                {
                    TextBox textBox = (TextBox)sender;
                    if (textBox.SelectionStart != 0 || textBox.Text.Contains("-"))
                    {
                        e.Handled = true;
                    }
                }
            });
        }

        /// <summary>
        /// Función que recibe como parametro un TextBox y no permite numeros solo letras.
        /// </summary>
        /// <param name="textBox">TextBox a validar.</param>
        public void txtSoloLetras(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Verificar si el carácter presionado es una letra
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    // Si el carácter presionado no es una letra ni un carácter de control (como backspace), se ignora
                    e.Handled = true;
                }
            };
        }

        /// <summary>
        /// Funcion que muestra un Formulario en un panel. 
        /// </summary>
        /// <param name="Panel">Nombre del Panel donde mostraremos el Formulario.</param>
        /// <param name="frm">Nombre del formulario a mostrar en el panel.</param>
        public void MostrarForm(Control Panel, Form frm)
        {
            Panel.Controls.Clear();//Limpiamos panel
            Form Pantalla = null;//Definimos variable pantalla
            Pantalla = frm;//Pantalla es igual al form Creditos
            Pantalla.TopLevel = false;//Definimos como pantalla secundaria
            Pantalla.FormBorderStyle = FormBorderStyle.None; //Quitamos los bordes al form
            Pantalla.Dock = DockStyle.Fill; //Definimos que sea adaptable al panel
            Panel.Controls.Add(Pantalla);//Añadimos la pantalla al panel
            Pantalla.Show();//Mostramos la pantalla
        }

        /// <summary>
        /// Funcion que da estilo a un boton. 
        /// </summary>
        /// <param name="bnt">Nombre del Boton a Dar Estilo</param>
        /// <param name="backColor">(Opcional)Color de Fondo del Boton Default: AliceBlue</param>
        /// <param name="textColor">(Opcional) Color del Texto del Boton Default: Blanco</param>
        /// <param name="Ancho">(Opcional) Ancho del Boton Default: 150</param>
        /// <param name="Alto">(Opcional) Alto del Boton Default: 50</param>
        /// <param name="Border">(Opcional) Si el Boton contara con border Default: No</param>
        /// <param name="BorderColor">(Opcional) Si Border True define el color del borde Default: Negro</param>
        public void StyleBtn(Button bnt, Color? backColor = null, Color? textColor = null, int Ancho = 150, int Alto = 40, bool Border = false, Color? BorderColor = null, int FontSize = 14, string Font = "Arial")
        {
            Font fuente = new Font(Font, FontSize);
            bnt.FlatStyle = FlatStyle.Flat;
            bnt.FlatAppearance.BorderSize = (Border) ? 5 : 0;
            bnt.Size = new Size(Ancho, Alto);
            bnt.BackColor = (backColor == null) ? Color.AliceBlue : (Color)backColor;
            bnt.ForeColor = (textColor == null) ? Color.White : (Color)textColor;
            if (Border) { bnt.FlatAppearance.BorderColor = (textColor == null) ? Color.Black : (Color)BorderColor; }
            bnt.Font = fuente;
        }

    }
}
