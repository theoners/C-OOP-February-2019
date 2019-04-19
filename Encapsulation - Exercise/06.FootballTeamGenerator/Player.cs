namespace _06.FootballTeamGenerator
{
    using System;

    public class Player
   {
       private string name;

       private Stat Stats { get; set; }

       public double AverageStat => this.Stats.TotalStat()/5.0;

       public Player(string name , Stat stats)
       {
           this.Name = name;
           this.Stats = stats;
       }

       public string Name
       {
           get => this.name;
          private set
           {
               if (string.IsNullOrEmpty(value))
               {
                   throw new ArgumentException("A name should not be empty.");
               }

               this.name = value;
           }
       }

   }
}
