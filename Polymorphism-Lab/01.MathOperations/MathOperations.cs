namespace Operations
{
   public class MathOperations
    {

        public int Add(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            return result;
        }

        public double Add(double firstNumber, double secondNumber, double thirdNumber)
        {
            var result = firstNumber + secondNumber + thirdNumber;
            return result;
        }

        public decimal Add(decimal firstNumber, decimal secondNumber, decimal thirdNumber)
        {
            var result = firstNumber + secondNumber + thirdNumber;
            return result;
        }
    }
}
