using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class CalculoDeArea : Form
    {
        public CalculoDeArea()
        {
            InitializeComponent();
            textBox4.Enabled = false;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals("Rectangulo"))
            {
                textBox2.Enabled = false;
                textBox1.Enabled = false;
                textBox5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double area, altura, Base, lado, radio;
           // area = Convert.ToDouble(textBox4.Text);
           // lado = Convert.ToDouble(textBox1.Text);
           // radio = Convert.ToDouble(textBox5.Text);
            if (comboBox1.SelectedItem.Equals("Rectangulo"))
            {
                //textBox2.Enabled = false;
                textBox1.Enabled = false;
                textBox5.Enabled = false;
                altura = Convert.ToDouble(textBox3.Text);
                Base = Convert.ToDouble(textBox2.Text);
                area = altura * Base;
                textBox4.Text = area.ToString();
            }
            if (comboBox1.SelectedItem.Equals("Cuadrado"))
            {
                // textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox5.Enabled = false;
                lado = Convert.ToDouble(textBox1.Text);
                area = lado * lado;
                textBox4.Text = area.ToString();
            }
            if (comboBox1.SelectedItem.Equals("Triangulo"))
            {
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox1.Enabled = false;
                altura = Convert.ToDouble(textBox3.Text);
                Base = Convert.ToDouble(textBox2.Text);

                area = (altura * Base)/2;
                textBox4.Text = area.ToString();
            }
            if (comboBox1.SelectedItem.Equals("Circulo"))
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                radio = Convert.ToDouble(textBox5.Text);

                area = radio * radio ;
                textBox4.Text = area.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
