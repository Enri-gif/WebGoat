using System;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{

    public class Order_ShipAddress
    {

        private string _ShipAddress;

        public Order_ShipAddress(string ShipAddress)
        {
            ShipAddressIsValid(ShipAddress);
            _ShipAddress = ShipAddress;
            
        }
         public string getShipAddress()
        {
            return _ShipAddress;

        }
        private void ShipAddressIsValid(string ShipAddress)
        {
            if (ShipAddress.Length < 5 || ShipAddress.Length > 100)
            {
                throw new ArgumentException("Customer ID is not a Valid Lenght");

            }
            string RegexString = @"^[^';-]*$";
            bool Match = Regex.IsMatch(ShipAddress, RegexString);
            if (!Match)
            {
                throw new ArgumentException("Please dont use: @^[^';-]*$");
            }
    


        }

    }




}