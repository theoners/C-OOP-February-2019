namespace _03.BarrackWars_ANewFactory.Contracts
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}
