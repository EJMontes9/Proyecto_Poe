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
        Adm_User adm = Adm_User.getAdm();
        Adm_Food adm_Food = Adm_Food.getAdm();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cedula = TxtCi.Text;
            string contraseña = TxtPassword.Text;

            if (adm.Get().IniciarSesion(cedula, contraseña))
            {
                //MessageBox.Show("Se inicio sesion", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                Frm_MenuOpciones frm = new Frm_MenuOpciones();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Intente Nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TxtCi.Text = "";
            TxtPassword.Text = "";
        }

        private void TxtCi_KeyPress(object sender, KeyPressEventArgs e)
        {

            ClsValidations clsValidations = new ClsValidations();
            clsValidations.Only_Numbers(sender, e);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Frm_ClientRegister frm2 = new Frm_ClientRegister();
            frm2.Show();
            this.Visible = false;
        }
    }
}
