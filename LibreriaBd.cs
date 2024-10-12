using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio6
{
    internal class LibreriaBd
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Libreria;Integrated Security=True";

        // Método para obtener la conexión
        private SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open(); // Abrir la conexión
            return con; // Retornar la conexión abierta
        }
        //Para mandar mensaje de conexion exitosa
        public void ProbarConexion()
        {
            try
            {
                using (SqlConnection con = ObtenerConexion())
                {
                    MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void InsertarLibro(string titulo, string autor, int cantidadDisponible)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                string query = "INSERT INTO LIBROS (titulo, autor, cantidadDisponible) VALUES (@titulo, @autor, @cantidadDisponible)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.AddWithValue("@cantidadDisponible", cantidadDisponible);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataSet ObtenerLibros()
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection con = ObtenerConexion())
                {
                    string query = "SELECT * FROM LIBROS";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(ds, "Libros");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los libros: " + ex.Message);
            }

            return ds; 
        }

        public void ActualizarCantidad(int id, int cantidadDisponible)
        {
            try
            {
                using (SqlConnection con = ObtenerConexion())
                {
                    string query = "UPDATE LIBROS SET cantidadDisponible = @cantidadDisponible WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cantidadDisponible", cantidadDisponible);
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró el libro con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la cantidad: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado: " + ex.Message);
            }
        }

        public void EliminarLibro(int id)
        {
            try
            {
                using (SqlConnection con = ObtenerConexion())
                {
                    string query = "DELETE FROM LIBROS WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró el libro con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el libro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado: " + ex.Message);
            }
        }
    }
}
