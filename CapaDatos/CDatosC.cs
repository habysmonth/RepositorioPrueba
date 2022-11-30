using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.IO;

namespace CapaDatos
{
    public class CDatosC
    {
        string ruta = "C:\\Users\\Estudiante\\Desktop\\VentaServicios2\\Prueba\\Datos.txt";

        public bool escribir1(string linea)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(linea);
                sw.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
