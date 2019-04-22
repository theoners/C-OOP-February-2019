using _08.MilitaryElite.Models;

namespace _08.MilitaryElite.Factories
{

    public class SpyFactory
    {
        public Spy CreateSpy(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var codeNumber = int.Parse(args[4]);
            return new Spy(id,firstName,lastName,codeNumber);
        }
    }
}
