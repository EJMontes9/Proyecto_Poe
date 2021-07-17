using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    class Adm_Order
    {
        List<Order> lisOrder = new List<Order>();

        public Adm_Order()
        {
        }

        public void Registro(List<Food> lisFood, Client client, int table, double totPay)
        {
            Order obj = new Order(lisFood, client, table, totPay);
            lisOrder.Add(obj);
        }
    }
}
