using System;
using System.Drawing;
using System.Windows.Forms;
using LogicaDeNegocio;
using LogicaDeNegocio.Interfaces;
using Dominio;

namespace Interfaz
{
    public partial class VisualizarEventosBorrador : UserControl
    {
        private ILogicaProductor _logicaProductor;

        public VisualizarEventosBorrador(ILogicaProductor logicaProductor)
        {
            InitializeComponent();
            _logicaProductor = logicaProductor;

            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn.HeaderText = "Imagen";
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            PoblarTablas();
        }

        private void BtnPublicarEventoClick(object sender, EventArgs e)
        {
            try
            {
                var nombreEventoSeleccionado = (string)dgvEventosBorrador.SelectedRows[0].Cells[0].Value;
                foreach (Evento evento in _logicaProductor.VisualizarEventosBorrador())
                {
                    if (evento.Nombre == nombreEventoSeleccionado)
                    {
                        _logicaProductor.PublicarEvento(evento);
                        PoblarTablas();
                        break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe de seleccionar un evento");
            }
        }

        private void BtnModificarEventoClick(object sender, EventArgs e)
        {
            try
            {
                var nombreEventoSeleccionado = (string)dgvEventosBorrador.SelectedRows[0].Cells[0].Value;
                foreach (Evento evento in _logicaProductor.VisualizarEventosBorrador())
                {
                    if (evento.Nombre == nombreEventoSeleccionado)
                    {
                        this.Controls.Clear();
                        UserControl modificarEventoBorrador = new ModificarEventoBorrador(evento, _logicaProductor);
                        this.Controls.Add(modificarEventoBorrador);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe de seleccionar un evento");
            }
        }

        private void PoblarTablas()
        {
            dgvEventosBorrador.Rows.Clear();
            foreach (Evento i in _logicaProductor.VisualizarEventosBorrador())
            {
                dgvEventosBorrador.Rows.Add(i.Nombre, i.Descripcion, i.Categoria, i.Formato, i.Direccion, Bitmap.FromFile(i.Imagen));
            }
        }
    }
}