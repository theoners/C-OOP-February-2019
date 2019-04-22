namespace _09.CollectionHierarchy.Models
{
    public class AddCollection : Collection
    {
        public override int AddItem(string item)
        {
            this.Data.Add(item);
            return Data.Count - 1;
        }
    }
}
