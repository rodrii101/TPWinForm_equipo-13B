using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class ImagenesNegocio
    {
        public List<Imagenes> listarImagenes(int id)
        {
            List<Imagenes> imaganes = new List<Imagenes>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, ImagenUrl FROM IMAGENES WHERE IdArticulo = @Id");
                datos.setearParametro("@Id", id);
                datos.ejectuarLectura();
                while (datos.Lector.Read())
                {
                    Imagenes aux = new Imagenes();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.ImagenUrl = datos.Lector["ImagenUrl"].ToString();
                    imaganes.Add(aux);
                }
                return imaganes;
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
