using _09.CollectionHierarchy.Contracts;

namespace _09.CollectionHierarchy.Models
{
    public class AddRemoveCollection:Collection,IRemoveCollection
    {
        public virtual string Remove()
        {
            var currentItem = this.Data[this.Data.Count - 1];
            this.Data.RemoveAt(this.Data.Count-1);
            return currentItem;
        }
       
    }
}
