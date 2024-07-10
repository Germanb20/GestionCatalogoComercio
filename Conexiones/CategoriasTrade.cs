using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexiones
{
    internal class CategoriasTrade
    {
        public List<Categorias> Listado()
        {
            List<Categorias> lista = new List<Categorias>();
            NuevosDatos datos = new NuevosDatos();
            try
            {
                datos.setConsulta("Select Id, Descripcion from CATEGORIAS");
                datos.ejecLectura();

                while (datos.Lector.Read())
                {
                    Categorias neww = new Categorias();
                    neww.Id = (int)datos.Lector["Id"];
                    neww.Descripcion = (string)datos.Lector["De"];

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
