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
        
        private static Adm_User adm = null;
        DataBase usuario = new DataBase();
        String actual_user;
        
        //Usuario Default
        public Adm_User()
        {
            //User a = new User("0987654321", "a", "a", "0999999999", "email", "city ", "direction", "1111");
            //lisClient.Add(a);
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
            foreach (var a in usuario.list_user())
            {
                if (a.Ci == ci)
                {
                    if (a.Password == password)
                    {
                        actual_user = ci;
                        return true;
                    }
                }
            }
            return false;
        }

        public string GetActual_User()
        {
            return actual_user;
        }

        public string Obtener_Usuario(String ci, String opcion)
        {
            foreach (var a in usuario.list_user())
            {
                if (a.Ci == ci)
                {
                    switch (opcion)
                    {
                        case "1":
                            return a.Ci;

                        case "2":
                            return a.Name;

                        case "3":
                            return a.LastName;

                        case "4":
                            return a.Phone;

                        case "5":
                            return a.Email;

                        case "6":
                            return a.City;

                        case "7":
                            return a.Direction;

                        case "8":
                            return a.Password;

                        default:
                            return "No se cargaron los datos";

                    }
    
                }
                
                    
            }
            return "Cedula no encontrada";

        }

        public string NameClient(string ci)
        {
            foreach (User a in usuario.list_user())
            {
                if (ci == a.Ci)
                {
                    return a.Ci;
                }
            }
            MessageBox.Show("Usuario no registrado, Se procedera hacer la orden como consumidor final");
            return "0000000000";
        }

        public bool UsuerRepeat(string ci)
        {
            foreach (User a in usuario.list_user())
            {
                if (ci == a.Ci)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Registro(string ci, string name, string lastName, string phone, string email, string city, string direction, string password)
        {
            List<User> lisClient = new List<User>();
            User obj = new User(ci, name, lastName, phone, email, city, direction, password);
            if (!UsuerRepeat(ci))
            {
                lisClient.Add(obj);
                usuario.insert_user(lisClient);
                return true;
            }
            return false;
        }

        public bool Update_user(string ci, string name, string lastName, string phone, string email, string city, string direction, string password)
        {
            List<User> lisClient = new List<User>();
            User obj = new User(ci, name, lastName, phone, email, city, direction, password);
                lisClient.Add(obj);
                usuario.update_User(lisClient);
                return true;
        }

        public void deleteData(int eliminar)
        {
            List<User> lisClient = new List<User>();
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
