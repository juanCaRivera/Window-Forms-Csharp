using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Ejemplo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(TxtbUser.Text == "Juan Rivera" && TxtbPass.Text == "123456")
            {
                new MDI().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Infiltrado");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TxtbUser.Clear();
            TxtbPass.Clear();
            TxtbUser.Focus();
        }

        private void TxtbUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
