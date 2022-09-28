using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class PS2switch : Form
    {
        public PS2switch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = comboBox1.Text;
            double monto, cuotaTotal, Cinteres, interes;
            monto = Convert.ToDouble(maskedTextBox1.Text);
            //consumo
            if (monto >= 100 && monto <= 10000) 
            {
                if (radioButton1.Checked == true)
                {
                            switch (word)
                    {
                        case "6":
                            Cinteres = (1.25 * 6) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 6;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "9":
                            Cinteres = (1.25 * 9) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 9;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "12":
                            Cinteres = (1.25 * 12) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 12;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "18":
                            Cinteres = (1.25 * 18) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 18;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "24":
                            Cinteres = (1.25 * 24) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 24;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "36":
                            Cinteres = (1.25 * 36) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 36;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "48":
                            Cinteres = (1.25 * 48) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 48;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "60":
                            Cinteres = (1.25 * 60) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 60;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        default:
                            MessageBox.Show("seleccione una cuota ");
                            break;
                    }
                }
                 else if (radioButton2.Checked == true)
                {
                    switch (word)
                    {
                        case "6":
                            Cinteres = (1.5 * 6) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 6;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "9":
                            Cinteres = (1.5 * 9) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 9;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "12":
                            Cinteres = (1.5 * 12) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 12;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "18":
                            Cinteres = (1.5 * 18) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 18;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "24":
                            Cinteres = (1.5 * 24) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 24;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "36":
                            Cinteres = (1.5 * 36) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 36;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "48":
                            Cinteres = (1.5 * 48) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 48;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        case "60":
                            Cinteres = (1.5 * 60) / 100;
                            interes = (Cinteres * monto);
                            cuotaTotal = (interes + monto) / 60;

                            textBox1.Text = cuotaTotal.ToString();
                            break;
                        default:
                            MessageBox.Show("seleccione una cuota ");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione un tipo de prestamo");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un monto mayor a 100 y menor a 10,000");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

        }
    }
}
