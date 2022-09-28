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
    public partial class ImpuestoSS : Form
    {
        public ImpuestoSS()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ImpuestoSS_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;   
            textBox3.Enabled = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            double ing, il, ip;
            ing=Convert.ToDouble(textBox1.Text);
            if(ing<0 && ing>=4800 && ing <= 500000)
            {
                if (comboBox1.SelectedItem.Equals ( "laboral"))
                {
                    il = 0.07 * ing;
                    textBox2.Text =il.ToString();
                    textBox3.Text = "";
                }
                else
                {
                    ip = 0.2 * ing;
                    textBox3.Text =ip.ToString();
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debe de estar entre 4800 y 500 000","Warning");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
