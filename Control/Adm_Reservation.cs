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
        List<Reservation> lisReservation = new List<Reservation>();
        private static Adm_Reservation adm = null;

        public static Adm_Reservation getAdm()
        {
            if (adm == null)
            {
                adm = new Adm_Reservation();
            }
            return adm;
        }

        public Adm_Reservation Get()
        {
            if (adm == null)
            {
                adm = new Adm_Reservation();
            }
            return adm;
        }

        public void Registro(string name, DateTime dateandTime, int people, string location, string suggestion)
        {
            Reservation obj = new Reservation(name, dateandTime, people, location, suggestion);
            lisReservation.Add(obj);
        }
    }
}
