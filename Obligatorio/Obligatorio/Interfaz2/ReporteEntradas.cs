using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogicaDeNegocio.Interfaces;
using Dominio;

namespace Interfaz
{
    public partial class ReporteEntradas : UserControl
    {

        private ILogicaAsistente _logicaAsistente;
        private const int Cero = 0;
        public ReporteEntradas(ILogicaAsistente logicaAsistente)
        {
            _logicaAsistente = logicaAsistente;
            InitializeComponent();
        }

        private void BtnGenerarReporteClick(object sender, EventArgs e)
        {
            listReporteEntradas.Items.Clear();
            string textoReporte;
            int precioMin = (int)txtPrecioMinimo.Value;
            int precioMax = (int)txtPrecioMaximo.Value;
            Dictionary<Categoria, int> reporte = _logicaAsistente.GenerarReporte(precioMin, precioMax);

            if (reporte.Count > Cero)
            {
                foreach (KeyValuePair<Categoria, int> item in reporte)
                {
                    textoReporte = " - " + item.Key.ToString() + " : " + item.Value.ToString() + "\n";
                    listReporteEntradas.Items.Add(textoReporte);
                }
            }
            else
            {
                listReporteEntradas.Items.Add("No hay resultados para esta consulta.");
            }
        }
    }
}