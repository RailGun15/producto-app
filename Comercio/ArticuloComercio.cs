using System;
using System.Collections.Generic;
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

            connection.ConnectionString = "data source = DESKTOP-0E8A9MS\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT A.Id,A.Codigo,A.Nombre,ISNULL(A.Descripcion,''),ISNULL(M.Descripcion,'') AS Marca,ISNULL(C.Descripcion,'') AS Categoria,ISNULL(A.ImagenUrl,''),A.Precio FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id = A.IdMarca LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria;";
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

        public static void Cargar(Articulo art)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = "data source = DESKTOP-0E8A9MS\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
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
    }
}
