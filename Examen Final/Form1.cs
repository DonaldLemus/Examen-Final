using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tablaGrid()
        {
            //hacemos una instancia de PeliculasEntitiesContexxt
            PeliculasEntities tabla = new PeliculasEntities(); //Esto vendría siendo el select
            dataGridViewTablas.DataSource = tabla.tb_peliculas.ToList();//Lo Covertimos a lista
        }
        
        private void llenar()
        {
            try
            {
                textBoxId.Text = dataGridViewTablas.SelectedRows[0].Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewTablas.SelectedRows[0].Cells[1].Value.ToString();
                comboBoxGenero.Text = dataGridViewTablas.SelectedRows[0].Cells[2].Value.ToString();
                textBoxFecha.Text = dataGridViewTablas.SelectedRows[0].Cells[3].Value.ToString();
                textBoxDuracion.Text = dataGridViewTablas.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                string msg = $"Para cargar los datos presione la primera columna de la tabla";
                MessageBox.Show(msg);
            }
        }

        private void agregar()
        {
            try
            {
                string nombre = textBoxNombre.Text;
                string genero = comboBoxGenero.Text;
                DateTime fecha = Convert.ToDateTime(textBoxFecha.Text);
                decimal duracion = Convert.ToDecimal(textBoxDuracion.Text);
                //Guarda en memoria como un arreglo de bytes
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBoxPeliculas.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                using (PeliculasEntities peliculas = new PeliculasEntities())
                {
                    //Creamos un objeto tipo tb_peliculas
                    tb_peliculas A = new tb_peliculas()
                    {
                        //Como lo estamos realizando dentro de las llaves no es necesario poner A.Nombre
                        Nombre = nombre,
                        Genero = genero,
                        Fecha_Publicacion = fecha,
                        Duracion_Pelicula = duracion,
                        Imagen_Pelicula = ms.GetBuffer()
                    };
                    peliculas.tb_peliculas.Add(A);//Agregamos el registro, pero solo a nuestro proyecto
                    peliculas.SaveChanges();//Con esto hacemos que se guarden los cambios en la base de datos
                    tablaGrid();
                }
            }
            catch (Exception)
            {
                string msg = "No se pueden ingresar valores vacios, asegurese de llenar todos los campos";
                MessageBox.Show(msg);
            }

        }

        private void modificar()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string nombre = textBoxNombre.Text;
            string genero = comboBoxGenero.Text;
            DateTime fecha = Convert.ToDateTime(textBoxFecha.Text);
            decimal duracion = Convert.ToDecimal(textBoxDuracion.Text);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBoxPeliculas.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            using (PeliculasEntities modificar = new PeliculasEntities())
            {
                tb_peliculas a = modificar.tb_peliculas.FirstOrDefault(x => x.idPelicula == id);//Realizamos un Query
                //x se convierte en un objeto tipo tb_peliculas y puede tener acceso a los miembros de la clase
                
                //Aquí si ponemos a.Nombre porque no lo hicimos dentro de las llaves
                a.Nombre = nombre;
                a.Genero = genero;
                a.Fecha_Publicacion = fecha;
                a.Duracion_Pelicula = duracion;
                a.Imagen_Pelicula = ms.GetBuffer();
                modificar.SaveChanges();//Guardamos los cambios para que se modifique
                tablaGrid();
            }
        }

        private void eliminar()
        {
            using (PeliculasEntities modificar = new PeliculasEntities())
            {
                try
                {
                    int id = Convert.ToInt32(textBoxId.Text);
                    tb_peliculas a = modificar.tb_peliculas.FirstOrDefault(x => x.idPelicula == id);
                    modificar.tb_peliculas.Remove(a);//Con Remove podemos eliminar el registro a traves del id
                    modificar.SaveChanges();//Guardamos los cambios en la base de datos
                    tablaGrid();
                }
                catch (Exception)
                {
                    string msg = "Los campos están vacíos, no hay nada que eliminar";
                    MessageBox.Show(msg);
                }
            }
        }

        private void HorasVistas()
        {
            using (PeliculasEntities sumar = new PeliculasEntities())
            {
                decimal b = sumar.tb_peliculas.Sum(x => x.Duracion_Pelicula);
                textBoxSumaHoras.Text = b.ToString();
            }
        }

        private void limpiar(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
                pictureBoxPeliculas.Image = null;
            }
        }
        private void Imagen()
        {
            try
            {
                //muestra un cuadro de dialogo que pide al usuario que abra un archivo
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;//contiene una cadena que contiene el nombre del archivo
                    pictureBoxPeliculas.Image = Image.FromFile(imagen);//crea una imagen a partir del archivo especificado
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
        private void dataGridViewTablas_Click(object sender, EventArgs e)
        {
            llenar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tablaGrid();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            Imagen();
        }

        private void buttonSumaHoras_Click(object sender, EventArgs e)
        {
            HorasVistas();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar(this);
        }
    }
}
