using System;
using System.Configuration;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyModel.Resolution;

namespace WebGoatCore.Models
{

    public class Order_ShippedDate
    {

        private DateTime _ShippedDate;

        public Order_ShippedDate(DateTime ShippedDate)
        {
            OrderIsValid(ShippedDate);
            _ShippedDate = ShippedDate;
            
        }
         public DateTime getShippedDate()
        {
            return _ShippedDate;

        }
        private void OrderIsValid(DateTime ShippedDate)
        {   
            DateTime CompanyWhenItWasMade = new DateTime(2010,10,25);
            if (ShippedDate < CompanyWhenItWasMade)
            {
                throw new ArgumentException("invalid Date");
            }



        }

    }
}