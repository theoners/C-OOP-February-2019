namespace _02.BookShop
{
    using System.Text;

    using System;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get => this.title;
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get => this.author;

            set
            {
                var authorSecondName = value.Split()[1];
                if (char.IsDigit(authorSecondName[0]))
                {
                  throw  new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get => this.price;

            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var bookInfo = new StringBuilder();
            bookInfo.AppendLine($"Type: {this.GetType().Name}");
            bookInfo.AppendLine($"Title: {this.Title}");
            bookInfo.AppendLine($"Author: {this.Author}");
            bookInfo.Append($"Price: {this.Price:F2}");

            return bookInfo.ToString();
        }
    }
}
