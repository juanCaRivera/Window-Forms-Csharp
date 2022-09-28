#region Sistema Usign
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion


namespace Ejemplo
{
    public partial class DataGridView : Form
    {
        private int n = 0;

        public DataGridView()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Adicionamos nuevo renglon 
            int n = dtgvProductos.Rows.Add();

            //Colocamos la informacion 
            dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;
            
            //Limpiamos los campos
            txtCodigo.Text = ""; 
            txtNombre.Text = "";
            txtPrecio.Text = "";
            

        }
        //Opcion leer contenido 
        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             n = e.RowIndex;
            //con esto podemos leer el contenido 
            if (n!= -1)
            {
                lblInformacion.Text = (string)dtgvProductos.Rows[n].Cells[1].Value;
            }
        }
        //para organizar mejor el codigo
        #region METODOS PRIVADOS
        //codigo para eliminar 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n!= -1)
            {
                dtgvProductos.Rows.RemoveAt(n);
            }
        }
        #endregion
    }
}
