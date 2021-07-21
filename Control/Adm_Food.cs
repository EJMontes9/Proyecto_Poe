using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Register(int code, string foodName, double price, string observacion, bool state)
        {
            Food obj = new Food(code, foodName, price, observacion, state);
            lisFood.Add(obj);
        }

        public void FillData(DataGridView DGPresentar)
        {
            foreach (var a in lisFood)
            {
                DGPresentar.Rows.Add(a.Code, a.FoodName, a.Price, a.Observation, a.State);
            }
        }
    }
}
