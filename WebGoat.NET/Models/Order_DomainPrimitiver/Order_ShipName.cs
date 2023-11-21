using System;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{

    public class Order_ShipName
    {

        private string _ShipName;

        public Order_ShipName(string ShipName)
        {
            ShipNameIsValid(ShipName);
            _ShipName = ShipName;
            
        }
         public string getShipName()
        {
            return _ShipName;

        }
        private void ShipNameIsValid(string ShipName)
        {
            if (ShipName.Length < 5 || ShipName.Length > 100)
            {
                throw new ArgumentException("Customer ID is not a Valid Lenght");

            }
            string RegexString = @"^[^';-]*$";
            bool Match = Regex.IsMatch(ShipName, RegexString);
            if (!Match)
            {
                throw new ArgumentException("Please dont use: @^[^';-]*$");
            }
    


        }

    }




}