using System;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
            textBox4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3,r;
            nota1 = Convert.ToDouble(textBox1.Text);
            nota2 = Convert.ToDouble(textBox2.Text);
            nota3 = Convert.ToDouble(textBox3.Text);
            if (nota1 > 0 && nota1  <= 10 && nota2 > 0 && nota2 <= 10 && nota3 > 0 && nota3 <= 10)
            {

                if (nota1 > 0 && nota1 <= 10 && nota2 > 0 && nota2 <= 10 && nota3 > 0 && nota3 <= 10)
                {
                    r = nota1 + nota2 + nota3;
                    textBox4.Text = r.ToString();
                }
                else
                {
                    MessageBox.Show("No puede ser - ni 0 ni mayor al ingreso", "Adventencia");
                    limpiarClean();
                }

            }
            else
            {

                MessageBox.Show("No puede ser negativo ni cero", "Adventencia");
               limpiarClean();
            }


        }
        private void limpiarClean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Notas_Load(object sender, EventArgs e)
        {

        }
    }
    }

