namespace _04.BarrackWars_TheCommandsStrikeBack.Core.Factories
{
    using System;
    using Contracts;
    using Models.Units;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var type = Type.GetType($"{typeof(Unit).Namespace}.{unitType}");
            var unit = (Unit)Activator.CreateInstance(type);

            return unit;
        }
    }
}
