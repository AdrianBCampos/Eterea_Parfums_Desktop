using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class PerfumeControlador
    {
        public static List<Perfume> getAll()
        {
            List<Perfume> lista_perfumes = new List<Perfume>();

            Marca marca = null;
            TipoDePerfume tipo_de_perfume = null;
            Genero genero = null;
            Pais pais = null;
            string query = null;

            try
            {
                query = "select * from eterea.perfume;";
                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {

                    marca = new Marca(r.GetInt32(2), null);
                    tipo_de_perfume = new TipoDePerfume(r.GetInt32(4), null);
                    genero = new Genero(r.GetInt32(5), null);
                    pais = new Pais(r.GetInt32(7), null);


                    if (r.GetInt32(13) == 1)
                    {

                        //string cod1 = r.GetInt64(1).ToString();

                        lista_perfumes.Add(new Perfume(r.GetInt32(0), r.GetString(1), marca, r.GetString(3),
                        tipo_de_perfume, genero, r.GetInt32(6), pais,
                        r.GetInt32(8), r.GetInt32(9), r.GetString(10), r.GetInt32(11), r.GetDouble(12),
                        r.GetInt32(13), r.GetString(14), r.GetString(15)));
                        //Trace.WriteLine("Perfume encontrado, nombre: " + cod1);
                    }


                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return lista_perfumes;

        }


        public static bool create(Perfume perfume)
        {


            string query = "insert into eterea.perfume values " +
                "(@id, " +
                "@codigo, " +
                "@marca, " +
                "@nombre, " +
                "@tipo_de_perfume, " +
                "@genero, " +
                "@presentacion_ml, " +
                "@pais, " +
                "@spray, " +
                "@recargable, " +
                "@descripcion, " +
                "@anio_de_lanzamiento, " +
                "@precio_en_pesos, " +
                "@activo, " +
                "@imagen1, " +
                "@imagen2);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            cmd.Parameters.AddWithValue("@id", GetByMaxId() + 1);
            cmd.Parameters.AddWithValue("@codigo", perfume.codigo);
            cmd.Parameters.AddWithValue("@marca", perfume.marca.id);
            cmd.Parameters.AddWithValue("@nombre", perfume.nombre);
            cmd.Parameters.AddWithValue("@tipo_de_perfume", perfume.tipo_de_perfume.id);
            cmd.Parameters.AddWithValue("@genero", perfume.genero.id);
            cmd.Parameters.AddWithValue("@presentacion_ml", perfume.presentacion_ml);
            cmd.Parameters.AddWithValue("@pais", perfume.pais.id);
            cmd.Parameters.AddWithValue("@spray", perfume.spray);
            cmd.Parameters.AddWithValue("@recargable", perfume.recargable);
            cmd.Parameters.AddWithValue("@descripcion", perfume.descripcion);
            cmd.Parameters.AddWithValue("@anio_de_lanzamiento", perfume.anio_de_lanzamiento);
            cmd.Parameters.AddWithValue("@precio_en_pesos", perfume.precio_en_pesos);
            cmd.Parameters.AddWithValue("@activo", perfume.activo);
            cmd.Parameters.AddWithValue("@imagen1", perfume.imagen1);
            cmd.Parameters.AddWithValue("@imagen2", perfume.imagen2);


            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                
                //throw new Exception("Hay un error en la query: " + e.Message);
                Trace.WriteLine(e.Message);
                return false;
            }
            finally
            {
                cmd.Parameters.Clear();
                DB_Controller.connection.Close();
        }
        }


        public static Perfume getByID(int id)
        {
            Marca marca = null;
            TipoDePerfume tipo_de_perfume = null;
            Genero genero = null;
            Pais pais = null;
            Perfume perfume = new Perfume();
            string query = "select * from eterea.perfume where id = @id;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    marca = new Marca(r.GetInt32(2), null);
                    tipo_de_perfume = new TipoDePerfume(r.GetInt32(4), null);
                    genero = new Genero(r.GetInt32(5), null);
                    pais = new Pais(r.GetInt32(7), null);
                    perfume = new Perfume(r.GetInt32(0), r.GetInt64(1).ToString(), marca, r.GetString(3),
                        tipo_de_perfume, genero, r.GetInt32(6), pais,
                        r.GetInt32(8), r.GetInt32(9), r.GetString(10), r.GetInt32(11), r.GetDouble(12),
                        r.GetInt32(13), r.GetString(14), r.GetString(15));
                }
                r.Close();
               
            }
            catch (Exception e)
            {
               
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            finally
            {
                DB_Controller.connection.Close();
            }
            return perfume;
        }

        public static int GetByMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from eterea.perfume;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    MaxId = r.GetInt32(0);
                    Console.WriteLine("MaxId: " + MaxId);
                }
               
                r.Close();


            }
            catch (Exception e)
            {
               Trace.WriteLine("Error al consultar la DB: " + e.Message);
                    }
            finally
            {

                DB_Controller.connection.Close();
            }
     
            return MaxId;
        }
    }
}
