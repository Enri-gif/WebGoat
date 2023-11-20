using System;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{

    public class Order_ShipPostalCode
    {

        private string _ShipPostalCode;

        public Order_ShipPostalCode(string ShipPostalCode)
        {
            ShipPostalCodeIsValid(ShipPostalCode);
            _ShipPostalCode = ShipPostalCode;
            
        }
         public string getShipPostalCode()
        {
            return _ShipPostalCode;

        }
        private void ShipPostalCodeIsValid(string ShipPostalCode)
        {
            if (ShipPostalCode.Length < 5 || ShipPostalCode.Length > 100)
            {
                throw new ArgumentException("Customer ID is not a Valid Lenght");

            }
            string RegexString = @"^[^';-]*$";
            bool Match = Regex.IsMatch(ShipPostalCode, RegexString);
            if (!Match)
            {
                throw new ArgumentException("Please dont use: @^[^';-]*$");
            }
    


        }

    }




}