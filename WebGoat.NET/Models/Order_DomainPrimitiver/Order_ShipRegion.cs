using System;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{

    public class Order_ShipRegion
    {

        private string _ShipRegion;

        public Order_ShipRegion(string ShipRegion)
        {
            ShipRegionIsValid(ShipRegion);
            _ShipRegion = ShipRegion;
            
        }
         public string getShipRegion()
        {
            return _ShipRegion;

        }
        private void ShipRegionIsValid(string ShipRegion)
        {
            if (ShipRegion.Length < 5 || ShipRegion.Length > 100)
            {
                throw new ArgumentException("Customer ID is not a Valid Lenght");

            }
            string RegexString = @"^[^';-]*$";
            bool Match = Regex.IsMatch(ShipRegion, RegexString);
            if (!Match)
            {
                throw new ArgumentException("Please dont use: @^[^';-]*$");
            }
    


        }

    }




}