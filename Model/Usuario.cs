using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario:Persona
    {
        private string password;


        public Usuario()
        {
        }

        public Usuario(string ci, string name, string lastName, string phone, string email, string city, string direction, string password) : base(ci, name, lastName, phone, email, city, direction)
        {
            this.password = password;
        }

        public string Password { get => password; set => password = value; }
    }
}
