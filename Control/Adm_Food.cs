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
        List<Food> LisClient = new List<Food>();

        public Adm_Food()
        {
            //Guardando comida por defecto
            Food obj1 = new Food(1,"Encebollado",2.50,true);
            LisClient.Add(obj1);
        }
    }
}
