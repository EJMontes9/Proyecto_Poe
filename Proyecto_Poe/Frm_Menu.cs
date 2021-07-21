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
        int eliminar;
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

        private void dgvConsultarComida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminar = 0;
            eliminar = Int32.Parse(dgvConsultarComida.CurrentCell.RowIndex.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Eliminar una fila
            if (dgvConsultarComida.CurrentCell != null)
            {
                try
                {
                    dgvConsultarComida.Rows.RemoveAt(eliminar);
                    food.Get().deleteData(eliminar);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Primero seleccione una fila a eliminar");
                }
            }
        }
    }
}
