namespace _08.MilitaryElite.Factories
{
    using Models;

    public class CommandoFactory
    {
        public Commando CreateCommando(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var salary = decimal.Parse(args[4]);
            var corps = args[5];

            var commando = new Commando(id,firstName,lastName,salary,corps);
            return commando;
        }
    }
}
