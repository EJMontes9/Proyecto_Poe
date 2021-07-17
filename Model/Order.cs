using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        private List<Food> lisFood = new List<Food>();
        private Client client;
        private int table;
        private double totPay;

        public Order(List<Food> lisFood, Client client, int table, double totPay)
        {
            this.lisFood = lisFood;
            this.client = client;
            this.table = table;
            this.totPay = totPay;
        }

        public Order()
        {
        }

        public List<Food> LisFood { get => lisFood; set => lisFood = value; }
        public Client Client { get => client; set => client = value; }
        public int Table { get => table; set => table = value; }
        public double TotPay { get => totPay; set => totPay = value; }

    }
}
