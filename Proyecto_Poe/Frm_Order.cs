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
    public partial class Frm_Order : Form
    {
        Adm_Food amdfood = new Adm_Food();
        double TotPay = 0.00;
        int i;
        public Frm_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = Int32.Parse(TxtCod.Text);
            int amount = Int32.Parse(TxtAmount.Text);
            double Price = amdfood.Price(code);
            double Tot = Price * amount;
            if (amdfood.NameFood(code) == "Comida no encontrada")
            {
                MessageBox.Show("Codigo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DgOrder.Rows.Add(code, amdfood.NameFood(code), amount, amdfood.Price(code), Tot);
                TotPay = TotPay + Tot;
                LaTot.Text = TotPay.ToString("0.00");
            }

            TxtAmount.Text = "";
            TxtCod.Text = "";
            
        }

        private void DgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = 0;
            i = Int32.Parse(DgOrder.CurrentCell.RowIndex.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double ndelete = Convert.ToDouble(DgOrder.CurrentRow.Cells[4].Value.ToString());
            TotPay = TotPay - ndelete;
            LaTot.Text = TotPay.ToString("0.00");
            DgOrder.Rows.RemoveAt(i);
        }
    }
}
