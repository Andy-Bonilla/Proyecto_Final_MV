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
    public partial class Bisiesto : Form
    {
        public Bisiesto()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int dias = Convert.ToInt32(txtDias.Text); //Convertimos a Entero la entrada
            if (dias <= 365 && dias >= 1)//Evitamos que se ponga un numero mayor
            {
                int[] diasPorMes = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //Array de los dias por mes que tiene un año bisiesto

                int mes = 0;//definimos mes en 0
                while (dias > diasPorMes[mes]) //Mientras dias sea mayor al array de diasPorMes
                {
                    dias -= diasPorMes[mes]; //restamos los días del mes actual
                    mes++; //sumamos un mes mas
                }

                string mesPerteneciente = ObtenerNombreMes(mes + 1); // Sumamos 1 para ajustar al índice de los meses

                MessageBox.Show($"El número de días {dias} pertenece al mes {mesPerteneciente}");
            }
            else
            {
                MessageBox.Show("Error día no existe", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Nombre de los Meses a devolver
        private string ObtenerNombreMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    return string.Empty;
            }
        }
    }
}
