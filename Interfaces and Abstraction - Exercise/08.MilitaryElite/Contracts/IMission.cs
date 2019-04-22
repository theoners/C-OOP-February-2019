namespace _08.MilitaryElite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        void CompleteMission();
    }
}
