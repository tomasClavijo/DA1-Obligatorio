using System;
using System.Windows.Forms;
using LogicaDeNegocio.Interfaces;
using Dominio;
using System.Collections.Generic;

namespace Interfaz
{
    public partial class ModificarCupon : UserControl
    {
        private ILogicaProductor _logicaProductorAccesoDatos;
        private List<Cupon> _cupones;
        private List<string> _codigosCupones = new List<string>();

        public ModificarCupon(ILogicaProductor logicaProductor)
        {
            _logicaProductorAccesoDatos = logicaProductor;
            _cupones = _logicaProductorAccesoDatos.ObtenerCupones();

            foreach (Cupon cupon in _cupones)
            {
                _codigosCupones.Add(cupon.Codigo);
            }

            InitializeComponent();
            PoblarTabla(_cupones);
        }

        private void EventoCuponSeleccionado(object sender, EventArgs e)
        {
            int indiceCuponSeleccionado = listCupones.SelectedIndex;
            if (indiceCuponSeleccionado != -1)
            {
                Cupon cuponSeleciconado = _cupones[indiceCuponSeleccionado];
                PoblarNombreYCantidad(cuponSeleciconado);
            }
        }

        private void PoblarNombreYCantidad(Cupon cupon)
        {
            txtNombreCupon.Text = cupon.Nombre;
            numCantidadCupon.Value = cupon.CantidadRestante;
        }

        private void PoblarTabla(List<Cupon> cupones)
        {
            foreach (Cupon cupon in cupones)
            {
                listCupones.Items.Add("Nombre: " + cupon.Nombre + " - Tipo: " + cupon.tipoDescuentoMensaje[cupon.Tipo] + " - Cantidad: " + cupon.CantidadRestante);
            }
        }

        private void BtnModificarCupon_Click(object sender, EventArgs e)
        {

            try
            {
                Cupon cuponSeleccionado = _logicaProductorAccesoDatos.ObtenerCupon(_codigosCupones[listCupones.SelectedIndex]);

                _logicaProductorAccesoDatos.CambiarCantidadRestante(cuponSeleccionado, (int)numCantidadCupon.Value);
                _logicaProductorAccesoDatos.CambiarNombreCupon(cuponSeleccionado, txtNombreCupon.Text);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un cupon para modificar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
