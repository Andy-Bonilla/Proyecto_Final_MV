using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Verdadero.Forms
{
    public partial class Cajero : Form
    {
        private utileria utl = new utileria();//Llamamos nuestro archivo uteleria para usar sus funciones
        public Cajero()
        {
            InitializeComponent();
        }

        private void Cajero_Load(object sender, EventArgs e)
        {
            string rutaArchivo = "Cuenta.txt";//Nombre de nuestro archivo donde se guardaran las transacciones.
            double Saldo = 200.00;//Establecemos el saldo en $200.

            //StreamWriter es la clase que usa Visual para poder crear y editar archivos de txt
            StreamWriter writer;

            if (!File.Exists(rutaArchivo))//Con la clase File revisamos si ya existe el archivo, si no existe lo crea
            {
                writer = File.CreateText(rutaArchivo); // Creamos el archivo y abrimos el StreamWriter para editarlo
                writer.WriteLine(Saldo);//Con WriteLine escribimos el saldo
                writer.Close();//Cerramos el archivo
            }
            utl.txtSoloNumeros(txtCan);
            utl.StyleBtn(btnEntrada, Color.MediumSlateBlue);
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (txtCan.Text == "")
            {
                MessageBox.Show("Por favor, rellene el espacio vacío.", "Error #1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreamReader reader = new StreamReader("Cuenta.txt");//Abrimos el archivo en modo lectura
                string linea = reader.ReadLine();//Leemos la linea donde esta la cantidad
                double Cuenta = double.Parse(linea);//Convertimos a double la cantidad para poder usarla
                reader.Close();//Cerramos el lector del archivo
                double CuentaNew = Convert.ToDouble(txtCan.Text) + Cuenta;//Nuevo Double donde ponemos el valor actual mas el valor ingresado en el txt
                StreamWriter writer = new StreamWriter("Cuenta.txt", false);//Abrimos el archivo en modo escritura
                writer.WriteLine(CuentaNew);//Reescribimos el archivo con la nueva cantidad
                writer.Close();// Cerramos el archivo
            }
        }
    }
}
