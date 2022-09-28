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
    public partial class PracticaHome6 : Form
    {
        public PracticaHome6()
        {
            InitializeComponent();
        }
        #region Ejercicio11
/*11.Programa para   determinar   si   un   deportista   es aceptado  en  el  quipo  
 * de  baloncesto  de  Bogotá. Las condiciones para ser aceptado son:
 * a)La edad debe ser menor o iguala 18 años
 * b)La estatura debe ser mayor a 180 cm
 * c)El peso debe sermenor o igual a 80 kg
 * Si  el  aspirante cumple las  3 condiciones aceptarlo si no rechazarlo
 */
        private void button6_Click(object sender, EventArgs e)
        {
            //declaramos las variables
            string validarAltura, validarEdad, validarPeso, valNombre;
            double altura, peso, edad;
            //Convertimos y asignamos los elmentos de entrada para nuestra variable
            validarAltura = textBox17.Text;
            validarEdad = textBox18.Text;
            valNombre = textBox19.Text;
            validarPeso = textBox18.Text;
            if (validarAltura!=""&&validarEdad!=""&&valNombre!=""&&validarPeso!="")
            {
                altura = Convert.ToDouble(textBox17.Text);
                edad   = Convert.ToDouble(textBox18.Text);
                peso   = Convert.ToDouble(textBox18.Text);

                if (edad<=18 && altura >180 && peso <= 80)
                {
                    label33.Text = "Aceptado Bienvenido al equipo" +" "+ valNombre + ".";
                }
                else
                {
                    label33.Text = "Has sido rechazado" + " " + valNombre + ".";
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }

        }
        //
        #endregion

        //#region Ejercicio13
        /*
         * 13.Un  hombre  desea  saber  cuánto  dinero  se  genera por  concepto  de intereses  
         * sobre  la  cantidad  que tiene   en   inversión   en   el   banco.   
         * El   decidirá reinvertir  los  intereses  siempre  y  cuando  estos excedan   
         * a   $7000,   y   en   ese   caso   desea   saber cuánto dinero tendrá finalmente 
         * en su cuenta.
         */


        private void button1_Click(object sender, EventArgs e)
        {
            string valInt, valCap, valAño;
            valCap = textBox22.Text;
            valInt = textBox21.Text;
            valAño = textBox1.Text;
            double interesGanado, Capital, interesAnual, años;
            if (valCap != "" && valInt != "" && valAño != "")
            {
                Capital = Convert.ToDouble(textBox22.Text);
                interesAnual = Convert.ToDouble(textBox21.Text);
                años = Convert.ToDouble(textBox1.Text);
                interesGanado = (Capital * años * (interesAnual/100));

                if (interesGanado > 7000)
                {
                    interesGanado = interesGanado + 7000;
                    interesGanado = (Capital * años * (interesAnual / 100));
                    label35.Text = "Usted tiene un total de :" + " " + interesGanado.ToString();
                }
                else
                {
                    interesGanado = (Capital * años * (interesAnual / 100));
                    label35.Text = "Usted tiene un total de :" + " " + interesGanado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Rellenar todos los campos");
            }

        }

    }
}
