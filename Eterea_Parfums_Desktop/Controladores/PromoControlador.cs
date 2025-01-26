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


        //POST

        public static bool crearPromocion(Promocion promo)
        {
            //Dar de alta una promoción en la base de datos

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

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception e)
            {
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


        // GET ALL
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
                    list.Add(new Promocion(r.GetInt32(0), r.GetString(1), r.GetDateTime(2), r.GetDateTime(3), r.GetInt32(4), r.GetInt32(5)));

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


        //GET ONE BY ID

        public static Promocion obtenerPorId(int id)
        {
            Promocion promo= new Promocion();

            


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

        //EDIT ó PUT
       /* public static bool editarPromo(Promocion promo)
        {
            string query = @"
                UPDATE dbo.promocion
                SET 
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

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
        }


           /* // ID de la promoción que se está editando
            //int idPromo = id_editar;

            // Obtener la clave del descuento seleccionada (clave del diccionario)
            var seleccionTipoPromo = (KeyValuePair<int, string>)combo_tipo_promo_edit.SelectedItem;
            int descuentoClave = seleccionTipoPromo.Key; // La clave que se debe guardar en la base de datos

            // Obtener el valor de "Activo" (1 si está activo, 0 si no)
            int activo = combo_activo_promo_edit.SelectedIndex == 0 ? 1 : 0; // 0 = No activo, 1 = Activo


            // Confirmar con el usuario
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas editar esta promoción?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            // Conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(DB_Controller.connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // 1. Borrar registros de perfumes_en_promo para la promoción actual
                    string deleteQuery = "DELETE FROM dbo.perfumes_en_promo WHERE promocion_id = @id_editar";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection, transaction))
                    {
                        deleteCmd.Parameters.AddWithValue("@id_editar", id_editar);
                        deleteCmd.ExecuteNonQuery();
                    }

                    // 2. Actualizar los datos de la promoción en dbo.promocion
                    string updateQuery = @"
                UPDATE dbo.promocion
                SET nombre = @nombre,
                    fecha_inicio = @fechaInicio,
                    fecha_fin = @fechaFin,
                    descuento = @descuento,
                    activo = @activo
                WHERE id = @id_editar";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@nombre", txt_nomb_promo_edit.Text);
                        updateCmd.Parameters.AddWithValue("@fechaInicio", dateTime_inicio_promo_edit.Value);
                        updateCmd.Parameters.AddWithValue("@fechaFin", dateTime_fin_promo_edit.Value);
                        updateCmd.Parameters.AddWithValue("@descuento", descuentoClave);
                        updateCmd.Parameters.AddWithValue("@activo", activo); // 1 para activo, 0 para no activo
                        updateCmd.Parameters.AddWithValue("@id_editar", id_editar);
                        updateCmd.ExecuteNonQuery();
                    }

                    // 3. Insertar los perfumes de dataGrid_perfumes_agregados_a_promo_edit en dbo.perfumes_en_promo
                    string insertQuery = @"
                INSERT INTO dbo.perfumes_en_promo (perfume_id, promocion_id)
                VALUES (@perfumeId, @promoId)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection, transaction))
                    {
                        foreach (DataGridViewRow row in dataGrid_perfumes_agregados_a_promo_edit.Rows)
                        {
                            if (!row.IsNewRow) // Ignorar filas vacías
                            {
                                int perfumeId = Convert.ToInt32(row.Cells[5].Value); // Suponiendo que la columna "Id" contiene el perfume_id
                                insertCmd.Parameters.Clear();
                                insertCmd.Parameters.AddWithValue("@perfumeId", perfumeId);
                                insertCmd.Parameters.AddWithValue("@promoId", id_editar);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Confirmar la transacción
                    transaction.Commit();
                    MessageBox.Show("Promoción editada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaction.Rollback();
                    MessageBox.Show($"Error al editar la promoción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiarFormulario(); // Limpiar los controles después de crear la promoción
        }*/

        public static bool eliminarPromo(int id)
        {
            

            //Borrar definitivamente una promo de la base de datos
            string query = "DELETE FROM dbo.promocion WHERE id = @id";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
           

            try
            {
                DB_Controller.connection.Open();
                // Eliminar relaciones de perfumes en la promoción
                eliminarRelacionesPerfumes(id);
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;

            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
        }

        private static void eliminarRelacionesPerfumes(int idPromo)
        {
            string queryEliminarRelaciones = "DELETE FROM dbo.perfumes_en_promo WHERE promocion_id = @idPromo";
            using (SqlCommand cmd = new SqlCommand(queryEliminarRelaciones, DB_Controller.connection))
            {
                cmd.Parameters.AddWithValue("@idPromo", idPromo);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
