using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Poo
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado_op;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            pantalla.Text = pantalla.Text + ",";
            if (pantalla.Text.Contains(",,")) 
            {
                pantalla.Text = "Syntax ERROR";

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "/";
                primero = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch (Exception)
            {
                pantalla.Text = "Syntax ERROR";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pantalla.Text = resultado_op.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "X";
                primero = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch (Exception)
            {
                pantalla.Text = "Syntax ERROR";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            try 
            {
                operador = "+";
                primero = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch (Exception)
            {
                pantalla.Text = "Syntax ERROR";
            }

        }

        private void restar_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "-";
                primero = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch (Exception)
            {
                pantalla.Text = "Syntax ERROR";
            }
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            try
            {
                segundo = double.Parse(pantalla.Text);
                switch (operador)
                {
                    case "+":

                        resultado_op = primero + segundo;
                        pantalla.Text = resultado_op.ToString();
                        break;
                    case "-":
                        resultado_op = primero - segundo;
                        pantalla.Text = resultado_op.ToString();
                        break;
                    case "X":
                        resultado_op = primero * segundo;
                        pantalla.Text = resultado_op.ToString();
                        break;
                    case "/":
                        resultado_op = primero / segundo;
                        pantalla.Text = resultado_op.ToString();
                        switch (segundo)
                        {
                            case 0:
                                pantalla.Text = "Math ERROR";
                                break;
                        }
                        break;
                    case "=":
                        resultado_op = primero;
                        pantalla.Text = resultado_op.ToString();
                        break;

                }

            }
            catch (Exception) 
            {
                pantalla.Text = "Syntax ERROR";
            }
        }

        private void botonborrarnumero_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length>1)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length-1,1);
            }
            else if (pantalla.Text.Length == 1)
            {
                pantalla.Text = "";
            }
        }


    }
}
