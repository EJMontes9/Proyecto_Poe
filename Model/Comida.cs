using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comida
    {
        private string foodName;
        private float price;
        private string observation;
        private bool state;

        public Comida(string foodName, float price, bool state)
        {
            this.foodName = foodName;
            this.price = price;
            this.state = state;
        }

        public Comida(string foodName, float price, string observation, bool state)
        {
            this.foodName = foodName;
            this.price = price;
            this.observation = observation;
            this.state = state;
        }

        public Comida()
        {
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public float Price { get => price; set => price = value; }
        public string Observation { get => observation; set => observation = value; }
        public bool State { get => state; set => state = value; }

    }
}
