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

        public Adm_Food()
        {
            //Guardando comida por defecto
            Food obj1 = new Food(1,"Encebollado",2.50,true);
            lisFood.Add(obj1);
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
    }
}
