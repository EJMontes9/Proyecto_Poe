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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Regresar al menu
            this.Close();
            Frm_MenuOpciones frmOpciones = new Frm_MenuOpciones();
            frmOpciones.Show();
        }
    }
}
