using System;
using System.Drawing;
using System.Windows.Forms;
using LogicaDeNegocio;
using LogicaDeNegocio.Interfaces;
using Dominio;

namespace Interfaz
{
    public partial class EliminarEventos : UserControl
    {
        private ILogicaProductor _logicaProductor;
        public EliminarEventos(ILogicaProductor logicaProductor)
        {
            _logicaProductor = logicaProductor;
            InitializeComponent();
            foreach (var i in _logicaProductor.EventosCreados())
            {
                dataEventos.Rows.Add(i.Nombre, i.Descripcion, i.Categoria, i.Formato, Bitmap.FromFile(i.Imagen), "Comprar");
            }
        }

        private void BtnEliminarEventoClick(object sender, EventArgs e)
        {
            try
            {
                string nombreEventoSeleccionado = (string)dataEventos.SelectedRows[0].Cells[0].Value;
                _logicaProductor.EliminarEvento(nombreEventoSeleccionado);
                dataEventos.Rows.Clear();
                foreach (var i in _logicaProductor.EventosCreados())
                {
                    dataEventos.Rows.Add(i.Nombre, i.Descripcion, i.Categoria, i.Formato, Bitmap.FromFile(i.Imagen));
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe de seleccionar un evento");
            }
        }
    }
}
