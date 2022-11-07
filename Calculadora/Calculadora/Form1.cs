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
    public partial class Form1 : Form
    {
        bool operacion = true;
        string operaciones;
        double Raiz, X, res, cantidad1, cantidad2;


        public Form1()
        {
            InitializeComponent();

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "0";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "1";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "2";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "3";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "4";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "5";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "6";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "7";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (operacion)
            {
                textBox1.Text = "8";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


            if (operacion)
            {
                textBox1.Text = "9";
                operacion = false;
                buttonPunto.Enabled = true;
            }
            else
            {
                if (textBox1.TextLength <= 9)
                    (textBox1.Text) = textBox1.Text + "9";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            buttonPunto.Enabled = true;

            (textBox1.Text) = "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "."; buttonPunto.Enabled = false;
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            operaciones = "+";
            operacion = true;
            cantidad1 = double.Parse(textBox1.Text);
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            operaciones = "-";
            operacion = true;
            cantidad1 = double.Parse(textBox1.Text);
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operaciones = "/";
            operacion = true;
            cantidad1 = double.Parse(textBox1.Text);
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operaciones = "*";
            operacion = true;
            cantidad1 = double.Parse(textBox1.Text);
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            cantidad2 = double.Parse(textBox1.Text);
            operacion = true;


            switch (operaciones)
            {

                case "+":

                    res = cantidad1 + cantidad2;
                    textBox1.Text = res.ToString();
                    break;
                case "-":

                    res = cantidad1 - cantidad2;
                    textBox1.Text = res.ToString();
                    break;
                case "/":

                    res = cantidad1 / cantidad2;
                    textBox1.Text = res.ToString();
                    break;
                case "*":

                    res = cantidad1 * cantidad2;
                    textBox1.Text = res.ToString();
                    break;

            }
        }

        private void buttonCuadrado_Click(object sender, EventArgs e)
        {
            X=double.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(X * X);
        }

        private void buttonRC_Click(object sender, EventArgs e)
        {
            Raiz=Math.Sqrt(double.Parse(textBox1.Text));
            textBox1.Text = Convert.ToString(Raiz);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
