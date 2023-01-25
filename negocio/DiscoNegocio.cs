using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato, D.IdEstilo,D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Fecha = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Genero = new Estilo();
                    aux.Genero.Id = (int)datos.Lector["IdEstilo"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];
                    aux.Formato = new Edicion();
                    aux.Formato.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Formato.Descripcion = (string)datos.Lector["Formato"];

                    lista.Add(aux);
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

        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {                              
                datos.setearConsulta("Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) values (@Titulo, @Fecha, @Canciones, @Img, @IdEstilo, @IdEdIcion)");
                datos.setearParametro("@Titulo",nuevo.Titulo);
                datos.setearParametro("@Fecha",nuevo.Fecha);
                datos.setearParametro("@Canciones",nuevo.CantidadCanciones);
                datos.setearParametro("@Img",nuevo.UrlImagen);
                datos.setearParametro("@IdEstilo",nuevo.Genero.Id);
                datos.setearParametro("@IdEdicion",nuevo.Formato.Id);
                datos.ejecutarAccion();
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

        public void modificar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {              
                datos.setearConsulta("Update DISCOS set Titulo = @Titulo, FechaLanzamiento = @Fecha, CantidadCanciones = @Canciones, UrlImagenTapa = @Img, IdEstilo = @IdEstilo,IdTipoEdicion = @IdEdicion where Id = @Id");
                datos.setearParametro("@Titulo", disco.Titulo);
                datos.setearParametro("@Fecha", disco.Fecha);
                datos.setearParametro("@Canciones", disco.CantidadCanciones);
                datos.setearParametro("@Img", disco.UrlImagen);
                datos.setearParametro("@IdEstilo", disco.Genero.Id);
                datos.setearParametro("@IdEdicion", disco.Formato.Id);
                datos.setearParametro("@Id", disco.Id);
                datos.ejecutarAccion();
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

        public void eliminar(int Id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {            
                datos.setearConsulta("delete from DISCOS where Id = @Id");
                datos.setearParametro("@Id",Id);
                datos.ejecutarAccion();
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

        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato, D.IdEstilo,D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id And ";
                if (campo == "Título")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Titulo like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Titulo like '%" + filtro + "' ";
                            break;
                        default:
                            consulta += "Titulo like '%" + filtro + "%' ";
                            break;
                    }
                }
                else if (campo == "Cantidad de canciones")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "CantidadCanciones > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "CantidadCanciones < " + filtro;
                            break;
                        default:
                            consulta += "CantidadCanciones = " + filtro;
                            break;
                    }
                }
                else if (campo == "Género")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "E.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "E.Descripcion like '%" + filtro + "' ";
                            break;
                        default:
                            consulta += "E.Descripcion like '%" + filtro + "%' ";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Fecha = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Genero = new Estilo();
                    aux.Genero.Id = (int)datos.Lector["IdEstilo"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];
                    aux.Formato = new Edicion();
                    aux.Formato.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Formato.Descripcion = (string)datos.Lector["Formato"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
