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
    public partial class PracticaHome5 : Form
    {
        public PracticaHome5()
        {
            InitializeComponent();
            //textBox15.Enabled = false;
        }
        #region Ejericio5PrimerIntento2Botones
        private bool BtnSiFuePresionado = false;
        private bool BtnNoFuePresionado = false;

        private void BtnSi_Click(object sender, EventArgs e)
        {

            BtnSiFuePresionado = true;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            BtnNoFuePresionado = true;
        }
        public void operar( )
        {
            if (BtnSiFuePresionado)
            {
                label3.Text = "Ya le llevamo su refrigerio";
            }
            if (BtnNoFuePresionado)
            {
                label3.Text = "Nos avisan cuando necesiten refrigerio";
            }
        }

        private void label3_Validating(object sender, CancelEventArgs e)
        {
            
        }
        #endregion

        #region Ejercicio5Resuelto
        private void button1_Click(object sender, EventArgs e)
        {
            string resultado;
            resultado = textBox1.Text;
            
            if (resultado == "Si" || resultado == "si")
            {
                label4.Text = "Ya le llevamos su refrigerio";
            }
            else if (resultado == "No"|| resultado == "no")
            {
                label4.Text = "Nos avisen cuando lo necesiten";
            }
            else
            {
                MessageBox.Show("Debeo ingresar Si o No...");
            }
        }
        #endregion

        #region Ejercicio6
        /* ejericio 6
         * 6.Programaen  el  cual  se  ingresen  2  números  y 
         * luego realice las siguientes operaciones:
         * a) Si los números son iguales restarlos
         * b) Si los números son diferentes sumarlos
         */
        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textBox2.Text);
            num2 = Convert.ToDouble(textBox3.Text);
            if ( num1 == num2)
            {
                resultado = num1 - num2;
                label10.Text = "el resultado es :" + " "+ resultado.ToString();
            }
            else
            {
                resultado = num1 + num2;
                label10.Text = "el resultado es :" + " " + resultado.ToString();
            }
        }
        #endregion

        #region Ejercicio7
        /*
         * 7.Programa en   el  cual  reciba  como entradas  la siguiente   información:
         * Código   del Estudiante, Nombre  del  Estudiante, Nombre  de  la  Materia y 
         * Tres  Notas  de  1.0  a  5.0. Con  esta  información  el programa    debe 
         * calcular    la    nota    definitiva (promedio) y determinar si el estudiante 
         * aprueba o no   la   materia   (Definitiva mayor   a   4.0).   
         * Debe imprimir  coma  salidas  elnombre,  el  código,  
         * la materia y si aprobó o no.
         */

        private void button3_Click(object sender, EventArgs e)
        {
            string Nombre, Materia;
            double nota1, nota2, resultado , nota3;            
            nota1 = Convert.ToDouble(textBox6.Text);
            nota2 = Convert.ToDouble(textBox7.Text);
            nota3 = Convert.ToDouble(textBox8.Text);
            if (nota1 >= 0.0 && nota1 <= 5.0 && nota2 >= 0.0 && nota2 <= 5.0 && nota3 >= 0.0 && nota3 <= 5.0)
            {
                Nombre = textBox5.Text;
                Materia = textBox4.Text;
                resultado = (nota1 + nota2 + nota3) / 3.0;
                if (resultado >= 4.0)
                {
                    label11.Text = "El estudiante" + " " + Nombre.ToString() + "\n " + "que cursa la materia de" + " " + Materia.ToString() + "  \n" + "Tiene un promedio de :" + " " + resultado + "  \n" + "Aprobado!";
                }
                else
                {
                    label11.Text = "Reprobado";
                }
                
            }
            else
            {
                MessageBox.Show("La nota debe ser entre 0 y 5");
            }
        }



        #endregion

        #region Ejercicio8 
        /*8.Programa que  permita  determinar  el  total  a  pagar por una compra
         * del la cual se sabe el valor unitario y  la  cantidad.
         * Se  debe  tener  en  cuanta  que  se realiza    un    descuento
         * del    15%    por    compra inferiores   a   $20,000   y   del   35%   
         * por   compras mayores o iguales a $20,000
         */
        private void button4_Click(object sender, EventArgs e)
        {
            string  validar;
            double cantidad, precio, descuento, total;
            //  cantidad = Convert.ToDouble(textBox12.Text);
            validar = comboBox1.Text;
           if (validar != ""){ 
            if (comboBox1.SelectedItem.Equals("Arroz") ) 
            {
                cantidad = Convert.ToDouble(textBox12.Text);
                if (cantidad > 0 )
                {
                  
                    precio = cantidad * 1000;

                    if (precio >= 20000.0)
                    {
                        descuento = 35.0 / 100.0;
                        total = precio - (descuento * precio);
                        textBox11.Text = descuento.ToString();
                        textBox10.Text = precio.ToString();
                        textBox9.Text = total.ToString();
                    }
                    else
                    {
                        descuento = 15.0 / 100.0;
                        total = precio - (descuento * precio);
                        textBox11.Text = descuento.ToString();
                        textBox10.Text = precio.ToString();
                        textBox9.Text = total.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("debe ingresas una cantidad mayor que 0");
                }
            } 
            else if (comboBox1.SelectedItem.Equals("Frijoles") )
            {
                cantidad = Convert.ToDouble(textBox12.Text);
                if (cantidad > 0)
                {
                    precio = cantidad * 2000;

                    if (precio >= 20000.0)
                    {
                        descuento = 35.0 / 100.0;
                        total = precio - (descuento * precio);
                        textBox11.Text = descuento.ToString();
                        textBox10.Text = precio.ToString();
                        textBox9.Text = total.ToString();
                    }
                    else
                    {
                        descuento = 15.0 / 100.0;
                        total = precio - (descuento * precio);
                        textBox11.Text = descuento.ToString();
                        textBox10.Text = precio.ToString();
                        textBox9.Text = total.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("debe ingresas una cantidad mayor que 0");
                }
            }
            else if (comboBox1.SelectedItem.Equals("Pan") )
            {
                cantidad = Convert.ToDouble(textBox12.Text);
                if (cantidad > 0)
                {
                    precio = cantidad * 2000;

                    if (precio >= 20000.0)
                    {
                        descuento = 35.0 / 100.0;
                        total = precio - (descuento * precio);
                        textBox11.Text = descuento.ToString();
                        textBox10.Text = precio.ToString();
                        textBox9.Text = total.ToString();
                    }
                    else
                    {
                        descuento = 15.0 / 100.0;
                        total = precio - (descuento * precio);
                        textBox11.Text = descuento.ToString();
                        textBox10.Text = precio.ToString();
                        textBox9.Text = total.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("debe ingresas una cantidad mayor que 0");
                }
            }
            else if (comboBox1.SelectedItem.Equals("") )
            {
                MessageBox.Show("Debe selecionar un producto");
            }
            else
            {
                MessageBox.Show("Control de errores revisar!!");
            }
            }
            else
            {
                MessageBox.Show("Selecionar un producto!!");
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Ejercicio9
        private void button5_Click(object sender, EventArgs e)
        {
            /*  10.Programa que  permita calcular  el valor  final a pagar en una súper tienda
             *  en donde se aplican los siguientes descuentos: 
             *  a)Por compras entre 10000 y 20000 el 10 % 
             *  b)Por compras entre 20001y 50000 el 30 % 
             *  c)Por compras superiores a 50000 el 50 %
             */
            string  validar;
            double monto, descuento,total;
            validar = textBox16.Text;
            if (validar != "")
            {

                monto = Convert.ToDouble(textBox16.Text);
                if (monto > 0 )
                {
                    //descuento = Convert.ToDouble(textBox15.Text);
                    if(monto>=10000&& monto <= 20000)
                    {
                        descuento = (10.0/100.0) * monto;
                        total = monto-descuento;
                        TxtBad.Text = descuento.ToString();
                        textBox13.Text = total.ToString();
                        textBox14.Text = monto.ToString();
                    }
                    else if (monto >= 20001.0 && monto <= 50000.0)
                    {
                        descuento = (30.0 / 100.0) * monto;
                        total = monto - descuento;
                        TxtBad.Text = descuento.ToString();
                        textBox13.Text = total.ToString();
                        textBox14.Text = monto.ToString();
                    }
                    else if (monto >= 50000.0)
                    {
                        descuento = (50.0 / 100.0) * monto;
                        total = monto - descuento;
                        TxtBad.Text = descuento.ToString();
                        textBox13.Text = total.ToString();
                        textBox14.Text = monto.ToString();
                    }
                    else
                    {
                         total = monto;
                        //extBox16.Text = descuento.ToString();
                        textBox13.Text = total.ToString();
                        textBox14.Text = monto.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Digite la cantidad de producto");

                }
                }
            else
            {
                MessageBox.Show("Error");

            }

        }
#endregion
    }
}
