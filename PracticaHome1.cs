using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejemplo
{
    public partial class PracticaHome1 : Form
    {
        public PracticaHome1()
        {
            InitializeComponent();
        }

      
            #region Acapite del ejercicio 1
            // Programa que permita  a una  tienda saber  el valor que pagara
            // un cliente por  la compra  de varios elementos de  la misma  referencia.
            // Debe tener como entradas  el valor  unitario,  la cantidad  de productos
            // comprados y al valor final  se debe adicionar el 16 %
            // correspondiente al IVA
            #endregion
      

        private void BTNCalcular_Click(object sender, EventArgs e)
        {

            double CantidadProducto, Precio, Iva, Total ;
            CantidadProducto = Convert.ToDouble(MTBPrecio.Text); 
            if (CMBProductos.SelectedItem.Equals("Cervezas"))
            {
                Precio = 35.99;
                Iva = (16.0 / 100.0) * Precio;
                Total = (CantidadProducto * Precio) + Iva ;
                TXTBResultado.Text = Total.ToString();
                
            }
            if (CMBProductos.SelectedItem.Equals("Ron"))
            {
                Precio = 200.99;
                Iva = (16.0 / 100.0) * Precio;
                Total = (CantidadProducto * Precio) + Iva;
                TXTBResultado.Text = Total.ToString();

            }
            if (CMBProductos.SelectedItem.Equals("Tequila"))
            {
                Precio = 350.99;
                Iva = (16.0 / 100.0) * Precio;
                Total = (CantidadProducto * Precio) + Iva;
                TXTBResultado.Text = Total.ToString();

            }
            if (CMBProductos.SelectedItem.Equals("Wiski"))
            {
                Precio = 600.99;
                Iva = (16.0 / 100.0) * Precio;
                Total = (CantidadProducto * Precio) + Iva;
                TXTBResultado.Text = Total.ToString();

            }
        }

        private void CMBProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTBResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void MTBPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
