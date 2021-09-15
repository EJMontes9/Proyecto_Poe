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
    public partial class Frm_FoodUpgrade : Form
    {
        Adm_Food comida = new Adm_Food();

        public Frm_FoodUpgrade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Menu regresar = new Frm_Menu();
            regresar.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Enabled = false;
                txtNombreComida.Enabled = true;
                txtPrecioComida.Enabled = true;
                txtObservacion.Enabled = true;
                groupBox1.Enabled = true;

                string codigo = txtCodigo.Text;
                txtNombreComida.Text = comida.SearchCode("2", codigo);
                txtPrecioComida.Text = comida.SearchCode("3", codigo);
                txtObservacion.Text = comida.SearchCode("4", codigo);
                if(Boolean.Parse(comida.SearchCode("5", codigo)))
                {
                    rdButtonDisponible.Checked = true;
                }
                else
                {
                    rdButtonNoDisponible.Checked = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Codigo no registrado");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
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

            comida.update(codigo, nombre, precio, observacion, estado);

            txtCodigo.Text = "";
            txtNombreComida.Text = "";
            txtPrecioComida.Text = "";
            txtObservacion.Text = "";
            rdButtonDisponible.Checked = false;
            rdButtonNoDisponible.Checked = false;
        }
    }
}
