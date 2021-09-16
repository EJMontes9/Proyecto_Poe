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
    public partial class Frm_EditarUsuario : Form
    {
        public Frm_EditarUsuario()
        {
            Adm_User adm_user = Adm_User.getAdm();
            ClsValidations validar = new ClsValidations();
            InitializeComponent();
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            Frm_MenuOpciones frm = new Frm_MenuOpciones();
            frm.Show();
            this.Visible = false;
        }

     
        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
