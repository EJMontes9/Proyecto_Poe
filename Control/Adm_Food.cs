using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class Adm_Food
    {
        List<Food> lisFood = new List<Food>();
        private static Adm_Food adm = null;

        public Adm_Food()
        {
        }

        public static Adm_Food getAdm()
        {
            if (adm == null)
            {
                adm = new Adm_Food();
            }
            return adm;
        }

        public Adm_Food Get()
        {
            if (adm == null)
            {
                adm = new Adm_Food();
            }
            return adm;
        }

        public void savefood()
        {
            Food obj1 = new Food(1, "Arroz con menestra y carne", 2.50, true);
            Food obj2 = new Food(2, "Arroz con pure y carne", 2.50, true);
            Food obj3 = new Food(3, "Seco de pollo", 2.50, true);
            Food obj4 = new Food(4, "Encebollado", 2.50, true);
            lisFood.Add(obj1);
            lisFood.Add(obj2);
            lisFood.Add(obj3);
            lisFood.Add(obj4);
        }
        public string NameFood(int code)
        {
            foreach (var a in lisFood)
            {
                if (code == a.Code)
                {
                    return a.FoodName;
                }
            }
            return "Comida no encontrada";
        }

        public double Price(int code)
        {
            foreach (var a in lisFood)
            {
                if (code == a.Code)
                {
                    return a.Price;
                }
            }
            return 0;
        }

        public void Register(int code, string foodName, double price, bool state)
        {
            Food obj = new Food(code,foodName,price,state);
            lisFood.Add(obj);
        }

        
    }
}
