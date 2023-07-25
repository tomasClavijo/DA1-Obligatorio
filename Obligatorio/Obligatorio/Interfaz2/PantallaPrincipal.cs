using Dominio;
using LogicaDeNegocio;
using LogicaDeNegocio.Interfaces;
using LogicaDeNegocio.Implementaciones;
using DatosEnMemoria;
using AccesoDatos.Implementaciones;
using AccesoDatos.Interfaces;
using System.Windows.Forms;
using System;

namespace Interfaz
{
    public partial class PantallaPrincipal : Form
    {
        private Datos _datos;
        private IRepositorioProductor _repositorioProductor;
        private IRepositorioAsistente _repositorioAsistente;

        private ILogicaProductor _logicaProductorAccesoDatos;
        private ILogicaProductorLogin _logicaProductorLogin;
        private ILogicaAsistente _logicaAsistenteAccesoDatos;

        public PantallaPrincipal()
        {
            _datos = new Datos();
            _repositorioProductor = new RepositorioProductorImp();
            _repositorioAsistente = new RepositorioAsistenteImp();

            _logicaProductorAccesoDatos = new LogicaProductorAccesoDatos(_repositorioProductor);
            _logicaProductorLogin = new LogicaProductorLogin(_datos);
            _logicaAsistenteAccesoDatos = new LogicaAsistenteAccesoDatos(_repositorioAsistente);

            InitializeComponent();
        }

        private void BtnAgregarProductorClick(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            UserControl agregarProductor = new AgregarProductor(_logicaProductorAccesoDatos);
            controlPanel.Controls.Add(agregarProductor);
        }

        private void BtnIniciarSesion(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            UserControl iniciarSesion = new IniciarSesion(_logicaProductorLogin, _logicaProductorAccesoDatos);
            controlPanel.Controls.Add(iniciarSesion);

        }

        private void BtnCrearEventoClick(object sender, EventArgs e)
        {
            if (_logicaProductorLogin.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();
                UserControl crearEvento = new AgregarEvento(_logicaProductorAccesoDatos);
                controlPanel.Controls.Add(crearEvento);
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para crear un evento.");
            }

        }
        private void BtnVisualizarEventosClick(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            UserControl visualizarEventos = new VisualizarEventos(_logicaProductorAccesoDatos, _logicaAsistenteAccesoDatos);
            controlPanel.Controls.Add(visualizarEventos);
        }

        private void BtnReporteEntradasClick(object sender, EventArgs e)
        {
            if (_logicaProductorLogin.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();
                UserControl reporteEntradas = new ReporteEntradas(_logicaAsistenteAccesoDatos);
                controlPanel.Controls.Add(reporteEntradas);
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para visualizar el reporte de entradas.");
            }
        }

        private void BtnEliminarEventoClick(object sender, EventArgs e)
        {

            if (_logicaProductorLogin.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();
                UserControl eliminarEventos = new EliminarEventos(_logicaProductorAccesoDatos);
                controlPanel.Controls.Add(eliminarEventos);
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para eliminar eventos.");
            }
        }

        private void BtnVisualizarEventosBorradorClick(object sender, EventArgs e)
        {
            if (_logicaProductorLogin.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();
                UserControl visualizarEventos = new VisualizarEventosBorrador(_logicaProductorAccesoDatos);
                controlPanel.Controls.Add(visualizarEventos);
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para visualizar los eventos en borrador.");
            }
        }

        public void VisualizarEventos(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            UserControl visualizarEventos = new VisualizarEventos(_logicaProductorAccesoDatos, _logicaAsistenteAccesoDatos);
            controlPanel.Controls.Add(visualizarEventos);
        }

        private void BtnReporteCompras_Click(object sender, EventArgs e)
        {
            if (_logicaProductorLogin.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();
                UserControl reporteCompras = new ReporteCompras(_logicaProductorAccesoDatos);
                controlPanel.Controls.Add(reporteCompras);
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para visualizar el reporte de compras.");
            }
        }

        private void BtnModificarCupon_Click(object sender, EventArgs e)
        {
            if (_logicaProductorLogin.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();
                UserControl modificarCupon = new ModificarCupon(_logicaProductorAccesoDatos);
                controlPanel.Controls.Add(modificarCupon);
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para modificar cupones.");
            }
        }

        private void BtnAgregarCupon_Click(object sender, EventArgs e)
        {
            if (_logicaProductorLogin.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();
                UserControl agregarCupones = new Interfaz.AgregarCupon(_logicaProductorAccesoDatos);
                controlPanel.Controls.Add(agregarCupones);
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para agregar nuevos cupones.");
            }
        }
    }
}