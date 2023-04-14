using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Verdadero
{
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
                // Verificar si la tecla presionada es un número o no
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
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

    }
}
