namespace PersonsInfo
{
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam= new List<Person>();
            this.reserveTeam= new List<Person>();
        }

        public List<Person> FirstTeam => this.firstTeam.AsReadOnly().ToList();

        public List<Person> ReserveTeam => this.reserveTeam.AsReadOnly().ToList();

        public void AddPlayer(Person person)
        {
            if (person.Age<40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

    }
}
