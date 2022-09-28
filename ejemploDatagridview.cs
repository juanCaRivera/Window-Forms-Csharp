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
    public partial class ejemploDatagridview : Form
    {
        public ejemploDatagridview()
        {
            InitializeComponent();
        }

        private void ejemploDatagridview_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double precio, subtotal , cantidad;
            precio = Convert.ToDouble(maskedTextBox1.Text);
            cantidad = Convert.ToDouble(maskedTextBox2.Text);
            subtotal = cantidad * precio;
            textBox1.Text = subtotal.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = maskedTextBox1.Text;
            row.Cells[1].Value = maskedTextBox2.Text;
            row.Cells[2].Value = textBox1.Text;
            dataGridView1.Rows.Add(row);
        }
    }
}
