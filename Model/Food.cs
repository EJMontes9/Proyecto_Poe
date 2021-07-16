using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Food
    {
        private int code;
        private string foodName;
        private double price;
        private string observation;
        private bool state;

        public Food(int code, string foodName, double price, bool state)
        {
            this.foodName = foodName;
            this.price = price;
            this.state = state;
            this.code = code;
        }

        public Food(int code, string foodName, double price, string observation, bool state)
        {
            this.foodName = foodName;
            this.price = price;
            this.observation = observation;
            this.state = state;
            this.code = code;
        }

        public Food()
        {
        }

        public int Code { get => code; set => code = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public double Price { get => price; set => price = value; }
        public string Observation { get => observation; set => observation = value; }
        public bool State { get => state; set => state = value; }

    }
}
