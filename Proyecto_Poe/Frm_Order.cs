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
        Adm_Order amdorder = Adm_Order.getAdm();
        Adm_Food amdfood = Adm_Food.getAdm();
        Adm_Client admclient = new Adm_Client();
        ClsValidations validar = new ClsValidations();
        double TotPay = 0.00;
        string comorder;
        int i;
        public Frm_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Int32.Parse(TxtCod.Text);
                int amount = Int32.Parse(TxtAmount.Text);
                double Price = amdfood.Get().Price(code);
                double Tot = Price * amount;
                if (amdfood.Get().NameFood(code) == "Comida no encontrada")
                {
                    MessageBox.Show("Codigo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DgOrder.Rows.Add(code, amdfood.Get().NameFood(code), amount, amdfood.Get().Price(code), Tot);
                    TotPay = TotPay + Tot;
                    LaTot.Text = TotPay.ToString("0.00");
                }

                TxtAmount.Text = "";
                TxtCod.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("porfavor, ingrese codigo y cantidad del producto");
            }
        }

        private void DgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = 0;
            i = Int32.Parse(DgOrder.CurrentCell.RowIndex.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool removeFood;
            if (DgOrder.CurrentCell != null)
            {
                double ndelete = Convert.ToDouble(DgOrder.CurrentRow.Cells[4].Value.ToString());
                try
                {
                    DgOrder.Rows.RemoveAt(i);
                    removeFood = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Escoja el dato que desea eliminar");
                    removeFood = false;
                }
                if (removeFood) {
                    TotPay = TotPay - ndelete;
                    LaTot.Text = TotPay.ToString("0.00");
                }
            }
            else
            {
                MessageBox.Show("No existen datos para eliminar ");
            } 
        }
        
        private void BtOrder_Click(object sender, EventArgs e)
        {
            
            if (DgOrder.CurrentCell != null)
            {
                for (int fila = 0; fila < DgOrder.Rows.Count; fila++)
                {
                    comorder = comorder+"-" + DgOrder.Rows[fila].Cells[2].Value.ToString() + " " + DgOrder.Rows[fila].Cells[1].Value.ToString() + " * \n";
                }
                try
                {
                    amdorder.Get().Registro(comorder, admclient.NameClient(TxtCi.Text), Int32.Parse(TxtTable.Text), Convert.ToDouble(LaTot.Text));
                    MessageBox.Show("Su orden ha sido registrada con éxito");
                    TxtCi.Text = "";
                    TxtTable.Text = "";
                    TotPay = 0;
                    LaTot.Text = TotPay.ToString("0.00");
                    comorder = "";
                    DgOrder.Rows.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Porfavor ingrese el numero de mesa");
                }
            }
            else
            {
                MessageBox.Show("No existen productos para crear su odren ");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_MenuOpciones frmOpciones = new Frm_MenuOpciones();
            frmOpciones.Show();
        }

        private void TxtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Numbers(sender, e);
        }

        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Numbers(sender, e);
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Numbers(sender, e);
        }

        private void TxtTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Only_Numbers(sender, e);
        }
    }
}
