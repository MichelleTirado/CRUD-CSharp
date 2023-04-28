using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Attributes;
using Domain.Crud;
using Guna.UI2.WinForms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //asegura que el tamaño máximo de la ventana no exceda el área de trabajo disponible en la pantalla actual.
        }

        //Variables
        CArtista artista = new CArtista();
        AttributesArtista attributesArtista = new AttributesArtista();

        CAlbum album = new CAlbum();
        AttributesAlbum attributesAlbum = new AttributesAlbum();

        CCancion cancion = new CCancion();
        AttributesCancion attributesCancion = new AttributesCancion();

        string view = "";
        Boolean artistaUpdate = false;
        Boolean albumUpdate = false;
        Boolean cancionUpdate = false;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void getDataArtista()
        {
            CArtista cArtista = new CArtista();
            DgvDatos.DataSource = cArtista.MostrarArtista();
        }

        private void getDataAlbumes()
        {
            CAlbum cAlbum = new CAlbum();
            DgvDatos.DataSource = cAlbum.MostrarAlbumes();
        }

        private void getDataCanciones()
        {
            CCancion cCacnion = new CCancion();
            DgvDatos.DataSource = cCacnion.MostrarCanciones();
        }

        private string[] getPaises()
        {
            string[] paises = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            .Select(x => new RegionInfo(x.LCID).EnglishName)
            .Distinct()
            .OrderBy(x => x)
            .ToArray();

            return paises;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_actualizarArtista.Enabled = false;
            btn_actualizarAlbum.Enabled = false;
            btn_actualizarCancion.Enabled = false;
            btn_eliminarArtista.Enabled = false;
            btn_elminarAlbum.Enabled = false;
            btn_eliminarCancion.Enabled = false;

            comboPais.Items.AddRange(getPaises());
            comboPais.SelectedIndex = -1;
            getNombreArtista();
            comboArtista.Items.Clear();
            comboArtista.Items.AddRange(getNombreArtista().ToArray(typeof(string)) as string[]);
            comboAlbum.Items.Clear();
            comboAlbum.Items.AddRange(getNombreAlbum().ToArray(typeof(string)) as string[]);
        }

        private void ClearTextBoxsArtista()
        {
            Id_Artista.Text = "";
            txtArtista.Text = "";
            txtGenero.Text = "";
            comboPais.SelectedIndex = -1;
        }

        private void ClearTextBoxsAlbum()
        {
            Id_Album.Text = "";
            txtAlbum.Text = "";
            txt_anoLanzamiento.Text = "";
            comboArtista.SelectedIndex = -1;
        }

        private void ClearTextBoxsCancion()
        {
            Id_Cancion.Text = "";
            txtCancion.Text = "";
            txtDuracion.Text = "";
            comboAlbum.SelectedIndex = -1;
        }

        private void btn_verArtista_Click(object sender, EventArgs e)
        {
            getDataArtista();
            view = "Artista";
        }

        private void btn_verAlbumes_Click(object sender, EventArgs e)
        {
            getDataAlbumes();
            view = "Album";
        }

        private void btn_verCanciones_Click(object sender, EventArgs e)
        {
            getDataCanciones();
            view = "Cancion";
        }

        private void btn_crearArtista_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArtista.Text == "" || txtGenero.Text == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos correctamente", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    attributesArtista.Nombre = txtArtista.Text;
                    attributesArtista.Genero_Musical = txtGenero.Text;
                    attributesArtista.Pais_Origen = comboPais.Text;
                    artista.Insertar(attributesArtista);
                    ClearTextBoxsArtista();
                    getDataArtista();
                    comboArtista.Items.Clear();
                    comboArtista.Items.AddRange(getNombreArtista().ToArray(typeof(string)) as string[]);

                    MessageBox.Show("Se guardo correctamente", "ARTISTA INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_crearAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAlbum.Text == "" || txt_anoLanzamiento.Text == "" || comboArtista.Text == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos correctamente", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    attributesAlbum.Nombre = txtAlbum.Text;
                    attributesAlbum.Ano_lanzamiento = int.Parse(txt_anoLanzamiento.Text);
                    attributesAlbum.Id_Artista = buscarKeyArtista(comboArtista.Text);
                    album.Insertar(attributesAlbum);
                    ClearTextBoxsAlbum();
                    getDataAlbumes();
                    comboAlbum.Items.Clear();
                    comboAlbum.Items.AddRange(getNombreAlbum().ToArray(typeof(string)) as string[]);

                    MessageBox.Show("Se guardo correctamente", "ALBUM INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int buscarKeyArtista(string nombre)
        {
            CArtista cArtista = new CArtista();

            int Id_Artista = cArtista.Mostrar().FirstOrDefault(x => x.Value == nombre).Key;
            return Id_Artista;
        }

        public int buscarKeyAlbum(string album)
        {
            CAlbum cAlbum = new CAlbum();

            int Id_Album = cAlbum.Mostrar().FirstOrDefault(x => x.Value == album).Key;
            return Id_Album;
        }

        private ArrayList getNombreArtista()
        {
            CArtista cArtista = new CArtista();

            ArrayList nombreArtistas = new ArrayList();

            foreach (KeyValuePair<int, string> item in cArtista.Mostrar())
            {
                nombreArtistas.Add(item.Value);
            }
            return nombreArtistas;
        }

        private ArrayList getNombreAlbum()
        {
            CAlbum cAlbum = new CAlbum();

            ArrayList nombresAlbum = new ArrayList();

            foreach (KeyValuePair<int, string> item in cAlbum.Mostrar())
            {
                nombresAlbum.Add(item.Value);
            }
            return nombresAlbum;
        }

        private void comboArtista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getNombreArtista();
        }

        private void DgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = DgvDatos.Rows[rowIndex];

                if (view == "Artista")
                {
                    btn_actualizarArtista.Enabled = true;
                    btn_eliminarArtista.Enabled = true;
                    btn_crearArtista.Enabled = false;
                    Id_Artista.Text = selectedRow.Cells["Id_Artista"].Value.ToString();
                    txtArtista.Text = selectedRow.Cells["Artista"].Value.ToString();
                    txtGenero.Text = selectedRow.Cells["Genero Musical"].Value.ToString();

                    int index = comboPais.FindStringExact(selectedRow.Cells["Pais de Origen"].Value.ToString());
                    comboPais.SelectedIndex = index;
                }
                else if (view == "Album")
                {
                    btn_actualizarAlbum.Enabled = true;
                    btn_elminarAlbum.Enabled = true;
                    btn_crearAlbum.Enabled = false;
                    Id_Album.Text = selectedRow.Cells["Id_Album"].Value.ToString();
                    txtAlbum.Text = selectedRow.Cells["Albúm"].Value.ToString();
                    txt_anoLanzamiento.Text = selectedRow.Cells["Año de Lanzamiento"].Value.ToString();

                    int index = comboArtista.FindStringExact(selectedRow.Cells["Artista / Agrupación"].Value.ToString());
                    comboArtista.SelectedIndex = index;

                }
                else if (view == "Cancion")
                {
                    btn_actualizarCancion.Enabled = true;
                    btn_eliminarCancion.Enabled = true;
                    btn_crearCancion.Enabled = false;
                    Id_Cancion.Text = selectedRow.Cells["Id_Cancion"].Value.ToString();
                    txtCancion.Text = selectedRow.Cells["Canción"].Value.ToString();
                    txtDuracion.Text = selectedRow.Cells["Duración"].Value.ToString();

                    int index = comboAlbum.FindStringExact(selectedRow.Cells["Albúm"].Value.ToString());
                    comboAlbum.SelectedIndex = index;
                }

            }
        }
        private void comboPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_crearCancion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCancion.Text == "" || txtDuracion.Text == "" || comboAlbum.Text == "")
                {
                    MessageBox.Show("Por favor, llene todos los campos correctamente", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    attributesCancion.Nombre = txtCancion.Text;
                    attributesCancion.Duracion = txtDuracion.Text;
                    attributesCancion.Id_Album = buscarKeyAlbum(comboAlbum.Text);
                    cancion.Insertar(attributesCancion);
                    ClearTextBoxsCancion();
                    getDataCanciones();

                    MessageBox.Show("Se guardo correctamente", "CANCION INSERTADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminarArtista_Click(object sender, EventArgs e)
        {

            attributesArtista.Id_Artista = int.Parse(Id_Artista.Text);
            artista.Eliminar(attributesArtista);
            ClearTextBoxsArtista();
            getDataArtista();

            comboArtista.Items.Clear();
            comboArtista.Items.AddRange(getNombreArtista().ToArray(typeof(string)) as string[]);

            btn_actualizarArtista.Enabled = false;
            btn_eliminarArtista.Enabled = false;
            btn_crearArtista.Enabled = true;

            MessageBox.Show("Se eliminó correctamente", "ARTISTA ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_elminarAlbum_Click(object sender, EventArgs e)
        {
            attributesAlbum.Id_Album = int.Parse(Id_Album.Text);
            album.Eliminar(attributesAlbum);
            ClearTextBoxsAlbum();
            getDataAlbumes();

            comboAlbum.Items.Clear();
            comboAlbum.Items.AddRange(getNombreAlbum().ToArray(typeof(string)) as string[]);

            btn_actualizarAlbum.Enabled = false;
            btn_elminarAlbum.Enabled = false;
            btn_crearAlbum.Enabled = true;

            MessageBox.Show("Se eliminó correctamente", "ALBUM ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_eliminarCancion_Click(object sender, EventArgs e)
        {
            attributesCancion.Id_Cancion = int.Parse(Id_Cancion.Text);
            cancion.Eliminar(attributesCancion);
            ClearTextBoxsCancion();
            getDataCanciones();

            btn_actualizarCancion.Enabled = false;
            btn_eliminarCancion.Enabled = false;
            btn_crearCancion.Enabled = true;

            MessageBox.Show("Se eliminó correctamente", "CANCION ELIMINADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_actualizarArtista_Click(object sender, EventArgs e)
        {
            attributesArtista.Id_Artista = int.Parse(Id_Artista.Text);
            attributesArtista.Nombre = txtArtista.Text;
            attributesArtista.Genero_Musical = txtGenero.Text;
            attributesArtista.Pais_Origen = comboPais.Text;

            artista.Modificar(attributesArtista);
            ClearTextBoxsArtista();
            getDataArtista();

            comboArtista.Items.Clear();
            comboArtista.Items.AddRange(getNombreArtista().ToArray(typeof(string)) as string[]);
            btn_actualizarArtista.Enabled = false;
            btn_eliminarArtista.Enabled = false;
            btn_crearArtista.Enabled = true;

            MessageBox.Show("Se actualizó correctamente", "ARTISTA MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_actualizarAlbum_Click(object sender, EventArgs e)
        {
            attributesAlbum.Id_Album = int.Parse(Id_Album.Text);
            attributesAlbum.Nombre = txtAlbum.Text;
            attributesAlbum.Ano_lanzamiento = int.Parse(txt_anoLanzamiento.Text);
            attributesAlbum.Id_Artista = buscarKeyArtista(comboArtista.Text);

            album.Modificar(attributesAlbum);
            ClearTextBoxsAlbum();
            getDataAlbumes();

            comboAlbum.Items.Clear();
            comboAlbum.Items.AddRange(getNombreAlbum().ToArray(typeof(string)) as string[]);

            btn_actualizarAlbum.Enabled = false;
            btn_elminarAlbum.Enabled = false;
            btn_crearAlbum.Enabled = true;

            MessageBox.Show("Se actualizó correctamente", "ALBUM MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_actualizarCancion_Click(object sender, EventArgs e)
        {
            attributesCancion.Id_Cancion = int.Parse(Id_Cancion.Text);
            attributesCancion.Nombre = txtCancion.Text;
            attributesCancion.Duracion = txtDuracion.Text;
            attributesCancion.Id_Album = buscarKeyAlbum(comboAlbum.Text);

            cancion.Modificar(attributesCancion);
            ClearTextBoxsCancion();
            getDataCanciones();

            btn_actualizarCancion.Enabled = false;
            btn_eliminarCancion.Enabled = false;
            btn_crearCancion.Enabled = true;

            MessageBox.Show("Se actualizó correctamente", "CANCION MODIFICADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
