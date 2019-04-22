namespace _08.MilitaryElite.Factories
{
    using Models;

    public class PrivateFactory
    {
        public Private CreatePrivate(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var salary = decimal.Parse(args[4]);

            var currentPrivate = new Private(id, firstName, lastName, salary);

            return currentPrivate;

        }
    }
}
