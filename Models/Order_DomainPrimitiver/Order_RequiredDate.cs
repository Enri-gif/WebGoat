using System;
using System.Configuration;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyModel.Resolution;

namespace WebGoatCore.Models
{

    public class Order_RequiredDate
    {

        private DateTime _RequiredDate;

        public Order_RequiredDate(DateTime RequiredDate)
        {
            OrderIsValid(RequiredDate);
            _RequiredDate = RequiredDate;
            
        }
         public DateTime getRequiredDate()
        {
            return _RequiredDate;

        }
        private void OrderIsValid(DateTime RequiredDate)
        {   
            DateTime CompanyWhenItWasMade = new DateTime(2010,10,25);
            if (RequiredDate < CompanyWhenItWasMade)
            {
                throw new ArgumentException("invalid Date");
            }
       


        }

    }
}