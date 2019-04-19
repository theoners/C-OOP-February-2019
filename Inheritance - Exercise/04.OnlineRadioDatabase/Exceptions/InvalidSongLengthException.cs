namespace _04.OnlineRadioDatabase.Exceptions
{
    using System;

    public class InvalidSongLengthException:Exception
    {
        public override string Message => "Invalid song length.";
    }
}
