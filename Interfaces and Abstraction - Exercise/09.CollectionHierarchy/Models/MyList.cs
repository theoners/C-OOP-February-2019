namespace _09.CollectionHierarchy.Models
{
    using Contracts;

    public class MyList:AddRemoveCollection,IMyList
    {
        public override string Remove()
        {
            var currentItem = this.Data[0];
            this.Data.RemoveAt(0);
            return currentItem;
        }
        
        public string Used()
        {
            return string.Join(" ", this.Data);
        }
    }
}
