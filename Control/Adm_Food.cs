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
        DataBase register = new DataBase();
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


        public string SearchCode(string opcion, string codigo)
        {
            List<Food> listar = register.buscar_comida_x_codigo(codigo);
            switch (opcion)
            {
                case "1":
                    return listar[0].Code.ToString();
                    break;

                case "2":
                    return listar[0].FoodName.ToString();
                    break;

                case "3":
                    return listar[0].Price.ToString();
                    break;

                case "4":
                    return listar[0].Observation.ToString();
                    break;

                case "5":
                    return listar[0].State.ToString();
                    break;

                default:
                    return "Dato no valido";
                    break;
            }
        }

        public string NameFood(int code)
        {
            foreach (var a in register.list_food())
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
            foreach (var a in register.list_food())
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
            register.insert_food(lisFood);
        }


        public void FillData(DataGridView DGPresentar)
        {
            foreach (var a in register.list_food())
            {
                DGPresentar.Rows.Add(a.Code, a.FoodName, a.Price, a.Observation, a.State);
            }
        }

        public void deleteData(string capture)
        {
            //lisFood.RemoveAt(eliminar);
            MessageBox.Show(register.delete_foof(capture));

        }

        public void update(int code, string foodName, double price, string observacion, bool state)
        {
            Food obj = new Food(code, foodName, price, observacion, state);
            lisFood.Add(obj);
            register.update(lisFood);
        }
    }
}
