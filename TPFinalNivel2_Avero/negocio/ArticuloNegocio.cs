using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, A.IdMarca, A.IdCategoria, M.Id, M.Descripcion Marca, C.Id, C.Descripcion Categoria From ARTICULOS A, MARCAS M, CATEGORIAS C Where M.Id = A.IdMarca And C.Id = A.IdCategoria ");
                datos.Lectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.CodigoArticulo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        articulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = datos.Lector.GetDecimal(5);
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.Consulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo,  @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.Parametro("@Codigo", nuevo.CodigoArticulo);
                datos.Parametro("@Nombre", nuevo.Nombre);
                datos.Parametro("@Descripcion", nuevo.Descripcion);
                datos.Parametro("@IdMarca", nuevo.Marca.Id);
                datos.Parametro("@IdCategoria", nuevo.Categoria.Id);
                datos.Parametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.Parametro("@Precio", nuevo.Precio);
                datos.Ejecutar();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id ");
                datos.Parametro("@Codigo", articulo.CodigoArticulo);
                datos.Parametro("@Nombre", articulo.Nombre);
                datos.Parametro("@Descripcion", articulo.Descripcion);
                datos.Parametro("@IdMarca", articulo.Marca.Id);
                datos.Parametro("@IdCategoria", articulo.Categoria.Id);
                datos.Parametro("@ImagenUrl", articulo.ImagenUrl);
                datos.Parametro("@Precio", articulo.Precio);
                datos.Parametro("@Id", articulo.Id);
                datos.Ejecutar();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                datos.CerrarConexion();
            }
        } 

        public void Borrar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.Consulta("Delete From ARTICULOS Where Id = @Id");
                datos.Parametro("@Id", articulo.Id);

                datos.Ejecutar();
            }
            catch(Exception ex) 
            {
                throw ex; 
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        { 
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio,  M.Descripcion Marca, C.Descripcion Categoria, IdCategoria, IdMarca From ARTICULOS A, MARCAS M, CATEGORIAS C Where  A.IdMarca = M.Id And A.IdCategoria = C.Id And ";

                if (campo == "Precio") 
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        case "Igual a":
                            consulta += "Precio = " + filtro;
                            break;
                        default:
                            break;
                    }

                }
                else  //(campo =="Nombre")
                {
                    if (campo == "Descripción")
                        campo = "A.Descripcion";
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += campo + " Like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += campo + " Like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += campo + " like '%" + filtro + "%' ";
                            break;
                        default:
                            break;
                    }
                }
               

                datos.Consulta(consulta);
                datos.Lectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.CodigoArticulo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        articulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = datos.Lector.GetDecimal(5);
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(articulo);
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
