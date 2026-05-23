using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {

                conexion.ConnectionString = "server=localhost; database=CATALOGO_P3_DB; user id=sa; password=BaseDatos#2;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.Precio, (SELECT TOP 1 ImagenUrl FROM IMAGENES WHERE IdArticulo = A.Id) ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    if (!(lector.IsDBNull(lector.GetOrdinal("Precio"))))
                        aux.Precio = (decimal)lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];

                    aux.Imagenes = new List<Imagenes>();

                    ImagenesNegocio imgNegocio = new ImagenesNegocio(); 
                    aux.Imagenes = imgNegocio.listarImagenes(aux.Id);

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ToString());
                throw ex;
            }

        }
        
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria); SELECT SCOPE_IDENTITY();");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.IdCategoria);
                datos.setearParametro("@Precio", nuevo.Precio);
                int idNuevo = datos.ejecutarScalar();
                datos.cerrarConexion();
                foreach (var imagenes in nuevo.Imagenes)
                {
                    AccesoDatos datosImg = new AccesoDatos();
                    datosImg.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @Url)");
                    datosImg.setearParametro("@IdArticulo", idNuevo);
                    datosImg.setearParametro("@Url", imagenes.ImagenUrl);

                    datosImg.ejectuarAccion();
                    datosImg.cerrarConexion();
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void modificarArticulo(Articulo producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @Id");
                datos.setearParametro("@Codigo", producto.Codigo);
                datos.setearParametro("@Nombre", producto.Nombre);
                datos.setearParametro("@Descripcion", producto.Descripcion);
                datos.setearParametro("@IdMarca", producto.Marca.Id);
                datos.setearParametro("@IdCategoria", producto.Categoria.IdCategoria);
                datos.setearParametro("@Precio", producto.Precio);
                datos.setearParametro("@Id", producto.Id);
               
                datos.ejectuarAccion();
                datos.cerrarConexion();
                AccesoDatos datosBorrar = new AccesoDatos();
                datosBorrar.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @Id");
                datosBorrar.setearParametro("@Id", producto.Id);
                datosBorrar.ejectuarAccion();
                datosBorrar.cerrarConexion();
                foreach (var imagenes in producto.Imagenes)
                {
                    AccesoDatos datosImagenes = new AccesoDatos();

                    datosImagenes.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @UrlImagen)");
                    datosImagenes.setearParametro("@IdArticulo", producto.Id);
                    datosImagenes.setearParametro("@UrlImagen", imagenes.ImagenUrl);

                    datosImagenes.ejectuarAccion();
                    datosImagenes.cerrarConexion();
                }
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
        public void eliminarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejectuarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

         public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.Precio, I.ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo AND ";
                switch (campo)
                {
                    case "Codigo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Codigo LIKE '"+ filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Codigo LIKE '%" + filtro + "' ";
                                break;
                            default:
                                consulta += "A.Codigo LIKE '%" + filtro + "%' ";
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Nombre LIKE '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Nombre LIKE '%" + filtro + "' ";
                                break;
                            default:
                                consulta += "A.Nombre LIKE '%" + filtro + "%' ";
                                break;
                        }
                        break;
                    case "Descripcion":
                        switch (criterio) {
                            case "Comienza con":
                                consulta += "A.Descripcion LIKE '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Descripcion LIKE '%" + filtro + "' ";
                                break;
                            default:
                                consulta += "A.Descripcion LIKE '%" + filtro + "%' ";
                                break;
                        }
                        break;
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "A.Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "A.Precio < " + filtro;
                                break;
                            default:
                                consulta += "A.Precio = " + filtro;
                                break;
                        }
                        break;
                    default:
                        break;
                }
                datos.setearConsulta(consulta);
                datos.ejectuarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Precio"))))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Imagenes = new List<Imagenes>();

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.Imagenes.Add(new Imagenes{ImagenUrl = datos.Lector["ImagenUrl"].ToString()});
                    }

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool existeCodigo(string codigo, int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Codigo FROM ARTICULOS WHERE Codigo = @Codigo AND Id != @id");
                datos.setearParametro("@codigo", codigo);
                datos.setearParametro("@id", id);
                datos.ejectuarLectura();

                if (datos.Lector.Read())
                    return true;
                else
                    return false;
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
