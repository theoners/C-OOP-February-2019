using _08.MilitaryElite.Models;

namespace _08.MilitaryElite.Factories
{
    public class LieutenantGeneralFactory
    {
        public LieutenantGeneral CreateLieutenantGeneral(string[] args)
        {
            var id = int.Parse(args[1]);
            var firstName = args[2];
            var lastName = args[3];
            var salary = decimal.Parse(args[4]);

            return new LieutenantGeneral(id,firstName,lastName,salary);
        }
    }
}
