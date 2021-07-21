using Control;
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
        Adm_User adm_user = Adm_User.getAdm();
        ClsValidations validar = new ClsValidations();
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
            String Contra = txtContra.Text;

            adm_user.Get().Registro(ci, Nombre, Apellido, Telefono, Correo, Ciudad, Direccion, Contra);

            MessageBox.Show("Usuario registrado exitosamente");

            txtCedula.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtContra.Text = "";
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = false;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Numbers(sender, e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Letters(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Letters(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Numbers(sender, e);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Letters(sender, e);
        }
    }
}
