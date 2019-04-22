namespace _08.MilitaryElite.Factories
{
    using Models;
    public class MissionFactory
    {
        public Mission CreateMission(string codeName, string state)
        {
            return new Mission(codeName,state);
        }
    }
}
