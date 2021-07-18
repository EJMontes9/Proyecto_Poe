using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class Adm_Order
    {
        List<Order> lisOrder = new List<Order>();

        public Adm_Order()
        {
        }

        public void Registro(string comorder, string client, int table, double totPay)
        {
            Order obj = new Order(comorder, client, table, totPay);
            lisOrder.Add(obj);
        }
    }
}
