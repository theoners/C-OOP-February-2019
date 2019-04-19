namespace CustomRandomList
{
    using System;

    using System.Collections.Generic;
    public class RandomList:List<string>
    {
        public string RandomString()
        {
            var randomIndex = new Random();
            var index = randomIndex.Next(0, this.Count);
            var randomString = this[index];
            this.Remove(randomString);
            return randomString;
        }
    }
}
