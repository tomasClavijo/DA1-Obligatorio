using System;
using System.Windows.Forms;
using Dominio;
using LogicaDeNegocio.Interfaces;

namespace Interfaz
{
    public partial class AgregarProductor : UserControl
    {
        private ILogicaProductor _logicaProductor;
        public AgregarProductor(ILogicaProductor logicaProductor)
        {
            _logicaProductor = logicaProductor;
            InitializeComponent();
        }

        private void BtnAgregarProductorClick(object sender, EventArgs e)
        {
            try
            {
                Productor productor = new Productor
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                };
                _logicaProductor.RegistrarProductor(productor);
                MessageBox.Show("Productor creado con éxito.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
