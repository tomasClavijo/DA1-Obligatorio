using LogicaDeNegocio.Interfaces;
using System.Windows.Forms;
using Dominio;
using System.Collections.Generic;
using System;

namespace Interfaz
{
    public partial class ReporteCompras : UserControl
    {
        private ILogicaProductor _logicaProductorAccesoDatos;
        private List<Compra> _compras;

        public ReporteCompras(ILogicaProductor logicaProductor)
        {
            InitializeComponent();
            _logicaProductorAccesoDatos = logicaProductor;

            try
            {
                _compras = _logicaProductorAccesoDatos.ObtenerCompras();
                CargarTabla(_compras);  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnFiltrarCompras_Click(object sender, EventArgs e)
        {
            CargarTabla(_compras);
        }

        private void CargarTabla(List<Compra> compras)
        {
            try
            {
                dgvCompras.Rows.Clear();

                string cedulaFiltrar = txtCIUsuario.Text;
                int montoFiltrar = (int)numMontoFiltrar.Value;
                DateTime fechaInicial = dateInicio.Value;
                DateTime fechaFinal = dateFin.Value;


                if (cedulaFiltrar != "")
                {
                    compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasCedula(compras, cedulaFiltrar);
                }

                if (montoFiltrar > 0)
                {
                    compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasMonto(compras, montoFiltrar);
                }

                compras = _logicaProductorAccesoDatos.ObtenerComprasFiltradasFecha(compras, fechaInicial, fechaFinal);

                foreach (Compra compra in compras)
                {
                    dgvCompras.Rows.Add(compra.Asistente.Nombre + " " + compra.Asistente.Apellido, compra.Asistente.Cedula, MostrarCodigos(compra.Codigos), compra.Monto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string MostrarCodigos(List<Codigo> codigos)
        {
            string retorno = "";
            foreach (Codigo codigo in codigos)
            {
                retorno += codigo.CodigoCompra + " - "+ Environment.NewLine;
            }
            return retorno;
        }
    }
}
