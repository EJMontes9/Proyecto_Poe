using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Order
    {
        List<Order> lisOrder = new List<Order>();
        private static Adm_Order adm = null;

        public Adm_Order()
        {
            lisOrder = new List<Order>();
        }

        public static Adm_Order getAdm()
        {
            if (adm == null)
            {
                adm = new Adm_Order();
            }
            return adm;
        }

        public Adm_Order Get()
        {
            if (adm == null)
            {
                adm = new Adm_Order();
            }
            return adm;
        }

        public void Registro(string comorder, string client, int table, double totPay)
        {
            Order obj = new Order(comorder, client, table, totPay);
            lisOrder.Add(obj);
        }
        
        public void FillData(DataGridView DGPresentar)
        {
            foreach (var a in lisOrder)
            {
                DGPresentar.Rows.Add(a.Comorder, a.Client, a.Table, a.TotPay);
            }
        }

        public void FillData(DataGridView DGPresentar,int table)
        {
            foreach (var a in lisOrder)
            {
                if (table == a.Table)
                {
                    DGPresentar.Rows.Add(a.Comorder, a.Client, a.Table, a.TotPay);
                }
            }
        }
    }
}
