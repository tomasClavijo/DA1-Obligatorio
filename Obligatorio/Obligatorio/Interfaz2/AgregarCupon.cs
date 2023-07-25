using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio.Interfaces;
using Dominio;

namespace Interfaz
{
    public partial class AgregarCupon : UserControl
    {
        private const int CERO = 0;
        public List<Cupon> cupones;
        private ILogicaProductor _logicaProductorAcesoDatos;

        public AgregarCupon(ILogicaProductor logicaProductor)
        {
            _logicaProductorAcesoDatos = logicaProductor;
            cupones = new List<Cupon>();
            InitializeComponent();

            txtDescuento2.Visible = false;
            lblX.Visible = false;
            cbTipoCupon.DataSource = Enum.GetValues(typeof(TipoDescuento));
        }

        private string GenerarCodigo()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }

        private void CrearCuponPorcentaje()
        {
            CuponPorcentaje unCupon = new CuponPorcentaje()
            {
                Nombre = txtNombreCupon.Text,
                CantidadRestante = (int)txtCantidadCupon.Value,
                Codigo = GenerarCodigo(),
                Tipo = TipoDescuento.Porcentaje,
                Porcentaje = (int)txtDescuento1.Value
            };
            _logicaProductorAcesoDatos.AgregarCupon(unCupon);
        }
        private void CrearCuponACantidad()
        {
            CuponACantidad unCupon = new CuponACantidad()
            {
                Nombre = txtNombreCupon.Text,
                CantidadRestante = (int)txtCantidadCupon.Value,
                Codigo = GenerarCodigo(),
                Tipo = TipoDescuento.CantidadDeEntradas,
                PrimerValor = (int)txtDescuento1.Value,
                SegundoValor = (int)txtDescuento2.Value
            };
            _logicaProductorAcesoDatos.AgregarCupon(unCupon);
        }

        private void CrearCuponValorFijo()
        {
            CuponValorFijo unCupon = new CuponValorFijo()
            {
                Nombre = txtNombreCupon.Text,
                CantidadRestante = (int)txtCantidadCupon.Value,
                Codigo = GenerarCodigo(),
                Tipo = TipoDescuento.ValorFijo,
                ValorFijo = (int)txtDescuento1.Value
            };
            _logicaProductorAcesoDatos.AgregarCupon(unCupon);
        }

        private void BtnAgregarCupon(object sender, EventArgs e)
        {
            try
            {
                switch (cbTipoCupon.Text)
                {
                    case "Porcentaje":
                        CrearCuponPorcentaje();
                        LimpiarControles();
                        break;
                    case "ValorFijo":
                        CrearCuponValorFijo();
                        LimpiarControles();
                        break;
                    case "CantidadDeEntradas":
                        CrearCuponACantidad();
                        LimpiarControles();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarControles()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = CERO;
                }
            }
        }

        private void EventoCambioDeTipo(object sender, EventArgs e)
        {
            switch (cbTipoCupon.Text)
            {
                case "Porcentaje":
                    lbDescuento.Text = "Porcentaje descuento:";
                    txtDescuento2.Visible = false;
                    lblX.Visible = false;
                    break;
                case "ValorFijo":
                    lbDescuento.Text = "Valor fijo descuento:";
                    txtDescuento2.Visible = false;
                    lblX.Visible = false;
                    break;
                case "CantidadDeEntradas":
                    lbDescuento.Text = "Descuento entradas:";
                    txtDescuento2.Visible = true;
                    lblX.Visible = true;
                    break;
            }
        }
    }
}
