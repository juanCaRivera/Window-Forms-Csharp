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
    public partial class Examen : Form
    {
        public Examen()
        {
            InitializeComponent();
        }

        private void Examen_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inv, egr, ing, dep , UAI , UDI , imp;
            string val, val1, val2;
            val = maskedTextBox1.Text;
            val1 = maskedTextBox2.Text;
            val2 = maskedTextBox3.Text;
            //Validamos que no halla campos en blanco
            if (val!="" && val1!="" && val2 !="")
            {
                //Validamos el rango de la inversion inicial oscila entre 5000 y 65000.
                inv = Convert.ToDouble(maskedTextBox1.Text);
                if (inv >= 5000 && inv <= 65000 ) 
                {
                    //Validamos los ingresos deben oscilar entre 500 y 5000
                    ing = Convert.ToDouble(maskedTextBox2.Text);
                    if (ing >= 500 && ing <= 5000)
                    {
                        //validamos los egresos no deben ser mayores a los ingresos.
                        egr = Convert.ToDouble(maskedTextBox3.Text);
                        if (ing > egr)
                        {
                            //Proyectamos los ingresos y egresos a 5 años 
                            ing = ing * 60;
                            egr = egr * 60;
                            //calcular la depreciacion de la inversion inicial
                            dep = inv / 5;
                            //Utilidad antes de impuestos como UAI=Ing-(Egr+Dep)
                            UAI = ing - (egr + dep) ;
                            //Calcular Impuestos como el 30% de la UAI
                            imp = UAI * 0.3;
                            //Calcular UDI(Utilidad despues de Impuestos como UDI = UAI - Imp.
                            UDI = UAI - imp;
                            //imprimimos los reultados en los textBox
                            textBox3.Text = UDI.ToString();
                            textBox2.Text = UAI.ToString();
                            textBox1.Text = dep.ToString();
                            textBox4.Text = imp.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Los ingresos deben ser mayor que los egresos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los ingresos deben ser mayor que 500 y menor que 5,000 ");
                    }
                }
                else
                {
                    MessageBox.Show("La inversion debe ser mayor que 5,000 y menor que 65,000");
                }
            }
            else
            {
                MessageBox.Show("No puede haber cuadros sin llenar");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
        }


    }
}
