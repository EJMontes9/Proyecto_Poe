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
    public partial class Frm_Menu : Form
    {
        Adm_Food food = Adm_Food.getAdm();
        public Frm_Menu()
        {
            InitializeComponent();
            food.Get().FillData(dgvConsultarComida);

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
