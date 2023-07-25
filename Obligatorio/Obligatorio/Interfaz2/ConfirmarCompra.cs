using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using LogicaDeNegocio.Interfaces;
using LogicaDeNegocio;

namespace Interfaz
{
    public partial class ConfirmarCompra : UserControl
    {
        private List<(Ticket, int)> _ticketsComprados;
        private ILogicaProductor _logicaProductor;
        private ILogicaAsistente _logicaAsistente;

        public ConfirmarCompra(Compra compra, List<(Ticket, int)> ticketsComprados, ILogicaProductor logicaProductor, ILogicaAsistente logicaAsistente)
        {
            _logicaProductor = logicaProductor;
            _logicaAsistente = logicaAsistente;
            _ticketsComprados = ticketsComprados;
            InitializeComponent();

            txtBoxCompra.Text = GenerarSalida(compra, ticketsComprados);
        }

        private void BtnConfirmarCompaClick(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControl visualizarEventos = new VisualizarEventos(_logicaProductor, _logicaAsistente);
            Controls.Add(visualizarEventos);
        }

        private string GenerarSalida(Compra compra, List<(Ticket, int)> ticketsComprados)
        {
            string retorno = "";
            int i = 0;

            foreach ((Ticket, int) ticketComprado in ticketsComprados)
            {
                for (int j = 0; j < ticketComprado.Item2; j++)
                {
                    retorno += ticketComprado.Item1.Nombre + " - " + compra.Codigos[i].CodigoCompra + " - " + compra.Asistente.Nombre + " " + compra.Asistente.Apellido + " - " + compra.Asistente.Cedula + "\n";
                    i++;
                }
            }
            return retorno;
        }
    }
}
