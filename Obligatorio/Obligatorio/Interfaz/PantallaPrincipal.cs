using Dominio;
using LogicaDeNegocio;
using DatosEnMemoria;
using System.Windows.Forms;
using System;

namespace Interfaz
{
    public partial class paginaPrincipal : Form
    {
        private Datos _datos;
        private LogicaProductor _logicaProductor;
        private LogicaAsistente _logicaAsistente;

        public paginaPrincipal()
        {
            _datos = new Datos();
            _logicaProductor = new LogicaProductor(_datos);
            _logicaAsistente = new LogicaAsistente(_datos);
            InitializeComponent();
        }

        private void btnAgregarProductorClick(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();/*
            UserControl agregarProductor = new AgregarProductor(_logicaProductor);
            controlPanel.Controls.Add(agregarProductor);*/
        }

        private void BtnIniciarSesion(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();/*
            UserControl iniciarSesion = new IniciarSesion(_logicaProductor);
            controlPanel.Controls.Add(iniciarSesion);*/

        }

        private void btnCrearEventoClick(object sender, EventArgs e)
        {
            if (_logicaProductor.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();/*
                UserControl crearEvento = new AgregarEvento2(_logicaProductor);
                controlPanel.Controls.Add(crearEvento);*/
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para crear un evento");
            }

        }
        private void btnVisualizarEventosClick(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();/*
            UserControl visualizarEventos = new VisualizarEventos(_logicaProductor, _logicaAsistente);
            controlPanel.Controls.Add(visualizarEventos);*/
        }

        private void btnReporteEntradasClick(object sender, EventArgs e)
        {
            if (_logicaProductor.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();/*
                UserControl reporteEntradas = new ReporteEntradas(_logicaAsistente);
                controlPanel.Controls.Add(reporteEntradas);*/
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para visualizar el reporte de entradas");
            }
        }

        private void btnEliminarEventoClick(object sender, EventArgs e)
        {

            if (_logicaProductor.HayProductorIniciado())
            {
                controlPanel.Controls.Clear();
                /*UserControl eliminarEventos = new EliminarEventos(_logicaProductor);
                controlPanel.Controls.Add(eliminarEventos);*/
            }
            else
            {
                MessageBox.Show("Debe de iniciar sesión como productor para eliminar eventos");
            }
        }

        private void btnVisualizarEventosBorradorClick(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            /*UserControl visualizarEventos = new VisualizarEventosBorrador(_logicaProductor);
            controlPanel.Controls.Add(visualizarEventos);*/
        }
    }
}