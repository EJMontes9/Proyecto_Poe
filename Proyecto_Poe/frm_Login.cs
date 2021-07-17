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
    public partial class Form1 : Form
    {
        Adm_Client amd = new Adm_Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cedula = TxtCi.Text;
            string contraseña = TxtPassword.Text;

            if (amd.IniciarSesion(cedula, contraseña))
            {
                //MessageBox.Show("Se inicio sesion", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                Frm_Client frm = new Frm_Client();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Intente Nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCi_KeyPress(object sender, KeyPressEventArgs e)
        {

            ClsValidations clsValidations = new ClsValidations();

            clsValidations.Only_Numbers(sender, e);

        }
    }
}
