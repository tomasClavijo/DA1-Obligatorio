using System;
using System.Windows.Forms;
using LogicaDeNegocio.Interfaces;

namespace Interfaz
{
    public partial class IniciarSesion : UserControl
    {
        private ILogicaProductorLogin _logicaProductorLogin;
        private ILogicaProductor _logicaProductorAccesoDatos;

        public IniciarSesion(ILogicaProductorLogin logicaProductor, ILogicaProductor logicaProductor2)
        {
            _logicaProductorLogin = logicaProductor;
            _logicaProductorAccesoDatos = logicaProductor2;
            InitializeComponent();
        }

        private void BtnIniciarSesionClick(object sender, EventArgs e)
        {
            try
            {
                _logicaProductorLogin.IniciarSesion(_logicaProductorAccesoDatos.ObtenerProductor(txtEmail.Text));
                MessageBox.Show("Sesión iniciada con éxito.");
                Controls.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
