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
    public partial class Frm_Reserva : Form
    {
        Adm_Reservation adm = Adm_Reservation.getAdm();
        ClsValidations validacion = new ClsValidations();
        public Frm_Reserva()
        {
            InitializeComponent();
            dateReserva.MinDate = DateTime.Now;
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

        Adm_Reservation reservation = Adm_Reservation.getAdm();

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreReserva.Text != "")
                {
                    string nombre = txtNombreReserva.Text;
                    DateTime fecha = dateReserva.Value;
                    int npersona = Int32.Parse(cmbNumPersonas.Text);
                    string mesa = "";
                    if (rdButtonVentana.Checked)
                    {
                        mesa = "Vista a la Ventana";
                    }
                    else if (rdButtonCentro.Checked)
                    {
                        mesa = "Centro del Restaurante";
                    }
                    else if (rdButtonPuerta.Checked)
                    {
                        mesa = "Cerca de la Puerta";
                    }
                    string sugerencia = txtSugerencias.Text;
                    if (mesa != "")
                    {
                        if (adm.tiempo(fecha) < 7)
                        {
                            adm.tiempo(fecha);
                            reservation.Get().Registro(nombre, fecha, npersona, mesa, sugerencia);
                            MessageBox.Show("RESERVA EXITOSA");
                        }
                        else
                        {
                            MessageBox.Show("NO HAY MESAS DISPONIBLES");
                        }
                    }
                    else
                    {
                        MessageBox.Show("PORFAVOR SELECCIONE LUGAR DE MESA");
                    }
                    txtNombreReserva.Text = "";
                    cmbNumPersonas.Text = "";
                    cmbNumPersonas.Text = "";
                    txtSugerencias.Text = "";
                }
                else
                {
                    MessageBox.Show("PORFAVOR INSERTE DATOS");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("PORFAVOR LLENE DATOS");
            }
        }

        private void txtNombreReserva_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
