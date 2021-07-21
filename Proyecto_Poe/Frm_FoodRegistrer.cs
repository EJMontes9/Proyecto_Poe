using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Proyecto_Poe
{
    public partial class Frm_FoodRegistrer : Form
    {
        Adm_Food amdfood = Adm_Food.getAdm();
        ClsValidations validar = new ClsValidations();
        public Frm_FoodRegistrer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Registro de comida
            try
            {
                int code = Int32.Parse(txtCodigo.Text);
                String nombre = txtNombreComida.Text;
                double precio = double.Parse(txtPrecioComida.Text);
                String observacion = txtObservacion.Text;
                bool estado;

                if (rdButtonDisponible.Checked)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                amdfood.Get().Register(code, nombre, precio, observacion, estado);

                txtCodigo.Text = "";
                txtNombreComida.Text = "";
                txtPrecioComida.Text = "";
                txtObservacion.Text = "";
                rdButtonDisponible.Checked = false;
                rdButtonNoDisponible.Checked = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Reelene todos los campos primero");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_MenuOpciones regresar = new Frm_MenuOpciones();
            regresar.Show();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Numbers(sender, e);
        }

        private void txtNombreComida_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Letters(sender, e);
        }
    }
}
