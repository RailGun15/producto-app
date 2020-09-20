using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Comercio
{
    public class MarcaComercio
    {
        public List<Marca> Listar()
        {
            List<Marca> marcalst = new List<Marca>();

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

<<<<<<< HEAD
            connection.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
=======
            connection.ConnectionString = "data source = .; initial catalog=CATALOGO_DB; integrated security=sspi";
>>>>>>> ef1b124bf53f7edb6064ac71483370f21f4cb02c
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM MARCAS;";
            command.Connection = connection;

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Marca aux = new Marca();
                aux.Id = (int)reader["Id"];
                aux.Nombre = (string)reader["Descripcion"];

                marcalst.Add(aux);
            }

            connection.Close();
            return marcalst;



        }
    }
}
