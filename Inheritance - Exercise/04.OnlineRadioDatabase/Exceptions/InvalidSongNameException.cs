namespace _04.OnlineRadioDatabase.Exceptions
{
    using System;

    public class InvalidSongNameException:Exception
    {
        public override string Message => "Song name should be between 3 and 30 symbols.";
    }
}
