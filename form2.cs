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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bie, dep;
            bie = Convert.ToDouble(textBox1.Text);
            if(bie > 0 && bie>5000 && bie<=1000000)
            {
                if (comboBox1.SelectedItem.Equals("vehiculos"))
                {
                    textBox1.Focus();
                    dep = bie / 5;
                    textBox2.Text=dep.ToString();
                }
                
                if (comboBox1.SelectedItem.Equals("edificios"))
                {
                    textBox1.Focus();
                        dep =bie / 20;
                    textBox2.Text = dep.ToString();
                }
                if(comboBox1.SelectedItem.Equals("computadoras"))
                {
                    textBox1.Focus();
                    dep = bie / 2;
                    textBox2.Text = dep.ToString();
                }

            }
            else
            {
                MessageBox.Show("Debe de estar entre 5000 y 1000 000", "Warning");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
