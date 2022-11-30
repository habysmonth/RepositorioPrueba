using CapaDatos.BaseDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Usuarios
{
    public class ClsUsuarioLn
    {

        #region Variables Privadas
        BaseDatosNormal ObjBaseDatos = null;


        #endregion


        #region Método Index
        public void Index(ref ClienteNormal ObjClienteN)
        {
            ObjBaseDatos = new BaseDatosNormal()
            {
                NombreNabla = "ClientesCasuales",
                Nombresp = "[SCH_GENERAL].[sp_ClientesCasuales_Index]",
                Escalar = false
            };

            Ejecutar(ref ObjClienteN);

        }
        #endregion


        #region CRUD Cliente Normal


        public void Crear(ref ClienteNormal ObjClienteN)
        {
            ObjBaseDatos = new BaseDatosNormal()
            {
                NombreNabla = "ClientesCasuales",
                Nombresp = "[SCH_GENERAL].[sp_ClientesCasuales_Create]",
                Escalar = true
            };

            ObjBaseDatos.DtParametros.Rows.Add(@"@Nombre", "17", ObjClienteN.Nombree);
            ObjBaseDatos.DtParametros.Rows.Add(@"@Apellido", "17", ObjClienteN.Apellidoo);
            ObjBaseDatos.DtParametros.Rows.Add(@"@Identificacion", "4", ObjClienteN.Identificacion);
            ObjBaseDatos.DtParametros.Rows.Add(@"@Producto", "17", ObjClienteN.Productoo);

            Ejecutar(ref ObjClienteN);

        }

        public void Leer(ref ClienteNormal ObjClienteN)
        {
            ObjBaseDatos = new BaseDatosNormal()
            {
                NombreNabla = "ClientesCasuales",
                Nombresp = "[SCH_GENERAL].[sp_ClientesCasuales_Read]",
                Escalar = false
            };

            ObjBaseDatos.DtParametros.Rows.Add(@"@IdUsuario", "2", ObjClienteN.IdCliente);
            Ejecutar(ref ObjClienteN);

        }

        public void Actualizar(ref ClienteNormal ObjClienteN)
        {
            ObjBaseDatos = new BaseDatosNormal()
            {
                NombreNabla = "ClientesCasuales",
                Nombresp = "[SCH_GENERAL].[sp_ClientesCasuales_Update]",
                Escalar = true
            };

            ObjBaseDatos.DtParametros.Rows.Add(@"@IdUsuario", "2", ObjClienteN.IdCliente);
            ObjBaseDatos.DtParametros.Rows.Add(@"@Nombre", "17", ObjClienteN.Nombree);
            ObjBaseDatos.DtParametros.Rows.Add(@"@Apellido", "17", ObjClienteN.Apellidoo);
            ObjBaseDatos.DtParametros.Rows.Add(@"@Identificacion", "4", ObjClienteN.Identificacion);
            ObjBaseDatos.DtParametros.Rows.Add(@"@Producto", "17", ObjClienteN.Productoo);

            Ejecutar(ref ObjClienteN);

        }

        public void Eliminar(ref ClienteNormal ObjClienteN)
        {
            ObjBaseDatos = new BaseDatosNormal()
            {
                NombreNabla = "ClientesCasuales",
                Nombresp = "[SCH_GENERAL].[sp_ClientesCasuales_Delete]",
                Escalar = true
            };

            ObjBaseDatos.DtParametros.Rows.Add(@"@IdUsuario", "2", ObjClienteN.IdCliente);
            Ejecutar(ref ObjClienteN);

        }
        #endregion


        #region Métodos Privados

        private void Ejecutar(ref ClienteNormal objClienteN)
        {
            ObjBaseDatos.CRUD(ref ObjBaseDatos);

            if (ObjBaseDatos.MensajeErrorBD == null)
            {
                if (ObjBaseDatos.Escalar)
                {
                    objClienteN.ValorEscalar = ObjBaseDatos.ValorEscalar;
                }
                else
                {
                    objClienteN.DtResultados = ObjBaseDatos.DsResultados.Tables[0];
                    if(objClienteN.DtResultados.Rows.Count == 1)
                    {
                        foreach(DataRow item in objClienteN.DtResultados.Rows)
                        {
                            objClienteN.IdCliente = Convert.ToByte(item["IdUsuario"].ToString());
                            objClienteN.Nombree = item["Nombre"].ToString();
                            objClienteN.Apellidoo = item["Apellido"].ToString();
                            objClienteN.Identificacion = Convert.ToInt32(item["Identificacion"].ToString());
                            objClienteN.Productoo = item["Producto"].ToString();
                        }
                    }
                }
            }
            else
            {
                objClienteN.MensajeError = ObjBaseDatos.MensajeErrorBD;
            }
            
        }

        #endregion


    }
}
