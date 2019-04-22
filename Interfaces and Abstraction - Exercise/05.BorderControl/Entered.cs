namespace _05.BorderControl
{
    public abstract  class Entered
    {
        protected Entered(string id)
        {
            Id = id;
        }

        public string Id { get;  private set; }

    }
}
