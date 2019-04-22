namespace _04.Telephony
{
    using System;
    using System.Linq;

    public class SmartPhone : Icall, IBrowse
    {
        private string phoneNumber;

        private string webAddress;

        public string PhoneNumber
        {
            get => this.phoneNumber;
            set
            {
                if (CheckPhoneNumber(value))
                {
                    throw new ArgumentException("Invalid number!");
                }

                this.phoneNumber = value;
            }
        }

        public string WebAddress
        {
            get => this.webAddress;
            set
            {
                if (CheckWebAddress(value))
                {
                    throw new ArgumentException("Invalid URL!");
                }

                this.webAddress = value;
            }
        }

        private static bool CheckWebAddress(string value)
        {
            var symbol = value.FirstOrDefault(char.IsDigit);

            return symbol != '\0';
        }

        private static bool CheckPhoneNumber(string value)
        {
            var symbol = value.FirstOrDefault(x => !char.IsDigit(x));

            return symbol != '\0';
        }

        public string Call()
        {
            return $"Calling... {this.phoneNumber}";
        }

        public string Browse()
        {
            return $"Browsing: {this.WebAddress}!";
        }
    }
}
