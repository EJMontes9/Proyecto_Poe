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
                MessageBox.Show("Se inicio sesion", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos erronios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
