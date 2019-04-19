namespace _04.OnlineRadioDatabase.Exceptions
{
    using System;

   public class InvalidSongSecondsException:Exception
    {
        public override string Message => "Song seconds should be between 0 and 59.";
    }
}
