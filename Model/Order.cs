using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        private string comorder;
        private string client;
        private int table;
        private double totPay;

        public Order(string comorder, string client, int table, double totPay)
        {
            this.comorder = comorder;
            this.client = client;
            this.table = table;
            this.totPay = totPay;
        }

        public Order()
        {
        }

        public string Comorder { get => comorder; set => comorder = value; }
        public string Client { get => client; set => client = value; }
        public int Table { get => table; set => table = value; }
        public double TotPay { get => totPay; set => totPay = value; }

    }
}
