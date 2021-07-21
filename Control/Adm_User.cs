using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class Adm_User
    {
        List<Usuario> lisClient = new List<Usuario>();
        private static Adm_User adm = null;
        public Adm_User()
        {
            Usuario a = new Usuario("0987654321","a","a","0999999999","email", "city ", "direction", "1111");
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
            foreach (Usuario a in lisClient)
            {
                if (ci == a.Ci)
                {
                    return a.Ci;
                }
            }
            return "0000000000";
        }

    }
}
