using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        private string name;
        private DateTime dateandTime;
        private int people;
        private string location;
        private string suggestion;

        public Reservation(string name, DateTime dateandTime, int people, string location, string suggestion)
        {
            this.name = name;
            this.dateandTime = dateandTime;
            this.people = people;
            this.location = location;
            this.suggestion = suggestion;
        }

        public Reservation()
        {
        }

        public string Name { get => name; set => name = value; }
        public DateTime DateandTime { get => dateandTime; set => dateandTime = value; }
        public int People { get => people; set => people = value; }
        public string Location { get => location; set => location = value; }
        public string Suggestion { get => suggestion; set => suggestion = value; }
    }
}
