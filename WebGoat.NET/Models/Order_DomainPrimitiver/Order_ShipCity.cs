using System;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{

    public class Order_ShipCity
    {

        private string _ShipCity;

        public Order_ShipCity(string ShipCity)
        {
            ShipCityIsValid(ShipCity);
            _ShipCity = ShipCity;
            
        }
         public string getShipCity()
        {
            return _ShipCity;

        }
        private void ShipCityIsValid(string ShipCity)
        {
            if (ShipCity.Length < 5 || ShipCity.Length > 100)
            {
                throw new ArgumentException("Customer ID is not a Valid Lenght");

            }
            string RegexString = @"^[^';-]*$";
            bool Match = Regex.IsMatch(ShipCity, RegexString);
            if (!Match)
            {
                throw new ArgumentException("Please dont use: @^[^';-]*$");
            }
    


        }

    }




}