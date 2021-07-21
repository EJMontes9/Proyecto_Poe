using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class Adm_User
    {
        List<User> lisClient = new List<User>();
        private static Adm_User adm = null;
        public Adm_User()
        {
            User a = new User("0987654321", "a", "a", "0999999999", "email", "city ", "direction", "1111");
            lisClient.Add(a);
        }

        public static Adm_User getAdm()
        {
            if (adm == null)
            {
                adm = new Adm_User();
            }
            return adm;
        }

        public Adm_User Get()
        {
            if (adm == null)
            {
                adm = new Adm_User();
            }
            return adm;
        }

        public Boolean IniciarSesion(String ci, String password)
        {
            foreach (var a in lisClient)
            {
                if (a.Ci == ci)
                {
                    if (a.Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string NameClient(string ci)
        {
            foreach (User a in lisClient)
            {
                if (ci == a.Ci)
                {
                    return a.Ci;
                }
            }
            return "0000000000";
        }

        public void Registro(string ci, string name, string lastName, string phone, string email, string city, string direction, string password)
        {
            User obj = new User(ci, name, lastName, phone, email, city, direction, password);
            lisClient.Add(obj);
        }

        public void deleteData(int eliminar)
        {
            lisClient.RemoveAt(eliminar);
        }

        /*public void FillData(DataGridView DGPresentar)
        {
            foreach (var a in lisClient)
            {
                DGPresentar.Rows.Add(a.Ci,a.Name,a.LastName,a.Phone,a.Email,a.City,a.Direction,a.Password);
            }
        }*/
    }
}
