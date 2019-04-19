namespace _05.Mordor_sCruelPlan.Moods
{
   public class Mood
   {
       private int happiness;

        public Mood(int happiness)
        {
            this.happiness = happiness;
        }

        public override string ToString()
        {
            string result;
           if (happiness<-5)
           {
               result = "Angry";
           }
            else if (happiness <= 0)
           {
               result = "Sad";
           }
           else if (happiness <= 15)
           {
               result = "Happy";
           }
           else 
           {
               result = "JavaScript";
           }

            return result;
        }
   }
}
