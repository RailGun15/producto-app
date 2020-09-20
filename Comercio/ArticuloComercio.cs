using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Comercio
{
    public class ArticuloComercio
    {
        
        public List<Articulo> Listar()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            List<Articulo> artList = new List<Articulo>();

            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT A.Id,A.Codigo,A.Nombre,ISNULL(A.Descripcion,''),M.id,ISNULL(M.Descripcion,'') AS Marca,C.id,ISNULL(C.Descripcion,'') AS Categoria,ISNULL(A.ImagenUrl,''),A.Precio FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id = A.IdMarca LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria;";
            command.Connection = connection;

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Articulo aux = new Articulo();
                aux.Id = (int)reader["Id"];
                aux.CodArticulo = reader.GetString(1);
                aux.Nombre = reader.GetString(2);
                aux.Descripcion = reader.GetString(3);
                aux.UrlImagen = reader.GetString(8);

                aux.Marca = new Marca();
                aux.Marca.Nombre = reader.GetString(5);
                aux.Marca.Id = (int)reader["id"];
                aux.Categoria = new Categoria();
                aux.Categoria.Nombre = reader.GetString(7);
                aux.Categoria.Id = (int)reader["id"];
                aux.UrlImagen = reader.GetString(8);
                aux.Precio = reader.GetDecimal(9);

                artList.Add(aux);
            }

            connection.Close();

            return artList;


        }

        public void editar(Articulo editado)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update ARTICULOS set Codigo=@codigo,Nombre=@nombre,Descripcion=NULLIF(@descripcion,''),IdMarca=@marca,IdCategoria=@categoria,ImagenUrl=NULLIF(@imagen,''),Precio=@precio where id = @id;";
            command.Parameters.AddWithValue("@id", editado.Id);
            command.Parameters.AddWithValue("@codigo", editado.CodArticulo);
            command.Parameters.AddWithValue("@nombre", editado.Nombre);
            command.Parameters.AddWithValue("@descripcion", editado.Descripcion);
            command.Parameters.AddWithValue("@marca", editado.Marca.Id);
            command.Parameters.AddWithValue("@categoria", editado.Categoria.Id);
            command.Parameters.AddWithValue("@imagen", editado.UrlImagen);
            command.Parameters.AddWithValue("@precio", editado.Precio);
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Eliminar(int id)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM ARTICULOS WHERE Id = @Id;";
            command.Parameters.AddWithValue("@Id", id);

            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void Cargar(Articulo art)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) VALUES (@codigo,@nombre,NULLIF(@descripcion,''),@marca,@categoria,NULLIF(@imagen,''),@precio);";
            command.Parameters.AddWithValue("@codigo", art.CodArticulo);
            command.Parameters.AddWithValue("@nombre", art.Nombre);
            command.Parameters.AddWithValue("@descripcion", art.Descripcion);
            command.Parameters.AddWithValue("@marca", art.Marca.Id);
            command.Parameters.AddWithValue("@categoria", art.Categoria.Id);
            command.Parameters.AddWithValue("@imagen", art.UrlImagen);
            command.Parameters.AddWithValue("@precio", art.Precio);
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();

            connection.Close();
        }

        public List<Articulo> BuscarMarca(Marca m)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            List<Articulo> artList = new List<Articulo>();

            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT A.Id,A.Codigo,A.Nombre,ISNULL(A.Descripcion,''),ISNULL(M.Descripcion,'') AS Marca,ISNULL(C.Descripcion,'') AS Categoria,ISNULL(A.ImagenUrl,''),A.Precio FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id = A.IdMarca LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria WHERE IdMarca = @marca;";
            command.Parameters.AddWithValue("@marca", m.Id);

            command.Connection = connection;

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Articulo aux = new Articulo();
                aux.Id = (int)reader["Id"];
                aux.CodArticulo = reader.GetString(1);
                aux.Nombre = reader.GetString(2);
                aux.Descripcion = reader.GetString(3);
                aux.UrlImagen = reader.GetString(6);

                aux.Marca = new Marca();
                aux.Marca.Nombre = reader.GetString(4);
                aux.Categoria = new Categoria();
                aux.Categoria.Nombre = reader.GetString(5);
                aux.UrlImagen = reader.GetString(6);
                aux.Precio = reader.GetDecimal(7);

                artList.Add(aux);
            }

            connection.Close();

            return artList;
        }

        public List<Articulo> BuscarCategoria(Categoria c)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            List<Articulo> artList = new List<Articulo>();

            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT A.Id,A.Codigo,A.Nombre,ISNULL(A.Descripcion,''),ISNULL(M.Descripcion,'') AS Marca,ISNULL(C.Descripcion,'') AS Categoria,ISNULL(A.ImagenUrl,''),A.Precio FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id = A.IdMarca LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria WHERE IdCategoria = @categoria;";
            command.Parameters.AddWithValue("@categoria", c.Id);

            command.Connection = connection;

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Articulo aux = new Articulo();
                aux.Id = (int)reader["Id"];
                aux.CodArticulo = reader.GetString(1);
                aux.Nombre = reader.GetString(2);
                aux.Descripcion = reader.GetString(3);
                aux.UrlImagen = reader.GetString(6);

                aux.Marca = new Marca();
                aux.Marca.Nombre = reader.GetString(4);
                aux.Categoria = new Categoria();
                aux.Categoria.Nombre = reader.GetString(5);
                aux.UrlImagen = reader.GetString(6);
                aux.Precio = reader.GetDecimal(7);

                artList.Add(aux);

            }

            connection.Close();

            return artList;
        }

        public List<Articulo> BuscarMarcaCategoria(Marca m, Categoria c)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            List<Articulo> artList = new List<Articulo>();

            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT A.Id,A.Codigo,A.Nombre,ISNULL(A.Descripcion,''),ISNULL(M.Descripcion,'') AS Marca,ISNULL(C.Descripcion,'') AS Categoria,ISNULL(A.ImagenUrl,''),A.Precio FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id = A.IdMarca LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria WHERE IdMarca = @marca AND IdCategoria = @categoria;";
            command.Parameters.AddWithValue("@marca", m.Id);
            command.Parameters.AddWithValue("@categoria", c.Id);

            command.Connection = connection;

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Articulo aux = new Articulo();
                aux.Id = (int)reader["Id"];
                aux.CodArticulo = reader.GetString(1);
                aux.Nombre = reader.GetString(2);
                aux.Descripcion = reader.GetString(3);
                aux.UrlImagen = reader.GetString(6);

                aux.Marca = new Marca();
                aux.Marca.Nombre = reader.GetString(4);
                aux.Categoria = new Categoria();
                aux.Categoria.Nombre = reader.GetString(5);
                aux.UrlImagen = reader.GetString(6);
                aux.Precio = reader.GetDecimal(7);

                artList.Add(aux);
            }

            connection.Close();

            return artList;
        }

    }
}
