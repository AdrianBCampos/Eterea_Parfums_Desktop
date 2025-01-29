using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class NotaConTipoDeNotaControlador
    {

        public static NotaConTipoDeNota getByID(int id)
        {
            NotaConTipoDeNota nota_con_tipo_de_nota = new NotaConTipoDeNota();
            string query = "SELECT * FROM dbo.nota_con_tipo_de_nota WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Nota nota = new Nota(r.GetInt32(1), null);
                    TipoDeNota tipo_de_nota = new TipoDeNota(r.GetInt32(2), null);
                    nota_con_tipo_de_nota.id = r.GetInt32(0);
                    nota_con_tipo_de_nota.nota = nota;
                    nota_con_tipo_de_nota.tipoDeNota = tipo_de_nota;
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return nota_con_tipo_de_nota;
        }


        public static void create(NotaConTipoDeNota nota_con_tipo_de_nota)
        {
            string query = "INSERT INTO dbo.nota_con_tipo_de_nota VALUES (@id, @nota_id, @tipo_de_nota_id)";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", nota_con_tipo_de_nota.id);
            cmd.Parameters.AddWithValue("@nota_id", nota_con_tipo_de_nota.nota.id);
            cmd.Parameters.AddWithValue("@tipo_de_nota_id", nota_con_tipo_de_nota.tipoDeNota.id);
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
        }

        internal static NotaConTipoDeNota getByNotaAndTipoDeNota(NotaConTipoDeNota notaConTipoDeNota)
        {

            NotaConTipoDeNota nota_con_tipo_de_nota = new NotaConTipoDeNota();
            string query = "SELECT * FROM dbo.nota_con_tipo_de_nota WHERE nota_id = @nota_id AND tipo_de_nota_id = @tipo_de_nota_id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nota_id", notaConTipoDeNota.nota.id);
            cmd.Parameters.AddWithValue("@tipo_de_nota_id", notaConTipoDeNota.tipoDeNota.id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    nota_con_tipo_de_nota.id = r.GetInt32(0);
                    nota_con_tipo_de_nota.nota = notaConTipoDeNota.nota;
                    nota_con_tipo_de_nota.tipoDeNota = notaConTipoDeNota.tipoDeNota;
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return nota_con_tipo_de_nota;
        }


        public static int getByMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from dbo.nota_con_tipo_de_nota;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    MaxId = r.GetInt32(0);
                }
                r.Close();
                DB_Controller.connection.Close();
                return MaxId;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
        }


        public static bool delete(int id)
        {
            bool result = false;
            string query = "DELETE FROM dbo.nota_con_tipo_de_nota WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                result = true;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return result;
        }
    }
}
