using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class GeneroControlador
    {

        // GET ALL
        public static List<Genero> getAll()
        {
            List<Genero> list = new List<Genero>();
            string query = "select * from eterea.Genero;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new Genero(r.GetInt32(0), r.GetString(1)));

                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return list;

        }


        //GET ONE ByName
        public static Genero getByGenero(string gen)
        {
            Genero genero = new Genero();
            string query = "select * from eterea.Genero where " +
                "genero = @genero;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@genero", gen);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    genero = new Genero(r.GetInt32(0), r.GetString(1));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return genero;
        }

        //GET ONE ById
        public static Genero getById(int id)
        {
            Genero genero = new Genero();
            string query = "select * from eterea.Genero where " +
                "id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    genero = new Genero(r.GetInt32(0), r.GetString(1));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return genero;
        }

    }
}