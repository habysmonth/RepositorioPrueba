using CapaEntidades;
using CapaNegocios.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class TablaClienteNormal : Form
    {
       public ClienteNormal ClienteNm = null;
        public readonly ClsUsuarioLn objCliente = new ClsUsuarioLn();
        public TablaClienteNormal()
        {
            InitializeComponent();
            CargarListaClientesN();
        }

        public void CargarListaClientesN()
        {
            ClienteNm = new ClienteNormal();
            objCliente.Index(ref ClienteNm);
            if(ClienteNm.MensajeError == null)
            {
                dtwClientesCN.DataSource = ClienteNm.DtResultados;
            }
            else
            {
                MessageBox.Show(ClienteNm.MensajeError, "ERROR");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void dtwClientesCN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtwClientesCN.Columns[e.ColumnIndex].Name == "Factura")
                {

                    //using (Factura Fac = new Factura()) ;
                    //Factura h = new Factura();
                    //h.ShowDialog();

                    ClienteNormal ClienteNm = new ClienteNormal()
                    {
                        IdCliente = Convert.ToByte(dtwClientesCN.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString())
                    };

                    ClsUsuarioLn clsUsuarioLn = new ClsUsuarioLn();

                    clsUsuarioLn.Leer(ref ClienteNm);

                    lblNombre.Text = ClienteNm.Nombree;
                    lblApellido.Text = ClienteNm.Apellidoo;
                   lblId.Text = ClienteNm.Identificacion.ToString();
                    lblProducto.Text = ClienteNm.Productoo;
                    //lblNombre.Text = ClienteNm.Nombree;
                    lblIDD.Text = ClienteNm.IdCliente.ToString();




                }
            }
            catch (Exception ex)
            {

            }

            



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteNormal ClienteNm = new ClienteNormal()
            {
                IdCliente = Convert.ToByte(lblIDD.Text)
            };

            ClsUsuarioLn clsUsuarioLn = new ClsUsuarioLn();

            clsUsuarioLn.Eliminar(ref ClienteNm);

            CargarListaClientesN();
        }
    }
}
