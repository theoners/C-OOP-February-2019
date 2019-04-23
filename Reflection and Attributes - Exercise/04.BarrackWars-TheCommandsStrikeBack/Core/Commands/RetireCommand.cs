namespace _04.BarrackWars_TheCommandsStrikeBack.Core.Commands
{
    using Contracts;

    public class RetireCommand:Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unit = this.Data[1];
            this.Repository.RemoveUnit(unit);
            return $"{unit} retired!";
        }
    }
}
