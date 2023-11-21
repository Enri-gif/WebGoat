using System;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{

    public class Order_ShipCounty
    {

        private string _ShipCounty;

        public Order_ShipCounty(string ShipCounty)
        {
            ShipCountyIsValid(ShipCounty);
            _ShipCounty = ShipCounty;
            
        }
         public string getShipCounty()
        {
            return _ShipCounty;

        }
        private void ShipCountyIsValid(string ShipCounty)
        {
            if (ShipCounty.Length < 5 || ShipCounty.Length > 100)
            {
                throw new ArgumentException("Customer ID is not a Valid Lenght");

            }
            string RegexString = @"^[^';-]*$";
            bool Match = Regex.IsMatch(ShipCounty, RegexString);
            if (!Match)
            {
                throw new ArgumentException("Please dont use: @^[^';-]*$");
            }
    


        }

    }




}