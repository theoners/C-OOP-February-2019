namespace _4.HotelReservation
{
    public class PriceCalculator
    {
        private double pricePerDay;
        private int numberOfDays;
        private Season season;
        private DiscountType discount;
        

        public PriceCalculator(double pricePerDay, int numberOfDays, Season season, DiscountType discount)
        {
            this.pricePerDay = pricePerDay;
            this.numberOfDays = numberOfDays;
            this.season = season;
            this.discount = discount;
        }

        public double CalculatePrice()
        {
            var price = (this.numberOfDays * this.pricePerDay * (int)this.season);
            price -= price * ((double)this.discount / 100);

            return price;
        }
    }
}
