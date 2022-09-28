using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejemplo
{
    public partial class PracticaHome4 : Form
    {
        public PracticaHome4()
        {
            InitializeComponent();
        }
        /*
            * 9.Programa el  cual  permita  ingresar  los  valores  detemperatura  de  cada  día  
            * durante  una  semana.  Le programa debecalcular la temperatura promedio y 
            * luego mostrar los siguientes mensajes:
            * a)Si  el  promedio  es  mayor  a  35°  mostrar  el mensaje “Que semana tan calurosa”
            * b)Si el promedio esta entre1 15° y 35° mostrar el mensaje “Que clima tan delicioso”
            * c)Si el promedio es menor de 15° mostrar el mensaje “Que semana tan fría”
            */
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double lunes, martes, miercoles, jueves, viernes, sabado, domingo, dias, promedio;

            dias = 7.0;
            lunes = Convert.ToDouble(maskedTextBox1.Text);
            martes = Convert.ToDouble(maskedTextBox2.Text);
            miercoles = Convert.ToDouble(maskedTextBox3.Text);
            jueves = Convert.ToDouble(maskedTextBox4.Text);
            viernes = Convert.ToDouble(maskedTextBox5.Text);
            sabado = Convert.ToDouble(maskedTextBox6.Text);
            domingo = Convert.ToDouble(maskedTextBox7.Text);
            promedio = (lunes + martes + miercoles + jueves + viernes + sabado + domingo) / dias;

            if (promedio > 35)
            {
                textBox1.Text = promedio.ToString();
                label9.Text = "Que semana tan Calurosa";
                

            }
            else if (promedio >= 15 && promedio <= 35)
            {
                textBox1.Text = promedio.ToString();
                label9.Text = "Que clima tan delicioso";

            }
            else if (promedio < 15)
            {
                textBox1.Text = promedio.ToString();
                label9.Text = "Que semana tan Fria";

            }

            else
            {
                MessageBox.Show("Error Revisar");
            }
        }

        private  void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            maskedTextBox7.Text = "";
            textBox1.Text = "";
        }
    } }
