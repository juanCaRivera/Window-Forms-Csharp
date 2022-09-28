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
    public partial class PS2 : Form
    {
        public PS2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double monto,  cuotaTotal, Cinteres, interes;
            //el monto debe estar entre 100 y 10,000 si el prestamo es de consumo 
            monto = Convert.ToDouble(maskedTextBox1.Text);
            //consumo
            if (monto >= 100 && monto <= 10000) 
            { 
                //consumo
                if (radioButton1.Checked == true) 
                { 
                    if(comboBox1.SelectedItem.Equals("6"))
                    {
                        
                        Cinteres = (1.25 * 6)/100;
                        interes = (Cinteres * monto);
                        cuotaTotal = (interes + monto) / 6;

                        textBox1.Text = cuotaTotal.ToString();
                    }
                    if (comboBox1.SelectedItem.Equals("9"))
                    {
                        Cinteres = (1.25 * 9) / 100;
                        interes = (Cinteres * monto);
                        cuotaTotal = (interes + monto) / 9;

                        textBox1.Text = cuotaTotal.ToString();
                    }
                    if (comboBox1.SelectedItem.Equals("12"))
                    {
                        Cinteres = (1.25 * 12) / 100;
                        interes = (Cinteres * monto);
                        cuotaTotal = (interes + monto) / 12;

                        textBox1.Text = cuotaTotal.ToString();
                    }
                    if (comboBox1.SelectedItem.Equals("18"))
                    {
                        Cinteres = (1.25 * 18) / 100;
                        interes = (Cinteres * monto);
                        cuotaTotal = (interes + monto) / 18;

                        textBox1.Text = cuotaTotal.ToString();
                    }
                    if (comboBox1.SelectedItem.Equals("24"))
                    {
                        Cinteres = (1.25 * 24) / 100;
                        interes = (Cinteres * monto);
                        cuotaTotal = (interes + monto) / 24;

                        textBox1.Text = cuotaTotal.ToString();
                    }
                    if (comboBox1.SelectedItem.Equals("36"))
                    {
                        Cinteres = (1.25 * 36) / 100;
                        interes = (Cinteres * monto);
                        cuotaTotal = (interes + monto) / 36;

                        textBox1.Text = cuotaTotal.ToString();
                    }
                    if (comboBox1.Items.Equals("48"))
                    {
                        Cinteres = (1.25 * 48) / 100;
                        interes = (Cinteres * monto);
                        cuotaTotal = (interes + monto) / 48;

                        textBox1.Text = cuotaTotal.ToString();
                    }
                    if (comboBox1.Items.Equals("60"))
                    {
                        Cinteres = (1.25 * 60) / 100;
                        interes = (Cinteres * monto);
                        cuotaTotal = (interes + monto) / 60;

                        textBox1.Text = cuotaTotal.ToString();
                    }
                }

            }

            //vehiculo
            if (monto >= 5000 && monto <= 60000) 
             {
                    //vehiculos
                    if (radioButton2.Checked == true)
                    {
                        if (comboBox1.SelectedItem.Equals("6"))
                        {

                            Cinteres = (1.5 * 6) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 6;

                            textBox1.Text = cuotaTotal.ToString();
                        }
                        if (comboBox1.SelectedItem.Equals("9"))
                        {
                            Cinteres = (1.5 * 9) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 9;

                            textBox1.Text = cuotaTotal.ToString();
                        }
                        if (comboBox1.SelectedItem.Equals("12"))
                        {
                            Cinteres = (1.5 * 12) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 12;

                            textBox1.Text = cuotaTotal.ToString();
                        }
                        if (comboBox1.SelectedItem.Equals("18"))
                        {
                            Cinteres = (1.5 * 18) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 18;

                            textBox1.Text = cuotaTotal.ToString();
                        }
                        if (comboBox1.SelectedItem.Equals("24"))
                        {
                            Cinteres = (1.5 * 24) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 24;

                            textBox1.Text = cuotaTotal.ToString();
                        }
                        if (comboBox1.SelectedItem.Equals("36"))
                        {
                            Cinteres = (1.5 * 36) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 36;

                            textBox1.Text = cuotaTotal.ToString();
                        }
                        if (comboBox1.SelectedItem.Equals("48"))
                        {
                            Cinteres = (1.5 * 48) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 48;

                            textBox1.Text = cuotaTotal.ToString();
                        }
                        if (comboBox1.SelectedItem.Equals("60"))
                        {
                            Cinteres = (1.5 * 60) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 60;

                            textBox1.Text = cuotaTotal.ToString();
                        }
                    }
                
             }
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void PS2_Load(object sender, EventArgs e)
        {

        }
    }
}
