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
    public partial class Frm_UpdateUser : Form
    {
        Adm_User adm = new Adm_User();
        public Frm_UpdateUser()
        {
            InitializeComponent();
            String cedula = adm.Get().GetActual_User();
            txtCedula.Text = adm.Obtener_Usuario(cedula, "1");
            txtNombres.Text = adm.Obtener_Usuario(cedula, "2");
            txtApellidos.Text = adm.Obtener_Usuario(cedula, "3");
            txtTelefono.Text = adm.Obtener_Usuario(cedula, "4");
            txtCorreo.Text = adm.Obtener_Usuario(cedula, "5");
            txtCiudad.Text = adm.Obtener_Usuario(cedula, "6");
            txtDireccion.Text = adm.Obtener_Usuario(cedula, "7");
            txtContra.Text = adm.Obtener_Usuario(cedula, "8");
            txtCedula.Enabled = false;


        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            Frm_MenuOpciones frm = new Frm_MenuOpciones();
            frm.Show();
            this.Visible = false;
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String ci = txtCedula.Text;
                String Nombre = txtNombres.Text;
                String Apellido = txtApellidos.Text;
                String Telefono = txtTelefono.Text;
                String Correo = txtCorreo.Text;
                String Ciudad = txtCiudad.Text;
                String Direccion = txtDireccion.Text;
                String Contra = txtContra.Text;

                if (adm.Get().Update_user(ci, Nombre, Apellido, Telefono, Correo, Ciudad, Direccion, Contra))
                {
                    MessageBox.Show("Usuario actualizado con éxito");
                    txtCedula.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";
                    txtCiudad.Text = "";
                    txtDireccion.Text = "";
                    txtContra.Text = "";

                }
                else
                {
                    MessageBox.Show("Usuario no actualizado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Rellene todo los campos");
            }
        }

       
    }
}

