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
            string query = "select * from dbo.perfume;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {

                    Marca marca = new Marca(r.GetInt32(2), null);
                    TipoDePerfume tipo_de_perfume = new TipoDePerfume(r.GetInt32(4), null);
                    Genero genero = new Genero(r.GetInt32(5), null);
                    Pais pais = new Pais(r.GetInt32(7), null);


                    if (r.GetInt32(13) == 1)
                    {
                        lista_perfumes.Add(new Perfume(r.GetInt32(0), r.GetString(1), marca, r.GetString(3),
                        tipo_de_perfume, genero, r.GetInt32(6), pais,
                        r.GetInt32(8), r.GetInt32(9), r.GetString(10), r.GetInt32(11), r.GetDouble(12),
                        r.GetInt32(13), r.GetString(14), r.GetString(15)));
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


            string query = "insert into dbo.perfume values " +
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

            Console.WriteLine("genero_id" + perfume.genero.id);
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
            Perfume perfume = new Perfume();
            string query = "select * from dbo.perfume where id = @id;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Marca marca = new Marca(r.GetInt32(2), null);
                    TipoDePerfume tipo_de_perfume = new TipoDePerfume(r.GetInt32(4), null);
                    Genero genero = new Genero(r.GetInt32(5), null);
                    Pais pais = new Pais(r.GetInt32(7), null);
                    perfume.id = r.GetInt32(0);
                    perfume.codigo = r.GetString(1);
                    perfume.marca = marca;
                    perfume.nombre = r.GetString(3);
                    perfume.tipo_de_perfume = tipo_de_perfume;
                    perfume.genero = genero;
                    perfume.presentacion_ml = r.GetInt32(6);
                    perfume.pais = pais;
                    perfume.spray = r.GetInt32(8);
                    perfume.recargable = r.GetInt32(9);
                    perfume.descripcion = r.GetString(10);
                    perfume.anio_de_lanzamiento = r.GetInt32(11);
                    perfume.precio_en_pesos = r.GetDouble(12);
                    perfume.activo = r.GetInt32(13);
                    perfume.imagen1 = r.GetString(14);
                    perfume.imagen2 = r.GetString(15);
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
            string query = "select max(id) from dbo.perfume;";
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

        public static bool update(Perfume perfume)
        {
            bool result = false;
            string query = "update dbo.perfume set " +
                "codigo = @codigo, " +
                "marca_id = @marca, " +
                "nombre = @nombre, " +
                "tipo_de_perfume_id = @tipo_de_perfume, " +
                "genero_id = @genero, " +
                "presentacion_ml = @presentacion_ml, " +
                "pais_id = @pais, " +
                "spray = @spray, " +
                "recargable = @recargable, " +
                "descripcion = @descripcion, " +
                "anio_de_lanzamiento = @anio_de_lanzamiento, " +
                "precio_en_pesos = @precio_en_pesos, " +
                "activo = @activo, " +
                "imagen1 = @imagen1, " +
                "imagen2 = @imagen2 " +
                "where id = @id;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", perfume.id);
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
                result = true;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                DB_Controller.connection.Close();
            }

            return result;
        }

        public static bool delete(int id)
        {
            bool result = false;
            string query = "update dbo.perfume set activo = 0 where id = @id;";
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

        public static List<Perfume> filtrarPorNombre(string nombre)
        {
            List<Perfume> list = new List<Perfume>();

            Marca marca = new Marca();
            TipoDePerfume tipo = new TipoDePerfume();
            Genero genero = new Genero();
            Pais pais = new Pais();


            if (nombre == null)
            {
                list = PerfumeControlador.getAll();
            }
            else
            {

                string query = "select * from dbo.Perfume where nombre like @nombre;";


                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");


                try
                {
                    DB_Controller.connection.Open();
                    SqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {

                        marca.id = r.GetInt32(2);
                        tipo.id = r.GetInt32(4);
                        genero.id = r.GetInt32(5);
                        pais.id = r.GetInt32(7);

                        Marca marcaOb = new Marca(marca.id, "");
                        TipoDePerfume tipo_de_perfumeOb = new TipoDePerfume(tipo.id, "");
                        Genero generoOb = new Genero(genero.id, "");
                        Pais paisOb = new Pais(pais.id, "");


                        list.Add(new Perfume(r.GetInt32(0), r.GetString(1), marcaOb, r.GetString(3),
                            tipo_de_perfumeOb, generoOb, r.GetInt32(6), paisOb,
                            r.GetInt32(8), r.GetInt32(9), r.GetString(10), r.GetInt32(11), r.GetDouble(12),
                            r.GetInt32(13), r.GetString(14), r.GetString(15)));


                    }
                    r.Close();
                    DB_Controller.connection.Close();


                }
                catch (Exception e)
                {
                    throw new Exception("Hay un error en la query: " + e.Message);
                }


            }
            return list;
        }
    }
}
