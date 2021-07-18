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
    public partial class Frm_MenuOpciones : Form
    {
        public Frm_MenuOpciones()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Frm_Menu frm = new Frm_Menu();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Frm_Order frm = new Frm_Order();
            frm.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frmLogin = new Form1();
            frmLogin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Frm_Registro frm_Reg = new Frm_Registro();
            frm_Reg.Show();
        }
    }
}
