namespace Laboratorio6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLibreria = new System.Windows.Forms.DataGridView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbTituloLibro = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAutor = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbCantidadActualizada = new System.Windows.Forms.TextBox();
            this.lbInformativoActualizar = new System.Windows.Forms.Label();
            this.lbInformativo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibreria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibreria
            // 
            this.dgvLibreria.BackgroundColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibreria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibreria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibreria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.autor,
            this.cantidadDisponible});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibreria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibreria.Location = new System.Drawing.Point(279, 112);
            this.dgvLibreria.Name = "dgvLibreria";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibreria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLibreria.Size = new System.Drawing.Size(493, 314);
            this.dgvLibreria.TabIndex = 0;
            this.dgvLibreria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Brown;
            this.lbTitulo.Location = new System.Drawing.Point(287, 28);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(161, 36);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Libreria One";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.Brown;
            this.lbCantidad.Location = new System.Drawing.Point(8, 282);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(103, 28);
            this.lbCantidad.TabIndex = 2;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.BackColor = System.Drawing.Color.Transparent;
            this.lbAutor.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.ForeColor = System.Drawing.Color.Brown;
            this.lbAutor.Location = new System.Drawing.Point(9, 224);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(68, 28);
            this.lbAutor.TabIndex = 3;
            this.lbAutor.Text = "Autor";
            // 
            // lbTituloLibro
            // 
            this.lbTituloLibro.AutoSize = true;
            this.lbTituloLibro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloLibro.ForeColor = System.Drawing.Color.Brown;
            this.lbTituloLibro.Location = new System.Drawing.Point(11, 167);
            this.lbTituloLibro.Name = "lbTituloLibro";
            this.lbTituloLibro.Size = new System.Drawing.Size(73, 28);
            this.lbTituloLibro.TabIndex = 4;
            this.lbTituloLibro.Text = "Titulo";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(102, 169);
            this.tbTitulo.MaxLength = 30;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(151, 29);
            this.tbTitulo.TabIndex = 5;
            this.tbTitulo.TextChanged += new System.EventHandler(this.tbTitulo_TextChanged);
            this.tbTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTitulo_KeyPress);
            this.tbTitulo.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitulo_Validating);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(116, 282);
            this.tbCantidad.MaxLength = 3;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(68, 29);
            this.tbCantidad.TabIndex = 6;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // tbAutor
            // 
            this.tbAutor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutor.Location = new System.Drawing.Point(102, 226);
            this.tbAutor.MaxLength = 30;
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(100, 29);
            this.tbAutor.TabIndex = 7;
            this.tbAutor.TextChanged += new System.EventHandler(this.tbAutor_TextChanged);
            // 
            // btInsertar
            // 
            this.btInsertar.BackColor = System.Drawing.Color.LightGreen;
            this.btInsertar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertar.Location = new System.Drawing.Point(12, 334);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(96, 42);
            this.btInsertar.TabIndex = 8;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = false;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btEliminar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(126, 334);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(96, 42);
            this.btEliminar.TabIndex = 9;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btActualizar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.Location = new System.Drawing.Point(293, 440);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(115, 42);
            this.btActualizar.TabIndex = 10;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.titulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.titulo.Width = 180;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            this.autor.Width = 140;
            // 
            // cantidadDisponible
            // 
            this.cantidadDisponible.FillWeight = 50F;
            this.cantidadDisponible.HeaderText = "Cantidad";
            this.cantidadDisponible.Name = "cantidadDisponible";
            this.cantidadDisponible.ReadOnly = true;
            // 
            // epTitulo
            // 
            this.epTitulo.ContainerControl = this;
            // 
            // epAutor
            // 
            this.epAutor.ContainerControl = this;
            // 
            // epCantidad
            // 
            this.epCantidad.ContainerControl = this;
            // 
            // tbCantidadActualizada
            // 
            this.tbCantidadActualizada.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadActualizada.Location = new System.Drawing.Point(420, 448);
            this.tbCantidadActualizada.MaxLength = 3;
            this.tbCantidadActualizada.Name = "tbCantidadActualizada";
            this.tbCantidadActualizada.Size = new System.Drawing.Size(81, 29);
            this.tbCantidadActualizada.TabIndex = 11;
            // 
            // lbInformativoActualizar
            // 
            this.lbInformativoActualizar.AutoSize = true;
            this.lbInformativoActualizar.BackColor = System.Drawing.Color.Transparent;
            this.lbInformativoActualizar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformativoActualizar.ForeColor = System.Drawing.Color.Brown;
            this.lbInformativoActualizar.Location = new System.Drawing.Point(196, 490);
            this.lbInformativoActualizar.Name = "lbInformativoActualizar";
            this.lbInformativoActualizar.Size = new System.Drawing.Size(444, 26);
            this.lbInformativoActualizar.TabIndex = 12;
            this.lbInformativoActualizar.Text = "Seleccione en la tabla el libro a actualizar la cantidad.";
            // 
            // lbInformativo2
            // 
            this.lbInformativo2.AutoSize = true;
            this.lbInformativo2.BackColor = System.Drawing.Color.Transparent;
            this.lbInformativo2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformativo2.ForeColor = System.Drawing.Color.Brown;
            this.lbInformativo2.Location = new System.Drawing.Point(507, 457);
            this.lbInformativo2.Name = "lbInformativo2";
            this.lbInformativo2.Size = new System.Drawing.Size(133, 20);
            this.lbInformativo2.TabIndex = 13;
            this.lbInformativo2.Text = "Escriba la cantidad\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(795, 525);
            this.Controls.Add(this.lbInformativo2);
            this.Controls.Add(this.lbInformativoActualizar);
            this.Controls.Add(this.tbCantidadActualizada);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lbTituloLibro);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.dgvLibreria);
            this.Name = "Form1";
            this.Text = "Libreria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibreria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibreria;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbTituloLibro;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDisponible;
        private System.Windows.Forms.ErrorProvider epTitulo;
        private System.Windows.Forms.ErrorProvider epAutor;
        private System.Windows.Forms.ErrorProvider epCantidad;
        private System.Windows.Forms.Label lbInformativoActualizar;
        private System.Windows.Forms.TextBox tbCantidadActualizada;
        private System.Windows.Forms.Label lbInformativo2;
    }
}

