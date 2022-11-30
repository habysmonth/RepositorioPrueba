using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.BaseDatos
{
    public class BaseDatosNormal
    {

        #region Variables Privadas

        private SqlConnection _objsqlconnection;
        private SqlDataAdapter _objsqladapter;
        private SqlCommand _objsqlcommand;
        private DataSet _dsResultados;
        private DataTable _dtParametros;
        private string _nombreNabla, _nombreSP, _mensajeErrorBD, _valorEscalar, _nombreBD;
        private bool _escalar;



        #endregion



        #region Variables Publicas
        public SqlConnection Objsqlconnection { get => _objsqlconnection; set => _objsqlconnection = value; }
        public SqlDataAdapter Objsqladapter { get => _objsqladapter; set => _objsqladapter = value; }
        public SqlCommand Objsqlcommand { get => _objsqlcommand; set => _objsqlcommand = value; }
        public DataSet DsResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string NombreNabla { get => _nombreNabla; set => _nombreNabla = value; }
        public string Nombresp { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorBD { get => _mensajeErrorBD; set => _mensajeErrorBD = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public string NombreBD { get => _nombreBD; set => _nombreBD = value; }
        public bool Escalar { get => _escalar; set => _escalar = value; }

        #endregion



        #region Constructores

        public BaseDatosNormal()
        {
            DtParametros = new DataTable("SpParametros");
            DtParametros.Columns.Add("Nombre");
            DtParametros.Columns.Add("TipoDato");
            DtParametros.Columns.Add("Valor");


            //NombreBD = string.Empty;
            NombreBD = "BD_BaseNormal";
        }

        #endregion



        #region Métodos Privados
        private void CrearConexionBaseDatos(ref BaseDatosNormal objBaseDatos)
        {
            switch (objBaseDatos.NombreBD)
            {

                case "BD_BaseNormal":
                    objBaseDatos.Objsqlconnection = new SqlConnection(Properties.Settings.Default.CadenaConexion_BD_BaseNormal);
                    break;
                                                                    
                case "BD_BaseEspecial":                          
                    objBaseDatos.Objsqlconnection = new SqlConnection(Properties.Settings.Default.CadenaConexion_BD_BaseEspecial);
                 break;


                default:
                    break;
            }

        }

        private void ValidarConexionBaseDatos(ref BaseDatosNormal objBaseDatos)
        {
            if(objBaseDatos.Objsqlconnection.State == ConnectionState.Closed)
            {
                objBaseDatos.Objsqlconnection.Open();
            }
            else
            {
                objBaseDatos.Objsqlconnection.Close();
                objBaseDatos.Objsqlconnection.Dispose();
            };
        }

        private void AgregarParametros(ref BaseDatosNormal objBaseDatos)
        {
            if(objBaseDatos.DtParametros != null)
            {
                SqlDbType TipoDatoSQL = new SqlDbType();

                foreach (DataRow item in objBaseDatos.DtParametros.Rows)
                {
                    switch (item[1])
                    {
                        case "1":
                            TipoDatoSQL = SqlDbType.Bit;
                            break;

                        case "2":
                            TipoDatoSQL = SqlDbType.TinyInt;
                            break;

                        case "3":
                            TipoDatoSQL = SqlDbType.SmallInt;
                            break;

                        case "4":
                            TipoDatoSQL = SqlDbType.Int;
                            break;

                        case "5":
                            TipoDatoSQL = SqlDbType.BigInt;
                            break;

                        case "6":
                            TipoDatoSQL = SqlDbType.Decimal;
                            break;

                        case "7":
                            TipoDatoSQL = SqlDbType.SmallMoney;
                            break;

                        case "8":
                            TipoDatoSQL = SqlDbType.Money;
                            break;

                        case "9":
                            TipoDatoSQL = SqlDbType.Float;
                            break;

                        case "10":
                            TipoDatoSQL = SqlDbType.Real;
                            break;

                        case "11":
                            TipoDatoSQL = SqlDbType.Date;
                            break;

                        case "12":
                            TipoDatoSQL = SqlDbType.Time;
                            break;

                        case "13":
                            TipoDatoSQL = SqlDbType.SmallDateTime;
                            break;

                        case "14":
                            TipoDatoSQL = SqlDbType.DateTime;
                            break;

                        case "15":
                            TipoDatoSQL = SqlDbType.Char;
                            break;

                        case "16":
                            TipoDatoSQL = SqlDbType.NChar;
                            break;

                        case "17":
                            TipoDatoSQL = SqlDbType.VarChar;
                            break;

                        case "18":
                            TipoDatoSQL = SqlDbType.NVarChar;
                            break;

                        default:
                            break;
                    };

                    if (objBaseDatos.Escalar)
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            objBaseDatos.Objsqlcommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        }
                        else
                        {
                            objBaseDatos.Objsqlcommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();
                        };
                    }
                    else
                    {

                        if (item[2].ToString().Equals(string.Empty))
                        {
                            objBaseDatos.Objsqladapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        }
                        else
                        {
                            objBaseDatos.Objsqladapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();
                        };

                    };

                };
            }
        }

        private void PrepararConexionBaseDatos(ref BaseDatosNormal objBaseDatos)
        {
            CrearConexionBaseDatos(ref objBaseDatos);
            ValidarConexionBaseDatos(ref objBaseDatos);


        }

        private void EjecutarDateAdapter(ref BaseDatosNormal objBaseDatos)
        {
            try
            {
                PrepararConexionBaseDatos(ref objBaseDatos);

                objBaseDatos.Objsqladapter = new SqlDataAdapter(objBaseDatos.Nombresp, objBaseDatos.Objsqlconnection);
                objBaseDatos.Objsqladapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametros(ref objBaseDatos);
                objBaseDatos.DsResultados = new DataSet();
                objBaseDatos.Objsqladapter.Fill(objBaseDatos.DsResultados, objBaseDatos.NombreNabla);

            }
            catch (Exception e)
            {
                objBaseDatos.MensajeErrorBD = e.Message.ToString();
            }
            finally
            {
                if (objBaseDatos.Objsqlconnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref objBaseDatos);
                }

            }
        }

        private void EjecutarCommand(ref BaseDatosNormal objBaseDatos)
        {
            try
            {
                PrepararConexionBaseDatos(ref objBaseDatos);

                objBaseDatos.Objsqlcommand = new SqlCommand(objBaseDatos.Nombresp, objBaseDatos.Objsqlconnection)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                AgregarParametros(ref objBaseDatos);

                if (objBaseDatos.Escalar)
                {
                    objBaseDatos.ValorEscalar = objBaseDatos.Objsqlcommand.ExecuteScalar().ToString().Trim();
                    objBaseDatos.Objsqlcommand.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                objBaseDatos.MensajeErrorBD = e.Message.ToString();
            }
            finally
            {
                if (objBaseDatos.Objsqlconnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref objBaseDatos);
                }
            }
        }


        #endregion



        #region Métodos Públicos

        public void CRUD(ref BaseDatosNormal objBaseDatos)
        {
            if (objBaseDatos.Escalar)
            {
                EjecutarCommand(ref objBaseDatos);
            }
            else
            {
                EjecutarDateAdapter(ref objBaseDatos);
            }
        }

        #endregion
    }


}
