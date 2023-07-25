using System;
using System.Windows.Forms;
using LogicaDeNegocio.Interfaces;
using Dominio;
namespace Interfaz
{
    public partial class AplicarCupon : UserControl
    {
        private ILogicaAsistente _logicaAsistenteAccesoDatos;
        private ILogicaProductor _logicaProductorAccesoDatos;
        private Evento _eventoSeleccionado;
        private bool _seIngresoCupon;
        public AplicarCupon(Evento eventoSeleccionado, ILogicaAsistente logicaAsistente, ILogicaProductor logicaProductor)
        {
            _logicaAsistenteAccesoDatos = logicaAsistente;
            _logicaProductorAccesoDatos = logicaProductor;
            _eventoSeleccionado = eventoSeleccionado;
            InitializeComponent();
        }






        private void Continuar_Click(object sender, EventArgs e)
        {
            try
            {
                Cupon cuponAplicado;
                if (codigoCupon.Text.Equals(""))
                {
                     cuponAplicado = _logicaProductorAccesoDatos.ObtenerCupon("0000000000");
                }
                else
                {
                     cuponAplicado = _logicaProductorAccesoDatos.ObtenerCupon(codigoCupon.Text);
                }
                _logicaProductorAccesoDatos.ControlarCupon(cuponAplicado);
                Asistente asistente = new Asistente
                {
                    Nombre = txtNombreUsuario.Text,
                    Apellido = txtApellidoUsuario.Text,
                    Cedula = Cedula.Text
                };
                _logicaProductorAccesoDatos.ControlarAsistenteEvento(asistente, _eventoSeleccionado);
                this.Controls.Clear();
                UserControl visualizaFunciones = new VisualizarFunciones(_eventoSeleccionado, _logicaAsistenteAccesoDatos, _logicaProductorAccesoDatos, cuponAplicado, asistente);
                this.Controls.Add(visualizaFunciones);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
