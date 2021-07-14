using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Persona
    {
        private string ci;
        private string name;
        private string lastName;
        private string phone;
        private string email;
        private string city;
        private string direction;

        public Persona(string ci, string name, string lastName, string phone, string email, string city, string direction)
        {
            this.ci = ci;
            this.name = name;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.city = city;
            this.direction = direction;
        }

        public Persona() { }

        public string Ci { get => ci; set => ci = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string City { get => city; set => city = value; }
        public string Direction { get => direction; set => direction = value; }
    }
}
