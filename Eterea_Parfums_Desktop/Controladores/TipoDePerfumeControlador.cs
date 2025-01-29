using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class TipoDePerfumeControlador
    {
        public static List<TipoDePerfume> getAll()
        {

            List<TipoDePerfume> lista_tipos_de_perfumes;

            try
            {
                lista_tipos_de_perfumes = new List<TipoDePerfume>();
                string query = "select * from dbo.tipo_de_perfume;";
                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    lista_tipos_de_perfumes.Add(new TipoDePerfume(r.GetInt32(0), r.GetString(1)));

                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return lista_tipos_de_perfumes;

        }

        public static TipoDePerfume getByName(string tipo)
        {
            TipoDePerfume tipo_de_perfume = new TipoDePerfume();
            string query = "select * from dbo.tipo_de_perfume where " +
                "nombre = @tipo;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@tipo", tipo);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    tipo_de_perfume.id = r.GetInt32(0);
                    tipo_de_perfume.tipo_de_perfume = r.GetString(1);
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return tipo_de_perfume;
        }

        public static TipoDePerfume getById(int id)
        {
            TipoDePerfume tipo_de_perfume = new TipoDePerfume();
            string query = "select * from dbo.tipo_de_perfume where " +
                "id = @id;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tipo_de_perfume.id = r.GetInt32(0);
                    tipo_de_perfume.tipo_de_perfume = r.GetString(1);
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);
            }
            return tipo_de_perfume;
        }
    }

}
