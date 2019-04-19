namespace _06.Animals
{
    using System;

    public class InvalidInputException:Exception
    {
        public override string Message => "Invalid input!";
    }
}
