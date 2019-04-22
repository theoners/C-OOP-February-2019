namespace _03.Ferrari
{
    public interface ICar
    {
        string Model { get; }

        string Driver { get; set; }

        string Gas();

        string Brakes();

    }
}
