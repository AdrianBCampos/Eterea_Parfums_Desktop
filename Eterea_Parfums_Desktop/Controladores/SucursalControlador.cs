using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class SucursalControlador
    {
        // GET ALL

        public static List<Sucursal> getAll()
        {
            List<Sucursal> list = new List<Sucursal>();
            string query = "select * from dbo.sucursal;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Pais pais = PaisControlador.getById(r.GetInt32(2));
                    Provincia provincia = ProvinciaControlador.getById(r.GetInt32(3));
                    Localidad localidad = LocalidadControlador.getById(r.GetInt32(4));
                    Calle calle = CalleControlador.getById(r.GetInt32(6));


                    list.Add(new Sucursal(r.GetInt32(0), r.GetString(1), pais, provincia,
                        localidad, r.GetInt32(5), calle, r.GetInt32(7), r.GetInt32(8)));

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
        public static Sucursal getByName(string nombre)
        {
            Sucursal sucursal = new Sucursal();
            string query = "select * from dbo.sucursal where " +
                "nombre = @nombre;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Pais pais = PaisControlador.getById(r.GetInt32(2));
                    Provincia provincia = ProvinciaControlador.getById(r.GetInt32(3));
                    Localidad localidad = LocalidadControlador.getById(r.GetInt32(4));
                    Calle calle = CalleControlador.getById(r.GetInt32(6));


                    sucursal = new Sucursal(r.GetInt32(0), r.GetString(1), pais, provincia,
                       localidad, r.GetInt32(5), calle, r.GetInt32(7), r.GetInt32(8));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return sucursal;
        }

        //GET ONE ById
        public static Sucursal getById(int id)
        {
            Sucursal sucursal = new Sucursal();
            string query = "select * from dbo.sucursal where " +
                "id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Pais pais = PaisControlador.getById(r.GetInt32(2));
                    Provincia provincia = ProvinciaControlador.getById(r.GetInt32(3));
                    Localidad localidad = LocalidadControlador.getById(r.GetInt32(4));
                    Calle calle = CalleControlador.getById(r.GetInt32(6));


                    sucursal = new Sucursal(r.GetInt32(0), r.GetString(1), pais, provincia,
                       localidad, r.GetInt32(5), calle, r.GetInt32(7), r.GetInt32(8));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return sucursal;
        }


    }
}
