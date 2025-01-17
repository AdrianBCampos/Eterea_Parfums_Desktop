using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class Productos : Form
    {
        public List<Marca> marcas;
        public List<TipoDePerfume> tiposDePerfume;
        public List<Genero> generos;
        public List<Pais> paises;
        private Image File;
        private Image File2;
        private string nombre_foto_uno;
        private string nombre_foto_dos;
        public Productos()
        {
            InitializeComponent();
            LblErrorSetVisibleFalse();
            CargarMarcas();
            CargarTiposDePerfume();
            CargarGeneros();
            CargarPaises();
            CargarOpciones(combo_spray);
            CargarOpciones(combo_recargable);
            CargarOpciones(combo_activo);
        }

        private void LblErrorSetVisibleFalse()
        {
            lbl_error_codigo.Visible = false;
            lbl_error_nombre.Visible = false;
            lbl_error_marca.Visible = false;
            lbl_error_tipo.Visible = false;
            lbl_error_genero.Visible = false;
            lbl_error_presentacion.Visible = false;
            lbl_error_pais.Visible = false;
            lbl_error_spray.Visible = false;
            lbl_error_recargable.Visible = false;
            lbl_error_descripcion.Visible = false;
            lbl_error_anio.Visible = false;
            lbl_error_precio.Visible = false;
            lbl_error_activo.Visible = false;
            lbl_error_img1.Visible = false;
            lbl_error_img2.Visible = false;

        }

        private void CargarMarcas()
        {
            var marcas = MarcaControlador.getAll();
            combo_marca.Items.Clear();
            foreach (Marca marca in marcas)
            {
                combo_marca.Items.Add(marca.nombre.ToString());
            }
        }

        private void CargarTiposDePerfume()
        {
            var tiposDePerfume = TipoDePerfumeControlador.getAll();
            combo_tipo_de_perfume.Items.Clear();
            foreach (TipoDePerfume tipo in tiposDePerfume)
            {
                combo_tipo_de_perfume.Items.Add(tipo.tipo_de_perfume.ToString());
            }
        }

        private void CargarGeneros()
        {
            var generos = GeneroControlador.getAll();
            combo_genero.Items.Clear();
            foreach (Genero genero in generos)
            {
                combo_genero.Items.Add(genero.genero.ToString());
            }
        }

        private void CargarPaises()
        {
            var paises = PaisControlador.getAll();
            combo_pais.Items.Clear();
            foreach (Pais pais in paises)
            {
                combo_pais.Items.Add(pais.nombre.ToString());
            }
        }

        private void CargarOpciones(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Si");
            combo.Items.Add("No");
        }


        private void btn_siguiente_Click(object sender, EventArgs e)
        {

            //Validar datos del perfume
            bool validacionDatosPerfume = ValidarPerfume();

            if (validacionDatosPerfume)
            {

                saveImagenResources(out nombre_foto_uno, File);
                saveImagenResources(out nombre_foto_dos, File2);
                Perfume perfume = crear();
                AromaNota aromaNota = new AromaNota(perfume);
                aromaNota.Show();
                this.Hide();
            }
           
        }

        private void saveImagenResources(out string nombreFoto, Image File)
        {
            try
            {

                int numero_aleatorio = numeroAleatorio();
                Console.WriteLine(numero_aleatorio);
                nombreFoto = txt_nombre.Text + numero_aleatorio + "-envase.jpg";
                File.Save(Program.Ruta_Base + nombreFoto, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                //NO SE PUDO GUARDAR LA FOTO
                throw new Exception(ex.Message);
            }
        }

        private int numeroAleatorio()
        {
            Random rnd = new Random();
            int numero = rnd.Next(1000, 9999);
            return numero;
        }


        private Perfume crear()
        {
            // ACA ANTES DE EJECUTAR CUALQUIER COSA, TIENEN QUE HACERSE LAS VALIDACIONES...
            int spray = 0;
            if (combo_spray.SelectedItem.ToString() == "Si")
            {
                spray = 1;
            }

            int recargable = 0;
            if (combo_spray.SelectedItem.ToString() == "Si")
            {
                recargable = 1;
            }

            int activo = 1;
            if (combo_activo.SelectedItem.ToString() == "No")
            {
                activo = 0;
            }


            Marca marca = MarcaControlador.getByName(combo_marca.SelectedItem.ToString());
            TipoDePerfume tipo_de_perfume = TipoDePerfumeControlador.getByName(combo_tipo_de_perfume.SelectedItem.ToString());
            Genero genero = GeneroControlador.getByGenero(combo_genero.SelectedItem.ToString());
            Pais pais = PaisControlador.getByName(combo_pais.SelectedItem.ToString());
            int id_Perfume = PerfumeControlador.getByMaxId();
            Perfume perfume = new Perfume(id_Perfume + 1, txt_codigo.Text, marca, txt_nombre.Text, tipo_de_perfume,
                genero, int.Parse(txt_presentacion.Text), pais, spray, recargable, txt_descripcion.Text,
                int.Parse(txt_anio_de_lanzamiento.Text), Double.Parse(txt_precio.Text), activo, nombre_foto_uno, nombre_foto_dos);




            if (PerfumeControlador.create(perfume))
            {
                this.DialogResult = DialogResult.OK;
            }

            return perfume;

        }

        private bool EsCodigoBarraCODE128Valido(string codigo)
        {
            // Validar que no esté vacío
            if (string.IsNullOrEmpty(codigo))
            {
                return false;
            }

            // Validar longitud mínima (CODE128 puede variar según el contenido)
            if (codigo.Length < 1 || codigo.Length > 128) // Longitud típica entre 1 y 128
            {
                return false;
            }

            // Validar que solo contenga caracteres permitidos (ASCII 0-127)
            foreach (char c in codigo)
            {
                if (c < 32 || c > 126) // Incluye caracteres ASCII imprimibles
                {
                    return false;
                }
            }

            return true;
        }

        private bool ValidarPerfume()
        {
      
            string errorMsg = "";

            if (string.IsNullOrEmpty(txt_codigo.Text))
            {
                errorMsg += "Debes ingresar el código CODE128" + Environment.NewLine;
                lbl_error_codigo.Text = "Debes ingresar el código CODE128";
                lbl_error_codigo.Show();
            }
            else if (!EsCodigoBarraCODE128Valido(txt_codigo.Text))
            {
                errorMsg += "El código CODE128 es inválido. Verifique su formato." + Environment.NewLine;
                lbl_error_codigo.Text = "El código CODE128 es inválido. Verifique su formato.";
                lbl_error_codigo.Show();
            }

            if (combo_marca.SelectedItem == null || string.IsNullOrEmpty(combo_marca.Text))
            {
                errorMsg += "Debes seleccionar la marca del perfume" + Environment.NewLine;
                lbl_error_marca.Text = "Debes seleccionar la marca del perfume";
                lbl_error_marca.Show();
            }
            else
            {
                lbl_error_marca.Visible = false;
            }


            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                errorMsg += "Debes ingresar el nombre del perfume" + Environment.NewLine;
                lbl_error_nombre.Text = "Debes ingresar el nombre del perfume";
                lbl_error_nombre.Show();

            }
            else if (txt_nombre.Text.Length > 80)
            {
                errorMsg += "El nombre no puede exceder los 80 caracteres" + Environment.NewLine;
                lbl_error_nombre.Text = "El nombre no puede exceder los 80 caracteres";
                lbl_error_nombre.Show();
            }
            else
            {

                lbl_error_nombre.Visible = false;

            }

            if (combo_tipo_de_perfume.SelectedItem == null || string.IsNullOrEmpty(combo_tipo_de_perfume.Text))
            {
                errorMsg += "Debes seleccionar un tipo de perfume" + Environment.NewLine;
                lbl_error_tipo.Text = "Debes seleccionar un tipo de perfume";
                lbl_error_tipo.Show();
            }
            else
            {
                lbl_error_tipo.Visible = false;
            }

            if (combo_genero.SelectedItem == null || string.IsNullOrEmpty(combo_genero.Text))
            {
                errorMsg += "Debes seleccionar un género" + Environment.NewLine;
                lbl_error_genero.Text = "Debes seleccionar un género";
                lbl_error_genero.Show();
            }
            else
            {
                lbl_error_genero.Visible = false;
            }

            if (string.IsNullOrEmpty(txt_presentacion.Text))
            {
                errorMsg += "Debes ingresar los ml en numero" + Environment.NewLine;
                lbl_error_presentacion.Text = "Debes ingresar los ml en numero";
                lbl_error_presentacion.Show();

            }
            else
            {
                if (!int.TryParse(txt_presentacion.Text, out int result))

                {
                    errorMsg += "Debes ingresar un número entero. Sólo números" + Environment.NewLine;
                    lbl_error_presentacion.Text = "Debes ingresar un número entero. Sólo números";
                    lbl_error_presentacion.Show();
                }
                else
                {
                    lbl_error_presentacion.Visible = false;
                }
            }

            if (combo_pais.SelectedItem == null || string.IsNullOrEmpty(combo_pais.Text))
            {
                errorMsg += "Debes ingresar el nombre del perfume" + Environment.NewLine;
                lbl_error_pais.Text = "Debes ingresar el nombre del perfume";
                lbl_error_pais.Show();
            }
            else
            {
                lbl_error_pais.Visible = false;
            }

            if (combo_spray.SelectedItem == null || string.IsNullOrEmpty(combo_spray.Text))
            {
                errorMsg += "Debes indicar si viene en formato spray o no" + Environment.NewLine;
                lbl_error_spray.Text = "Debes indicar si viene en formato spray o no";
                lbl_error_spray.Show();
            }
            else
            {
                lbl_error_spray.Visible = false;
            }

            if (combo_recargable.SelectedItem == null || string.IsNullOrEmpty(combo_recargable.Text))
            {
                errorMsg += "Debes indicar si es o no recargable" + Environment.NewLine;
                lbl_error_recargable.Text = "Debes indicar si es o no recargable";
                lbl_error_recargable.Show();
            }
            else
            {
                lbl_error_recargable.Visible = false;
            }

            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                errorMsg += "Debes ingresar la descripción del perfume" + Environment.NewLine;
                lbl_error_descripcion.Text = "Debes ingresar la descripción del perfume";
                lbl_error_descripcion.Show();

            }
            else if (txt_descripcion.Text.Length > 1100)
            {
                errorMsg += "La descripción del perfume no puede exceder los 1100 caracteres" + Environment.NewLine;
                lbl_error_descripcion.Text = "La descripción del perfume no puede exceder los 1100 caracteres";
                lbl_error_descripcion.Show();
            }
            else
            {
                {
                    lbl_error_descripcion.Visible = false;
                }
            }

            if (string.IsNullOrEmpty(txt_anio_de_lanzamiento.Text))
            {
                errorMsg += "Debes ingresar el año de lanzamiento del perfume" + Environment.NewLine;
                lbl_error_anio.Text = "Debes ingresar el año de lanzamiento del perfume";
                lbl_error_anio.Show();

            }
            else
            {
                if (!int.TryParse(txt_anio_de_lanzamiento.Text, out int year) || year < 1900 || year > DateTime.Now.Year)
                {
                    errorMsg += "Debes ingresar un año válido" + Environment.NewLine;
                    lbl_error_anio.Text = "Debes ingresar un año válido";
                    lbl_error_anio.Show();
                }
                else
                {
                    lbl_error_anio.Visible = false;
                }
            }
            if (string.IsNullOrEmpty(txt_precio.Text))
            {
                errorMsg += "Debes ingresar un precio" + Environment.NewLine;
                lbl_error_precio.Text = "Debes ingresar un precio";
                lbl_error_precio.Show();

            }
            else
            {
                if (!double.TryParse(txt_precio.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double price) || price < 0)
                {
                    errorMsg += "Debes ingresar un precio válido" + Environment.NewLine;
                    lbl_error_precio.Text = "Debes ingresar un precio válido";
                    lbl_error_precio.Show();
                }
                else
                {
                    lbl_error_precio.Visible = false;
                }
            }

            if (combo_activo.SelectedItem == null || string.IsNullOrEmpty(combo_activo.Text))
            {
                errorMsg += "Debes indicar si el producto ingresa como activo o no" + Environment.NewLine;
                lbl_error_activo.Text = "Debes indicar si el producto ingresa como activo o no";
                lbl_error_activo.Show();
            }
            else
            {
                lbl_error_activo.Visible = false;
            }

            if (pictureBoxProducto1.Image == null)
            {
                errorMsg += "Debes cargar una Imagen" + Environment.NewLine;
                lbl_error_img1.Text = "Debes cargar una Imagen 1";
                lbl_error_img1.Show();

            }
            else
            {
                
                lbl_error_img1.Visible = false;
               
            }

            if (pictureBoxProducto2.Image == null)
            {
                errorMsg += "Debes cargar una Imagen" + Environment.NewLine;
                lbl_error_img2.Text = "Debes cargar una Imagen 2";
                lbl_error_img2.Show();

            }
            else
            {
               lbl_error_img2.Visible = false;
            }


            if (string.IsNullOrEmpty(errorMsg))
            {
                LblErrorSetVisibleFalse();
            }

            return string.IsNullOrEmpty(errorMsg);


        }

        private void btn_cargar_img1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG(*.JPG)|*.JPG|PNG(*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(ofd.FileName);
                pictureBoxProducto1.Image = File;

            }
        }

        private void btn_cargar_img2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG(*.JPG)|*.JPG|PNG(*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File2 = Image.FromFile(ofd.FileName);
                pictureBoxProducto2.Image = File2;

            }
        }
    }
}
