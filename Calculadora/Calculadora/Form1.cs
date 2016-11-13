using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        bool secuencia = true;
        string operacion, borrado;
        double numero1, numero2, resultado;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //Numeros de la Calculadora 
        private void Uno_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "1";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            
            }

        }

        private void Dos_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "2";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";

            }

        }

        private void Tres_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "3";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";

            }

        }
        private void Cuatro_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "4";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";

            }
        }
        private void Cinco_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "5";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";

            }
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "6";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";

            }

        }

        private void Siete_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "7";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";

            }


        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "8";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";

            }


        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "9";
                secuencia = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";

            }


        }

        private void Cero_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            
            }

        }
        //Fin de los Numeros de la Calculadora

        //Inicio de los Botones de Operaciones
        private void Suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;

        }

        private void Division_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;

        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void RaizCuadrada_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Pantalla.Text);
            resultado = Math.Sqrt(numero1);
            Pantalla.Text = resultado.ToString();
            secuencia = true;       

        }

        private void Potencia_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Pantalla.Text);
            resultado = numero1 * numero1;
            Pantalla.Text = resultado.ToString();
            secuencia = true;

        }

        private void Igual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(Pantalla.Text);
            if (operacion == "+")
            {
                resultado = numero1 + numero2;
                Pantalla.Text = resultado.ToString();
                secuencia=true;
            }
            if (operacion == "-")
            {
                resultado = numero1 - numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = numero1 * numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = numero1 / numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            //Fin de los Botones de Operacion

        }
        //Inicio de los Botones de Operaciones Especiales
        private void Retroceso_Click(object sender, EventArgs e)
        {
            /*Funcionamiento de la tecla de Borrado*/
            int x = 0;
            borrado = Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            Pantalla.Text = borrado;



            if (Pantalla.Text == "")
            {
                Pantalla.Text = "0";
                secuencia = true;
            }
            if (Pantalla.Text == "-")
            {
                Pantalla.Text = "0";
                secuencia = true;

            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }      
    }
}
