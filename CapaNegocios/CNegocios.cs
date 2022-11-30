using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CapaEntidades;

namespace CapaNegocios
{
    public class CNegocios
    {
        private List<Persona> p = new List<Persona>();

        public void agregarPersona(Persona e)
        {
            p.Add(e);
        }

        public List<Persona> coleccionP()
        {
            return p;
        }

        public CNegocios cnegocios()
        {
            try
            {
                CNegocios cne = new CNegocios();
                StreamReader sr = new StreamReader("C:\\Users\\Estudiante\\Desktop\\VentaServicios2\\Prueba\\Datos.txt");
                string linea;

                while (!sr.EndOfStream)
                {
                    ClienteNormal cl = new ClienteNormal();
                    linea = sr.ReadLine();

                    string[] i = linea.Split(';');
                    cl.Id = int.Parse(i[0]);
                    cl.Nombre = i[1];
                    cl.Apellido = i[2];
                    cl.producto = i[3];

                    cne.agregarPersona(cl);
                   
                }
                sr.Close();
                return cne;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
