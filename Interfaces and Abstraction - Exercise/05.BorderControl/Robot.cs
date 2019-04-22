namespace _05.BorderControl
{
   public class Robot:Entered
   {
       private string model;

       public Robot(string model,string id) : base(id)
       {
           this.model = model;
       }
   }
}
