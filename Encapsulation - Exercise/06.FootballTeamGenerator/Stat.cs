namespace _06.FootballTeamGenerator
{
    using System;

    public class Stat
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        private int Endurance
        {
            get => this.endurance;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
                }

                this.endurance = value;
            }
        }

        private int Sprint
        {
            get => this.sprint;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100.");
                }

                this.sprint = value;
            }
        }

        private int Dribble
        {
            get => this.dribble;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Dribble)} should be between 0 and 100.");
                }

                this.dribble = value;
            }
        }

        private int Passing
        {
            get => this.passing;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100.");
                }

                this.passing = value;
            }
        }

        private int Shooting
        {
            get => this.shooting;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100.");
                }

                this.shooting = value;
            }
        }

        public int TotalStat()
        {
            var totalStats = dribble + shooting + passing + endurance + sprint;

            return totalStats;
        }
       
    }
}
