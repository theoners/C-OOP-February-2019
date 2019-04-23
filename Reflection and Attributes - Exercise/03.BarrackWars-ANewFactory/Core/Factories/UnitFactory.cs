

namespace _03.BarrackWars_ANewFactory.Core.Factories
{
    using Models.Units;
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var type = Type.GetType($"{typeof(Unit).Namespace}.{unitType}");
            var unit = (Unit)Activator.CreateInstance(type,new object[]{});

            return unit;
        }
    }
}
