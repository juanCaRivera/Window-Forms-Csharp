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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            n1=Convert.ToDouble(textBox1.Text);
            n2=Convert.ToDouble(textBox2.Text);
            if (n1 > 0 && n2 > 0)
            {
                if (radioButton1.Checked == true)
                {
                    //textBox1.Text = "";
                   // textBox2.Text = "";
                    res = n1 + n2;
                    textBox3.Text = res.ToString();
                }
                
                    if (radioButton2.Checked == true)
                    {
                       // textBox1.Text = "";
                       // textBox2.Text = "";
                        res = n1 - n2;
                        textBox3.Text = res.ToString();
                    
                    }
               
                if(radioButton3.Checked == true)
                {
                   // textBox1.Text = "";
                    //textBox2.Text = "";
                    res = n1 * n2;
                    textBox3.Text = res.ToString();
                }
                if(radioButton4.Checked == true)
                {
                   // textBox1.Text = "";
                    //textBox2.Text = "";
                    res = n1 / n2;
                    textBox3.Text = res.ToString();
                }

            }
            else
            {
                MessageBox.Show("debe de ser positivo", "warning");
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

   
    }
}
