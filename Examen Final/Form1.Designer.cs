namespace Examen_Final
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelGnero = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSumaHoras = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregarImagen = new System.Windows.Forms.Button();
            this.buttonSumaHoras = new System.Windows.Forms.Button();
            this.dataGridViewTablas = new System.Windows.Forms.DataGridView();
            this.pictureBoxPeliculas = new System.Windows.Forms.PictureBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(39, 51);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // labelGnero
            // 
            this.labelGnero.AutoSize = true;
            this.labelGnero.Location = new System.Drawing.Point(350, 52);
            this.labelGnero.Name = "labelGnero";
            this.labelGnero.Size = new System.Drawing.Size(42, 13);
            this.labelGnero.TabIndex = 1;
            this.labelGnero.Text = "Genero";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(128, 51);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(536, 51);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "Fecha";
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Location = new System.Drawing.Point(281, 105);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(50, 13);
            this.labelDuracion.TabIndex = 4;
            this.labelDuracion.Text = "Duracion";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(62, 48);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(53, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Location = new System.Drawing.Point(348, 102);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuracion.TabIndex = 6;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(587, 48);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(64, 20);
            this.textBoxFecha.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(176, 48);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(155, 20);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxSumaHoras
            // 
            this.textBoxSumaHoras.Location = new System.Drawing.Point(274, 306);
            this.textBoxSumaHoras.Name = "textBoxSumaHoras";
            this.textBoxSumaHoras.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumaHoras.TabIndex = 10;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(131, 172);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(91, 58);
            this.buttonAgregar.TabIndex = 11;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(274, 172);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(91, 58);
            this.buttonModificar.TabIndex = 12;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(403, 172);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(91, 58);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAgregarImagen
            // 
            this.buttonAgregarImagen.Location = new System.Drawing.Point(522, 172);
            this.buttonAgregarImagen.Name = "buttonAgregarImagen";
            this.buttonAgregarImagen.Size = new System.Drawing.Size(91, 58);
            this.buttonAgregarImagen.TabIndex = 15;
            this.buttonAgregarImagen.Text = "Agregar Imagen";
            this.buttonAgregarImagen.UseVisualStyleBackColor = true;
            this.buttonAgregarImagen.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // buttonSumaHoras
            // 
            this.buttonSumaHoras.Location = new System.Drawing.Point(162, 286);
            this.buttonSumaHoras.Name = "buttonSumaHoras";
            this.buttonSumaHoras.Size = new System.Drawing.Size(91, 58);
            this.buttonSumaHoras.TabIndex = 16;
            this.buttonSumaHoras.Text = "Horas de Peliculas Vistas";
            this.buttonSumaHoras.UseVisualStyleBackColor = true;
            this.buttonSumaHoras.Click += new System.EventHandler(this.buttonSumaHoras_Click);
            // 
            // dataGridViewTablas
            // 
            this.dataGridViewTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewTablas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTablas.Location = new System.Drawing.Point(0, 385);
            this.dataGridViewTablas.MultiSelect = false;
            this.dataGridViewTablas.Name = "dataGridViewTablas";
            this.dataGridViewTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTablas.Size = new System.Drawing.Size(1011, 150);
            this.dataGridViewTablas.TabIndex = 17;
            this.dataGridViewTablas.Click += new System.EventHandler(this.dataGridViewTablas_Click);
            // 
            // pictureBoxPeliculas
            // 
            this.pictureBoxPeliculas.Location = new System.Drawing.Point(712, 48);
            this.pictureBoxPeliculas.Name = "pictureBoxPeliculas";
            this.pictureBoxPeliculas.Size = new System.Drawing.Size(266, 293);
            this.pictureBoxPeliculas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPeliculas.TabIndex = 18;
            this.pictureBoxPeliculas.TabStop = false;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(403, 286);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(91, 58);
            this.buttonLimpiar.TabIndex = 19;
            this.buttonLimpiar.Text = "Limpiar Formulario";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "",
            "Acción",
            "Aventuras",
            "Ciencia Ficción",
            "Comedia",
            "Documental",
            "Drama",
            "Fantasía",
            "Musical",
            "Suspenso",
            "Terror"});
            this.comboBoxGenero.Location = new System.Drawing.Point(411, 49);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(89, 21);
            this.comboBoxGenero.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 535);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.pictureBoxPeliculas);
            this.Controls.Add(this.dataGridViewTablas);
            this.Controls.Add(this.buttonSumaHoras);
            this.Controls.Add(this.buttonAgregarImagen);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxSumaHoras);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelGnero);
            this.Controls.Add(this.labelId);
            this.Name = "Form1";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelGnero;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxSumaHoras;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregarImagen;
        private System.Windows.Forms.Button buttonSumaHoras;
        private System.Windows.Forms.DataGridView dataGridViewTablas;
        private System.Windows.Forms.PictureBox pictureBoxPeliculas;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

