using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    internal class LibreriaLogica
    {
        private LibreriaBd libreriaQuery = new LibreriaBd();

        public void InsertarLibro(string titulo, string autor, int cantidadDisponible)
        {

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) || cantidadDisponible <= 0)
            {
                throw new Exception("El título, el autor y la cantidad disponible deben ser válidos. Asegúrese de que no estén vacíos y que la cantidad sea mayor que cero.");
            }
            libreriaQuery.InsertarLibro(titulo, autor, cantidadDisponible);
        }
        public DataSet ObtenerLibros()
        {
            return libreriaQuery.ObtenerLibros();
        }

        public void ActualizarCantidad(int id, int cantidadDisponible)
        {
            if (cantidadDisponible < 0)
            {
                throw new Exception("La cantidad disponible no puede ser negativa.");
            }
            libreriaQuery.ActualizarCantidad(id, cantidadDisponible);
        }
        public void EliminarLibro(int id)
        {
            // Validación de entrada
            if (id <= 0)
            {
                throw new Exception("El ID del libro debe ser mayor que cero.");
            }
            libreriaQuery.EliminarLibro(id);
        }
    }
}


