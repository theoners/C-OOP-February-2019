namespace _04.Telephony
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split();
            var webAddress = Console.ReadLine().Split();

            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    var smartPhone = new SmartPhone { PhoneNumber = phoneNumber };
                    Console.WriteLine(smartPhone.Call());
                }

                catch (ArgumentException message)
                {
                    Console.WriteLine(message.Message);
                }
            }

            foreach (var address in webAddress)
            {
                try
                {
                    var smartPhone = new SmartPhone { WebAddress = address };
                    Console.WriteLine(smartPhone.Browse());
                }

                catch (ArgumentException message)
                {
                    Console.WriteLine(message.Message);
                }
            }
           
        }
    }
}
