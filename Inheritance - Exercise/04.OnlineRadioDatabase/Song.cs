namespace _04.OnlineRadioDatabase
{
    using Exceptions;

    public class Song
    {

        public Song(string artistName, string songName, string songLength)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongLength = songLength;
        }

        private string SongLength
        {
            set
            {
                var lengthArgs = value.Split(":");
                if (lengthArgs.Length != 2)
                {
                    throw new InvalidSongLengthException();
                }

                if (!(int.TryParse(lengthArgs[0], out var minutes) && int.TryParse(lengthArgs[1], out var seconds)))
                {
                    throw new InvalidSongLengthException();
                }

                SetMinutesAndSeconds(minutes, seconds);
            }

        }

        private string ArtistName
        {
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }

            }
        }

        private string SongName
        {
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }

            }
        }

        public int SongMinutes { get; private set; }

        public int SongSeconds { get; private set; }

        private void SetMinutesAndSeconds(int minutes, int seconds)
        {
            if (minutes < 0 || minutes > 14)
            {
                throw new InvalidSongMinutesException();
            }

            if (seconds < 0 || seconds > 59)
            {
                throw new InvalidSongSecondsException();
            }

            this.SongMinutes = minutes;
            this.SongSeconds = seconds;
        }
    }
}
