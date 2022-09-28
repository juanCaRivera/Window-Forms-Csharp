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
    public partial class PraticaHome3 : Form
    {
        public PraticaHome3()
        {
            InitializeComponent();
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;
            textBox1.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (comboBox1.SelectedItem.Equals("Esfera"))
            {

               maskedTextBox3.Enabled = true;

            }
            else
            {
                maskedTextBox3.Enabled = false;

            }
;
            if (comboBox1.SelectedItem.Equals("Cubo"))
            {
                maskedTextBox1.Enabled = true;

            }
            else
            {
                maskedTextBox1.Enabled = false;

            }
            if (comboBox1.SelectedItem.Equals("Cilindro"))
            {
                maskedTextBox2.Enabled = true;

                maskedTextBox3.Enabled = true;


            }
            else
            {
                maskedTextBox2.Enabled = false;
                                         
                maskedTextBox3.Enabled = false;

            }
         }
        private void button1_Click(object sender, EventArgs e)
        {
            double area, altura, radio, pi, resultado;
            pi = 3.1416;
            area = Convert.ToDouble(maskedTextBox1.Text);
            altura = Convert.ToDouble(maskedTextBox2.Text);
            radio = Convert.ToDouble(maskedTextBox3.Text);
            if ( comboBox1.SelectedItem.Equals("Esfera"))
            {
               // maskedTextBox3.Enabled = true;
                resultado = ((4.0 / 3.0) * pi * (radio * radio * radio));
                textBox1.Text = resultado.ToString();
            }
            if (comboBox1.SelectedItem.Equals("Cubo"))
            {
                //maskedTextBox1.Enabled = true;
                resultado = area*area*area;
                textBox1.Text = resultado.ToString();
            }
            if (comboBox1.SelectedItem.Equals("Cilindro"))
            {
              //  maskedTextBox2.Enabled = true;

               // maskedTextBox3.Enabled = true;

                resultado = altura*pi*(radio*radio);
                textBox1.Text = resultado.ToString();
            }
        }


    }
}
