using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTRO_ESCOLAR
{
    public partial class Form3 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();

                    break;

                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();

                    break;

                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();

                    break;

                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();

                    break;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
