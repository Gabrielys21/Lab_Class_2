using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Lab.Data.DataAccess
{
    internal class ConsolasDB
    {
        string connectionString = "server=localhost;Database=lab_class;Uid=root;Pwd=pasword";
        MySqlConnection conection;

        //constructor
        public ConsolasDB()
        {
            conection = new MySqlConnection(connectionString);
        }

        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        //insertar
        public void Insertar(ConsolasDB consola)
        {
            try
            {
                string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@NombreConsola, @Compania, @AnioLanzamiento, @Generacion)";
                MySqlCommand cmd = new MySqlCommand(query, conection);
                cmd.Parameters.AddWithValue("@NombreConsola", consola.NombreConsola);
                cmd.Parameters.AddWithValue("@Compania", consola.Compania);
                cmd.Parameters.AddWithValue("@AnioLanzamiento", consola.AnioLanzamiento);
                cmd.Parameters.AddWithValue("@Generacion", consola.Generacion);
                conection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                conection.Close();
            }
        }
        //leer por id
        public DataRow LeerId(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM catalogo_consolas WHERE id_consola = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conection);
                cmd.Parameters.AddWithValue("@ID", id);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el registro: " + ex.Message);
            }
            finally
            {
                conection.Close();
            }
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public List<ConsolasDB> ObtenerConsolas()
        {
            List<ConsolasDB> consolas = new List<ConsolasDB>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM catalogo_consolas";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ConsolasDB consola = new ConsolasDB
                        {
                            IdConsola = reader.GetInt32("id_consola"),
                            NombreConsola = reader.GetString("nombre_consola"),
                            Compania = reader.GetString("compania"),
                            AnioLanzamiento = reader.GetInt32("anio_lanzamiento"),
                            Generacion = reader.GetByte("generacion")
                        };

                        consolas.Add(consola);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return consolas;
        }

    }
}
