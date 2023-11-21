using System;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{

    public class Order_CustomerId
    {

        private string _CustomerId;

        public Order_CustomerId(string CustomerId)
        {
            OrderIsValid(CustomerId);
            _CustomerId = CustomerId;
            
        }
         public string getCustomerId()
        {
            return _CustomerId;

        }
        private void OrderIsValid(string CustomerId)
        {
            if (CustomerId.Length < 5 || CustomerId.Length > 100)
            {
                throw new ArgumentException("Customer ID is not a Valid Lenght");

            }
            if (string.IsNullOrEmpty(CustomerId))
            {
                 throw new ArgumentException("CustomerId is Empty or null");

            }

            string RegexString = @"^[^';-]*$";
            bool Match = Regex.IsMatch(CustomerId, RegexString);
            if (!Match)
            {
                throw new ArgumentException("Please dont use: @^[^';-]*$");
            }
    


        }

    }




}