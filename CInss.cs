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
    public partial class CInss : Form
    {
        public CInss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ing, cil;
            ing = Convert.ToDouble(textBox1.Text);
            if (ing > 0)
            {
                cil = 0.07 * ing;
                textBox2.Text = cil.ToString();
            }
            else
            {
                MessageBox.Show("El Ingreso debe ser positivo", "Warning");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void CInss_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
