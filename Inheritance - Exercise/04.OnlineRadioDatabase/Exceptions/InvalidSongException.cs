namespace _04.OnlineRadioDatabase.Exceptions
{
    using System;

    public class InvalidSongException:Exception
    {
        public override string Message => "Invalid song.";
    }
}
