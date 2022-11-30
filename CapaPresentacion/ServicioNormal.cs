using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
<<<<<<< HEAD
using CapaEntidades;
using CapaNegocios.Usuarios;
=======
>>>>>>> 7570d2fadd59a993ecb07455f86db4b2ed7550be

namespace CapaPresentacion
{
    public partial class ServicioNormal : Form
    {
        private CDatosC cdatos = new CDatosC();
<<<<<<< HEAD

      //  public ClienteNormal ObjClienteN { get; set; }

        //public object ClienteNM { get; private set; }

=======
>>>>>>> 7570d2fadd59a993ecb07455f86db4b2ed7550be
        public ServicioNormal()
        {
            InitializeComponent();
        }

        private void guardarNormal()
        {
            string linea;
            linea = txtIdentificacion1.Text + "" + txtNombre1.Text + "" + txtApellido1.Text;


            if (cdatos.escribir1(linea) == true)

                MessageBox.Show("Ha guardado un cliente casual");

            else
                MessageBox.Show("No se ha podido guardar el cliente...");
        }

<<<<<<< HEAD
        ClsUsuarioLn clsUsuarioLn = new ClsUsuarioLn();
        private void btnGuardar1_Click(object sender, System.EventArgs e)
        {
            ClienteNormal objetocliente = new ClienteNormal()
            {
                Nombree = txtNombre1.Text,
                Apellidoo = txtApellido1.Text,
                Identificacion = txtIdentificacion1.TabIndex,
                Productoo = cbProductos1.Text,
            };
            clsUsuarioLn.Crear(ref objetocliente);

            if (objetocliente.MensajeError == null)
            {
                MessageBox.Show("Agregado correctamente");
                TablaClienteNormal mm = new TablaClienteNormal();
                mm.CargarListaClientesN();
            }
            else
            {
                MessageBox.Show(objetocliente.MensajeError);
            }
            //guardarNormal();
        }

        private void btnIrTabla_Click(object sender, EventArgs e)
        {
            using (TablaClienteNormal TCN = new TablaClienteNormal())
                TCN.ShowDialog();
=======
        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            guardarNormal();
>>>>>>> 7570d2fadd59a993ecb07455f86db4b2ed7550be
        }
    }
}
