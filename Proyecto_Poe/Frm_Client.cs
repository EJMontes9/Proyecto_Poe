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
    public partial class Frm_Client : Form
    {
        public Frm_Client()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Menu frm = new Frm_Menu();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtDelete frm = new BtDelete();
            frm.Show();
        }
    }
}
