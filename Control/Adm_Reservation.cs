using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Reservation
    {
        List<Reservation> listreservacion = new List<Reservation>();
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
            listreservacion.Add(obj);
        }

        public void FillData(DataGridView DGPresentar)
        {
            foreach (var a in listreservacion)
            {
                DGPresentar.Rows.Add(a.Name, a.DateandTime, a.People, a.Location, a.Suggestion);
            }
        }

        public void Eliminar(int eliminar)
        {
            listreservacion.RemoveAt(eliminar);
        }
    }
}
