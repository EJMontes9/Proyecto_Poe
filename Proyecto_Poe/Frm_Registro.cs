﻿using Control;
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
    public partial class Frm_Registro : Form
    {
        Adm_Order adm = Adm_Order.getAdm();
        public Frm_Registro()
        {
            InitializeComponent();
            adm.Get().FillData(DgRecords);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_MenuOpciones frmOpciones = new Frm_MenuOpciones();
            frmOpciones.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidations validar = new ClsValidations();
            validar.Only_Numbers(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DgRecords.Rows.Clear();
            adm.Get().FillData(DgRecords, Int32.Parse(TxtCi.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
