namespace _04.OnlineRadioDatabase.Exceptions
{
    using System;

    public class InvalidSongMinutesException:Exception
    {
        public override string Message =>"Song minutes should be between 0 and 14.";
    }
}
