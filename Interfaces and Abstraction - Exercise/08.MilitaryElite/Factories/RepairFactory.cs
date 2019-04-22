namespace _08.MilitaryElite.Factories
{
    using Models;

    public class RepairFactory
    {
        public Repair CreateRepair(string partName, int hoursWorked)
        {
            return new Repair(partName,hoursWorked);
        }
    }
}
