namespace CustomStack
{
    using System.Linq;
    using System.Collections.Generic;

    public class StackOfStrings:Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Any();
        }

       public Stack<string> AddRange(params string[] inputs)
       {
           foreach (var input in inputs)
           {
               this.Push(input);
           }

           return this;
       }
    }
}
