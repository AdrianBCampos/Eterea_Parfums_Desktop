using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using Eterea_Parfums_Desktop.DTOs;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.Controladores
{
    public class PerfumeEnPromoControlador
    {

        //POST

        public static bool guardarRelacionPromoPerfume(int idPerfume, int idPromo)
        {
            //Relacionar una promoción con uno o varios perfumes en la base de datos

            // Definir la consulta SQL para insertar la relación en la tabla Promo_Perfume
            string query = "INSERT INTO dbo.perfumes_en_promo (perfume_id, promocion_id) VALUES (@perfumeId, @promoId)";

            // Utilizar parámetros para evitar SQL Injection
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            cmd.Parameters.AddWithValue("@perfumeId", idPerfume);
            cmd.Parameters.AddWithValue("@promoId", idPromo);
            

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







        //obtener los perfumes de una promo

        public List<PerfumeDTO> CargarPerfumesPorIdPromocion(int idPromo)
        {
            string query = @"
                SELECT p.id, m.nombre AS marca, p.nombre, p.presentacion_ml, g.genero AS genero
                FROM dbo.perfumes_en_promo pep
                JOIN dbo.perfume p ON pep.perfume_id = p.id
                JOIN dbo.marca m ON p.marca_id = m.id
                JOIN dbo.genero g ON p.genero_id = g.id
                WHERE pep.promocion_id = @idPromo;";

            List<PerfumeDTO> perfumes = new List<PerfumeDTO>();


            using (SqlConnection connection = new SqlConnection(DB_Controller.connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idPromo", idPromo);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PerfumeDTO perfume = new PerfumeDTO
                                {
                                    id = reader.GetInt32(0),
                                    marca = reader.GetString(1),
                                    nombre = reader.GetString(2),
                                    mililitros = reader.GetInt32(3),
                                    genero = reader.GetString(4)
                                };
                                perfumes.Add(perfume);

                                // Mostrar en consola
                                Console.WriteLine($"ID: {perfume.id}, Marca: {perfume.marca}, Nombre: {perfume.nombre}, " +
                                                  $"Mililitros: {perfume.mililitros}, Género: {perfume.genero}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al cargar los perfumes de la promoción: {ex.Message}");
                        throw new Exception("Error al cargar los perfumes de la promoción.", ex);
                    }
                }
            }

            Console.WriteLine($"Total perfumes recuperados: {perfumes.Count}");
            return perfumes;
        }

        /* using (SqlCommand cmd = new SqlCommand(query, DB_Controller.connection))
         {
             cmd.Parameters.AddWithValue("@idPromo", idPromo);

             try
             {
                 DB_Controller.connection.Open();
                 using (SqlDataReader reader = cmd.ExecuteReader())
                 {
                     while (reader.Read())
                     {
                         PerfumeDTO perfume = new PerfumeDTO
                         {
                             id = reader.GetInt32(0),
                             marca = reader.GetString(1),
                             nombre = reader.GetString(2),
                             mililitros = reader.GetInt32(3),
                             genero = reader.GetString(4)
                         };
                         perfumes.Add(perfume);
                     }
                 }
             }
             catch (Exception ex)
             {
                 throw new Exception("Error al cargar los perfumes de la promoción.", ex);
             }
             finally
             {
                 DB_Controller.connection.Close();
             }
         }
         // Verifica que los datos se están recuperando correctamente
         MessageBox.Show($"Se recuperaron {perfumes.Count} perfumes.");

         return perfumes;
     }*/

        public static List<Promocion> getByIDPerfume(int idPerfume)
        {
            string query = @"
            SELECT p.id, p.nombre, p.fecha_inicio, p.fecha_fin, p.descuento, p.activo 
            FROM promocion p
            INNER JOIN perfumes_en_promo pep ON p.id = pep.promocion_id
            WHERE pep.perfume_id = @idPerfume";

            List<Promocion> listaPromociones = new List<Promocion>();

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@idPerfume", idPerfume);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    listaPromociones.Add(new Promocion(r.GetInt32(0), r.GetString(1), r.GetDateTime(2), r.GetDateTime(3), r.GetInt32(4), r.GetInt32(5)));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return listaPromociones;

        }

    }
}
