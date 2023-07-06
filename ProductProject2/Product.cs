using System.Text.RegularExpressions;

namespace ProductProject2
{
    public class Product
    {
        private const int MIN_PRODUCTNAME_LENGTH = 3;
        private const string EMAIL_CORRECT_PATTERN = @"/[a-zA-Z0-9.-]+@[a-z]{2-3}/";
        private const string MOBILE_PHONE_CORRECT_PATTERN = @"{4}[0-9]?-{3}[0-9]?-([1-9]2|[1-9";
        private const string HOME_PHONE_CORRECT_PATTERN = @"";


        public string Name { get; private set; }
        public DateTime ProduceDate { get; private set; }
        public bool IsAvailable { get; private set; }
        public string ManufactureEmail { get; private set; }
        public string ManufacturePhone { get; private set; }


        public Product(string name, DateTime produceDate, bool isAvailable, string mfEmail, string mfPhone)
        {
            

            Name = name;
            ProduceDate = produceDate;
            IsAvailable = isAvailable;
            ManufactureEmail = mfEmail;
            ManufacturePhone = mfPhone;

        }

        #region Validation
        

        #endregion
    }
}