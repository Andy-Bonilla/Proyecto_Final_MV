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
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            utl.StyleBtn(btnDepo, Color.White, Color.Black, 250, 95, true, Color.DarkGreen, 25, "Cooper Black");
            utl.StyleBtn(btnReti, Color.White, Color.Black, 250, 95, true, Color.DarkRed, 25, "Cooper Black");
            utl.StyleBtn(btnRegre, Color.White, Color.Black, 125, 40, true, Color.DarkRed, 15, "Cooper Black");

            string rutaArchivo = "Cuenta.txt";//Nombre de nuestro archivo donde se guardaran las transacciones.
            double Saldo = 1000.00;//Establecemos el saldo en $200.

            string contenidoArchivo = File.ReadAllText(rutaArchivo);
            txtSaldo.Text = contenidoArchivo;

            //StreamWriter es la clase que usa Visual para poder crear y editar archivos de txt
            StreamWriter writer;

            if (!File.Exists(rutaArchivo))//Con la clase File revisamos si ya existe el archivo, si no existe lo crea
            {
                writer = File.CreateText(rutaArchivo); // Creamos el archivo y abrimos el StreamWriter para editarlo
                writer.WriteLine(Saldo);//Con WriteLine escribimos el saldo
                writer.Close();//Cerramos el archivo
            }
            utl.txtSoloNumeros(txtCan);
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
                Control[] txts = new Control[] { txtCan };
                utl.LimpTxt(txts);
                MessageBox.Show("Su dinero fue depositado con exito, gracias por usar nuestros servicios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                string rutaArchivo = "Cuenta.txt";
                string contenidoArchivo = File.ReadAllText(rutaArchivo);
                txtSaldo.Text = contenidoArchivo;
            }
        }

        private void btnRegre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReti_Click(object sender, EventArgs e)
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
                if (Convert.ToInt32(txtCan.Text) > Cuenta)
                {
                    MessageBox.Show("No dispones de fondos suficientes.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RetirarBilletes(Cuenta);
                }
            }
        }

        private void RetirarBilletes(double Cuenta)
        {
            double CuentaNew = Cuenta - Convert.ToDouble(txtCan.Text);//Nuevo Double donde ponemos el valor actual mas el valor ingresado en el txt
            StreamWriter writer = new StreamWriter("Cuenta.txt", false);//Abrimos el archivo en modo escritura
            writer.WriteLine(CuentaNew);//Reescribimos el archivo con la nueva cantidad
            writer.Close();// Cerramos el archivo
            MessageBox.Show("Su dinero fue retirado con exito, gracias por usar nuestros servicios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            string rutaArchivo = "Cuenta.txt";
            string contenidoArchivo = File.ReadAllText(rutaArchivo);
            txtSaldo.Text = contenidoArchivo;

            int[] denom = { 1, 5, 10, 20, 100 };
            int[] bille = new int[denom.Length];
            int monto = Convert.ToInt32(txtCan.Text);

            // Calcular la cantidad de billetes de cada denominación
            for (int i = denom.Length - 1; i >= 0; i--)
            {
                if (monto >= denom[i])
                {
                    bille[i] = monto / denom[i];
                    monto = monto % denom[i];
                }
            }
            // Mostrar la cantidad de billetes de cada denominación en los TextBoxes correspondientes
            txtD1.Text = bille[0].ToString();
            txtD5.Text = bille[1].ToString();
            txtD10.Text = bille[2].ToString();
            txtD20.Text = bille[3].ToString(); 
            txtD100.Text = bille[4].ToString();
            Control[] txts = new Control[] { txtCan };
            utl.LimpTxt(txts);
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCan_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCan.MaxLength = 5;
            // Verificar si el carácter ingresado es un número o un string
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear el ingreso del carácter
            }

            // Verificar si se intenta ingresar un signo negativo
            if (e.KeyChar == '-' && !string.IsNullOrEmpty(txtCan.Text))
            {
                e.Handled = true; // Bloquear el ingreso del signo negativo si no está al principio

            }
        }
    }
}
