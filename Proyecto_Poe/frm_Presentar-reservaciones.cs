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
    public partial class frm_Presentar_reservaciones : Form
    {
        Adm_Reservation reserva = Adm_Reservation.getAdm();

        public frm_Presentar_reservaciones()
        {
            InitializeComponent();
            reserva.Get().FillData(dataGridView1);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_MenuOpciones frm = new Frm_MenuOpciones();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(eliminar);
                    reserva.Get().Eliminar(eliminar);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Seleccione el dato que desea eliminar");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int eliminar;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminar = 0;
            eliminar = Int32.Parse(dataGridView1.CurrentCell.RowIndex.ToString());
        }
    }
}
