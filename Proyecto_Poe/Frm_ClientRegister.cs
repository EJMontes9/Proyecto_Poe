using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Poe
{
    public partial class Frm_ClientRegister : Form
    {
        public Frm_ClientRegister()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            String ci = txtCedula.Text;
            String Nombre = txtNombres.Text;
            String Apellido = txtApellidos.Text;
            String Telefono = txtTelefono.Text;
            String Correo = txtCorreo.Text;
            String Ciudad = txtCiudad.Text;
            String Direccion = txtDireccion.Text;
            String Contraseña = txtContra.Text;

        }
    }
}
