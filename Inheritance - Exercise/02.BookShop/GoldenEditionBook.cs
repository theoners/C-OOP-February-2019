namespace _02.BookShop
{
   public class GoldenEditionBook:Book
   {
        private const decimal percent = 1.3M;
       private decimal price;
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
        }

        public override decimal Price
        {
            get => base.Price*percent;
        }
    }
}
