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


            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";


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
