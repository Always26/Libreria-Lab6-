using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio6
{
    public partial class Form1 : Form
    {
        LibreriaLogica libreriaLogica = new LibreriaLogica();
        LibreriaBd libreriaQuery = new LibreriaBd();

        public Form1()
        {
            InitializeComponent();
            libreriaQuery.ProbarConexion();
            ActualizarVistaLibros();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            libreriaQuery.ProbarConexion();
            ActualizarVistaLibros();
        }

        //Metodos de la clase
        private void ActualizarVistaLibros()
        {
            try
            {
                DataSet libros = libreriaQuery.ObtenerLibros();

                if (libros.Tables.Count > 0 && libros.Tables[0].Rows.Count > 0)
                {
                    dgvLibreria.DataSource = libros.Tables[0];
                }
                else
                {
                    dgvLibreria.DataSource = null;
                    MessageBox.Show("No se encontraron libros en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los libros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        //Crud de la clase
        private void btInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbTitulo.Text) ||
                    string.IsNullOrWhiteSpace(tbAutor.Text) ||
                    string.IsNullOrWhiteSpace(tbCantidad.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                    return;
                }
                if (!int.TryParse(tbCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número entero mayor que cero.");
                    return;
                }

                libreriaLogica.InsertarLibro(tbTitulo.Text, tbAutor.Text, cantidad);
                tbTitulo.Text = "";
                tbAutor.Text = "";
                tbCantidad.Text = "";

                MessageBox.Show("Libro insertado correctamente.");
                ActualizarVistaLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvLibreria.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvLibreria.SelectedRows[0].Cells["id"].Value);

                    if (int.TryParse(tbCantidadActualizada.Text, out int nuevaCantidad) && nuevaCantidad >= 0)
                    {
                        libreriaLogica.ActualizarCantidad(id, nuevaCantidad);

                        ActualizarVistaLibros();

                        tbCantidadActualizada.Text = "";
                        MessageBox.Show("Cantidad de libros actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida (número entero mayor o igual a cero).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un libro para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cantidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay alguna fila seleccionada en el DataGridView
                if (dgvLibreria.SelectedRows.Count > 0)
                {
                    // Obtiene el ID del libro de la celda correspondiente
                    int id = Convert.ToInt32(dgvLibreria.SelectedRows[0].Cells["id"].Value);

                    // Llama al método de la lógica para eliminar el libro
                    libreriaLogica.EliminarLibro(id);

                    // Actualiza la vista del DataGridView después de la eliminación
                    ActualizarVistaLibros();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un libro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de que ocurra una excepción
                MessageBox.Show("Error al eliminar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Eventos de los Texbox de la clase

        //TITULO tbTitulo
        private void tbTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
        }

        private void tbTitulo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitulo.Text))
            {
                epTitulo.SetError(tbTitulo, "Debe ingresar un titulo");
                e.Cancel = true;
            }
            else
            {
                epTitulo.SetError(tbTitulo, string.Empty);
            }
        }
        private void tbAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
        }
        private void tbAutor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAutor.Text))
            {
                epAutor.SetError(tbAutor, "Debe ingresar un autor");
                e.Cancel = true;
            }
            else
            {
                epAutor.SetError(tbAutor, string.Empty);
            }
        }
        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void tbCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCantidad.Text))
            {
                epCantidad.SetError(tbCantidad, "Debe ingresar una cantidad");
                e.Cancel = true;
            }
            else
            {
                epCantidad.SetError(tbCantidad, string.Empty);
            }
        }

        private void tbAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void tbTitulo_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void tbCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbCantidad.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
        }
    }
}
