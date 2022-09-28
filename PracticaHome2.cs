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
    public partial class PracticaHome2 : Form
    {
        public PracticaHome2()
        {
            InitializeComponent();
        }
            /*Programa   que   permita   determinar   
             * el   salario   a pagar  a  un  empleado  teniendo  
             * como  entradas  el salario  diario   y   el  número 
             * de  días  trabajados. Tenga  en  cuenta  que  al  empleado  
             * se  le  debe descontar  el  10%  por  concepto  de pensión y  
             * 15% por concepto de salud*/



        private void button1_Click(object sender, EventArgs e)
        {
            double total, salario, pension, salud, diasT, deduccion;
            diasT = Convert.ToDouble(maskedTextBox1.Text);
            if (diasT >= 0) 
            {
                salario = 500 * diasT;
                pension = (10.0 / 100.0) * salario;
                salud = (15.0 / 100.0) * salario;
                deduccion = salud + pension;
                total = salario - deduccion;
                textBox1.Text = deduccion.ToString();
                textBox2.Text = total.ToString();
                textBox3.Text = salario.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
