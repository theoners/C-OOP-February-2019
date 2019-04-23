namespace _04.BarrackWars_TheCommandsStrikeBack
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;

   public class AppEntryPoint
    {
        public static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
