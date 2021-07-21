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
    Adm_Reservation adm = Adm_Reservation.getAdm();
    public partial class Frm_Reserva : Form
    {
        ClsValidations validacion = new ClsValidations();
        public Frm_Reserva()
        {
            InitializeComponent();
        }

        private void txtNombreReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.Only_Letters(sender, e);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_MenuOpciones frmOpciones = new Frm_MenuOpciones();
            frmOpciones.Show();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

        }
    }
}
