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
        
        private static Adm_Reservation adm = null;
        DataBase reserva = new DataBase();

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
            List<Reservation> listreservacion = new List<Reservation>();
            Reservation obj = new Reservation(name, dateandTime, people, location, suggestion);
            listreservacion.Add(obj);
            reserva.insert_reservation(listreservacion);
        }

        public void FillData(DataGridView DGPresentar)
        {
            foreach (var a in reserva.list_reservation())
            {
                DGPresentar.Rows.Add(a.Name, a.DateandTime, a.People, a.Location, a.Suggestion);
            }
        }

        public void Eliminar(string eliminar)
        {
            MessageBox.Show(reserva.delete_reserv(eliminar));
        }
    }
}
