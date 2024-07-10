using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Conexiones
{
    internal class MarcasTrade
    {
        public List<Marcas> Listado()
        {
            List<Marcas> lista = new List<Marcas>();
            NuevosDatos datos = new NuevosDatos();

            try
            {
                datos.setConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Marcas neww = new Marcas();
                    neww.Id = (int)datos.Lector["Id"];
                    neww.Descripcion = (string)datos.Lector["Descrpcion"];

                    lista.Add(neww);
                }
                return lista;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }
    }
}
