namespace _04.OnlineRadioDatabase.Exceptions
{
    using System;

    public class InvalidArtistNameException:Exception
    {
        public override string Message => "Artist name should be between 3 and 20 symbols.";
    }
}
