using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LogicaDeNegocio.Interfaces;
using Dominio;

namespace Interfaz
{
    public partial class VisualizarEventos : UserControl
    {
        private ILogicaProductor _logicaProductor;
        private ILogicaAsistente _logicaAsistente;

        public VisualizarEventos(ILogicaProductor logicaProductor, ILogicaAsistente logicaAsistente, bool prueba = false)
        {
            InitializeComponent();
            _logicaProductor = logicaProductor;
            _logicaAsistente = logicaAsistente;

            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn.HeaderText = "Imagen";
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();

            foreach (Evento i in _logicaAsistente.VisualizarEventos())
            {
                dataGridView1.Rows.Add(i.Nombre, i.Descripcion, i.Categoria, i.Formato, i.Direccion, Bitmap.FromFile(i.Imagen));
            }

            cbCategoriaFiltrar.Items.Add("Sin filtro");

            foreach (KeyValuePair<Categoria, int> cantidadCategoria in logicaAsistente.CantidadCategoria())
            {
                cbCategoriaFiltrar.Items.Add(cantidadCategoria.Key.ToString() + " : " + cantidadCategoria.Value.ToString());
            }

        }

        private void BtnComprarEventoClick(object sender, EventArgs e)
        {
            try
            {
                var nombreEventoSeleccionado = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                Evento evento = _logicaProductor.ObtenerEvento(nombreEventoSeleccionado);
                this.Controls.Clear();
                UserControl aplicarCupon = new AplicarCupon(evento, _logicaAsistente, _logicaProductor);
                this.Controls.Add(aplicarCupon);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CambioSeleccionCategoria(object sender, EventArgs e)
        {
            ReiniciarEventosFiltrados();
        }

        private void ReiniciarEventosFiltrados()
        {
            dataGridView1.Rows.Clear();

            List<Evento> eventosBuscar = _logicaAsistente.VisualizarEventos();
            eventosBuscar = _logicaAsistente.FiltrarEventosEntreFechas(dtInicio.Value, dtFin.Value, eventosBuscar);

            if (txtNombreEvento.Text != "")
            {
                eventosBuscar = _logicaAsistente.FiltrarEventosPorNombre(txtNombreEvento.Text, eventosBuscar);
            }

            foreach (var i in eventosBuscar)
            {
                var categoriaFiltrar = (string)cbCategoriaFiltrar.SelectedItem;
                if (categoriaFiltrar != "Sin filtro" && categoriaFiltrar != null)
                {
                    categoriaFiltrar = categoriaFiltrar.Split(' ')[0];
                    if (i.Categoria.ToString() == categoriaFiltrar)
                    {
                        dataGridView1.Rows.Add(i.Nombre, i.Descripcion, i.Categoria, i.Formato, i.Direccion, Bitmap.FromFile(i.Imagen));
                    }
                }
                else
                {
                    dataGridView1.Rows.Add(i.Nombre, i.Descripcion, i.Categoria, i.Formato, i.Direccion, Bitmap.FromFile(i.Imagen));
                }
            }
        }

        private void CambioSeleccionNombre(object sender, EventArgs e)
        {
            ReiniciarEventosFiltrados();
        }

        private void CambioSeleccionFechaInicio(object sender, EventArgs e)
        {
            ReiniciarEventosFiltrados();
        }

        private void CambioSeleccionFechaFin(object sender, EventArgs e)
        {
            ReiniciarEventosFiltrados();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
