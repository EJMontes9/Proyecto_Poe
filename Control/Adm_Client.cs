﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class Adm_Client
    {
        List<Client> LisClient = new List<Client>();
        private static Client cli = null;

        public Adm_Client()
        {
            Client a = new Client("0987654321","a","a","0999999999","email", "city ", "direction", "1111");
            LisClient.Add(a);
        }

        public Boolean IniciarSesion(String ci, String password)
        {
            foreach (var a in LisClient)
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

        

    }
}
