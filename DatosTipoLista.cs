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
    public partial class DatosTipoLista : Form
    {
        List<ClsLista> miLista =  new List<ClsLista>();
        public DatosTipoLista()
        {
            InitializeComponent();
            tslConsultar.Enabled = false;
            tslEliminar.Enabled = false;
        }

        private void tslRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarRaza() == false)
            {
                return;
            }
            if (ValidarEdad() == false)
            {
                return;
 }
                if (Existe(txtNombre.Text))
                {
                    erpError.SetError(txtNombre, "La mascotra con ese nombre ya esta regitrada");
                LimpiarControles();
                    txtNombre.Focus();
                    return;
                }
                erpError.SetError(txtNombre, "");
           
            //Creamos un objeto de la Clase lista
            ClsLista miMascota = new ClsLista();
            miMascota.Nombre = txtNombre.Text;
            miMascota.Raza = cmbRaza.SelectedItem.ToString();
            miMascota.Edad = int.Parse(txtEdad.Text);
            miLista.Add(miMascota);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = miLista;
            LimpiarControles();
            txtNombre.Focus();
            tslConsultar.Enabled = true;
            
        }
        //Metodo que valida que no acepte mascotas con el mismo nombre 
        private bool Existe(string Nombre)
        {
            foreach (ClsLista miMascota in miLista)
            {
                if ( miMascota.Nombre == Nombre )
                {
                    return true;
                }
                
            }
            return false;
        }

        private bool ValidarEdad()
        {
            int Edad;
            if (!int.TryParse(txtEdad.Text, out Edad) || txtEdad.Text == "")
            {
                erpError.SetError(txtEdad, "Debe ingrasar un valor numerico para la edad");
                txtEdad.Clear();
                txtEdad.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtEdad, "");
                return true;
            }
        }

        private bool ValidarRaza()
        {
            if (string.IsNullOrEmpty(cmbRaza.Text))
            {
                erpError.SetError(cmbRaza, "Debe selecionar una Raza");
                return false;
            }
            else
            {
                erpError.SetError(cmbRaza, "");
                return true;
            }
        }


        // validamos el nombre 
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Debe ingresar su nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;
            }
        }

        //Metodo para limpiar los controles 
        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            cmbRaza.SelectedIndex = 0;
        }

        private void tslSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento de la opcion consultar 
        private void tslConsultar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            ClsLista miMascota = GetMascota(txtNombre.Text) ;
            if (miMascota == null)
            {
                erpError.SetError(txtNombre,"La mascota no se encuntra regitrada en la lista");
                LimpiarControles();
                txtNombre.Focus();
                return;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                txtNombre.Text = miMascota.Nombre;
                cmbRaza.SelectedItem = miMascota.Raza;
                txtEdad.Text = miMascota.Edad.ToString();
                tslEliminar.Enabled = true;
            }
        }
        //El metodo de obtener o consultar la mascota 
        private ClsLista GetMascota(string nombre )
        {
            return miLista.Find(mascota => mascota.Nombre.Contains(nombre)) ;
        }
        //Evento de la opcion eliminar 
        private void tslEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                erpError.SetError(txtNombre, "Debe consultar la mascota a Eliminar");
                LimpiarControles();
                txtNombre.Focus();
                tslEliminar.Enabled = false;
                return;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                DialogResult Respuesta = MessageBox.Show("Esta seguro de Eliminar el registro",
                    "confirmacion ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (ClsLista miMascota in miLista)
                    {
                        if ( miMascota.Nombre == txtNombre.Text)
                        {
                            miLista.Remove(miMascota);
                            break;
                        }
                    }
                    LimpiarControles();
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = miLista;
                }
            }
        }
    }
}
