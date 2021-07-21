using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class Adm_Reservation
    {
        List<Reservation> lisOrder = new List<Reservation>();
        private static Reservation adm = null;
        public static Reservation getAdm()
        {
            if (adm == null)
            {
                adm = new Reservation();
            }
            return adm;
        }

        public Reservation Get()
        {
            if (adm == null)
            {
                adm = new Reservation();
            }
            return adm;
        }

        public void Registro(string name, DateTime dateandTime, int people, string location, string suggestion)
        {
            Reservation obj = new Reservation(name, dateandTime, people, location, suggestion);
            lisOrder.Add(obj);
        }
    }
}
