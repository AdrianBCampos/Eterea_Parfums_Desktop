using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class PromoControlador
    {


        //POST - CREAR UNA PROMOCION

        public static bool crearPromocion(Promocion promo)
        {
            // Dar de alta una promoción en la base de datos
            string query = "insert into dbo.promocion values" +
                           "(@id, " +
                           "@nombre, " +
                           "@fecha_inicio, " +
                           "@fecha_fin, " +
                           "@descuento, " +
                           "@activo);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre", promo.nombre);
            cmd.Parameters.AddWithValue("@fecha_inicio", promo.fecha_inicio);
            cmd.Parameters.AddWithValue("@fecha_fin", promo.fecha_fin);
            cmd.Parameters.AddWithValue("@descuento", promo.descuento);
            cmd.Parameters.AddWithValue("@activo", promo.activo);

            SqlTransaction transaction = null; // Declarar la transacción

            try
            {
                DB_Controller.connection.Open();

                // Iniciar la transacción
                transaction = DB_Controller.connection.BeginTransaction();

                // Asignar la transacción al comando
                cmd.Transaction = transaction;

                // Ejecutar el comando para insertar la promoción
                cmd.ExecuteNonQuery();

                // Si la inserción fue exitosa, confirmar la transacción
                transaction.Commit();

                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                // Si ocurre un error, revertir la transacción
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                DB_Controller.connection.Close(); // Cerrar la conexión también en caso de error
                throw new Exception("Hay un error en la query: " + e.Message);
               
            }
         
        }








        // OBTENER EL MAX ID

        public static int obtenerMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from dbo.promocion;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }
                reader.Close();
                DB_Controller.connection.Close();
                return MaxId;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
        }


        // GET ALL -  OBTENER TODAS LAS PROMOCIONES DE LA BD
        public static List<Promocion> obtenerTodos()
        {
            List<Promocion> list = new List<Promocion>();
            string query = "select * from dbo.promocion;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new Promocion(
                        r.GetInt32(0),
                        r.GetString(1),
                        r.GetDateTime(2),
                        r.GetDateTime(3),
                        r.GetInt32(4),
                        r.GetInt32(5)));

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





        //GET ONE BY ID - OBTENER UNA PROMOCION POR SU ID

        public static Promocion obtenerPorId(int id)
        {
            Promocion promo = new Promocion();

            string query = "select * from dbo.promocion where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {

                    promo = new Promocion(r.GetInt32(0), r.GetString(1), r.GetDateTime(2), r.GetDateTime(3),
                        r.GetInt32(4), r.GetInt32(5));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return promo;

        }





        //EDIT ó PUT  -  EDITAR UNA PROMO
        public static bool editarPromo(Promocion promo)
        {
            string query = @"
                 UPDATE dbo.promocion
                 SET id = @id_editar,
                     nombre = @nombre,
                     fecha_inicio = @fechaInicio,
                     fecha_fin = @fechaFin,
                     descuento = @descuento,
                     activo = @activo
                 WHERE id = @id_editar"
            ;

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_editar", promo.id);
            cmd.Parameters.AddWithValue("@nombre", promo.nombre);
            cmd.Parameters.AddWithValue("@fechaInicio", promo.fecha_inicio);
            cmd.Parameters.AddWithValue("@fechaFin", promo.fecha_fin);
            cmd.Parameters.AddWithValue("@descuento", promo.descuento);
            cmd.Parameters.AddWithValue("@activo", promo.activo);

            SqlTransaction transaction = null; // Declarar la transacción

            try
            {
                DB_Controller.connection.Open();

                // Iniciar la transacción
                transaction = DB_Controller.connection.BeginTransaction();

                // Asignar la transacción al comando
                cmd.Transaction = transaction;

                // Ejecutar el comando de actualización
                cmd.ExecuteNonQuery();

                // Llamar a eliminar registros, pasándole la transacción
                eliminarRegistrosPromoPerfumes(promo.id, transaction);

                // Confirmar la transacción si todo fue bien
                transaction.Commit();

                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                // Revertir la transacción en caso de error
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                DB_Controller.connection.Close(); // Cerrar la conexión también en caso de error
                throw new Exception("Hay un error en la query: " + e.Message);
               
            }
        }
          


        //ELIMINAR TODOS LOS REGISTROS DE LA RELACION DE LA PROMOCION CON LOS PERFUMES QUE INCLUYE

        public static void eliminarRegistrosPromoPerfumes(int id_promo, SqlTransaction transaction)
        {
            string query = "DELETE FROM dbo.perfumes_en_promo WHERE promocion_id = @id_editar";


            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_editar", id_promo);

            cmd.Transaction = transaction;

            cmd.ExecuteNonQuery();

        }




        //METODO PARA GUARDAR EN LA BD LA RELACION DE LA PROMOCION CON LOS PERFUMES QUE ESTA INCLUYE

        public static bool agregarRegistrosPromoPerfumes(int id_promo, List<int> perfumeIds)
        {
            string query = @"
        INSERT INTO dbo.perfumes_en_promo (perfume_id, promocion_id)
        VALUES (@perfumeId, @promoId)";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();

                foreach (int perfumeId in perfumeIds)
                {
                    cmd.Parameters.Clear(); // Limpia los parámetros para cada iteración
                    cmd.Parameters.AddWithValue("@perfumeId", perfumeId);
                    cmd.Parameters.AddWithValue("@promoId", id_promo);
                    cmd.ExecuteNonQuery();
                }

                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                if (DB_Controller.connection.State == System.Data.ConnectionState.Open)
                {
                    DB_Controller.connection.Close();
                }
                throw new Exception("Error al agregar registros de perfumes a la promoción: " + e.Message);
            }
        }




        //METODO PARA ELIMINAR UNA PROMOCION

        public static bool eliminarPromo(int id_promo)
        {
            

            //Borrar definitivamente una promo de la base de datos
            string query = "DELETE FROM dbo.promocion WHERE id = @id";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id_promo);

            SqlTransaction transaction = null; // Declarar la transacción

            try
            {
                // Abrir la conexión
                DB_Controller.connection.Open();

                // Iniciar la transacción
                transaction = DB_Controller.connection.BeginTransaction();

                // Asociar la transacción al comando
                cmd.Transaction = transaction;

                // Eliminar relaciones de perfumes en la promoción
                eliminarRegistrosPromoPerfumes(id_promo, transaction);

                // Ejecutar la eliminación de la promoción
                cmd.ExecuteNonQuery();

                // Confirmar la transacción
                transaction.Commit();

                return true;
            }
            catch (Exception e)
            {
                // Revertir la transacción en caso de error
                transaction?.Rollback();
                throw new Exception("Error al eliminar la promoción: " + e.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (DB_Controller.connection.State == System.Data.ConnectionState.Open)
                    DB_Controller.connection.Close();
            }
        }



        //Método para verificar que el nombre de la promo no se repite
        public static bool ExisteNombrePromo(string nombrePromo, int? idPromo = null)
        {
            string query = "SELECT COUNT(*) FROM promocion WHERE nombre = @nombrePromo";

            if (idPromo != null)
            {
                query += " AND id <> @idPromo"; // Evita conflicto al editar
            }

            using (SqlConnection conn = new SqlConnection(DB_Controller.connection.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombrePromo", nombrePromo);
                    if (idPromo != null)
                    {
                        cmd.Parameters.AddWithValue("@idPromo", idPromo);
                    }

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Retorna true si ya existe
                }
            }
        }



    }
}
