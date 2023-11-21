using System;
using System.Configuration;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyModel.Resolution;

namespace WebGoatCore.Models
{

    public class Order_OrderDate
    {

        private DateTime _OrderDate;

        public Order_OrderDate(DateTime OrderDate)
        {
            OrderIsValid(OrderDate);
            _OrderDate = OrderDate;
            
        }
         public DateTime getOrderDate()
        {
            return _OrderDate;

        }
        private void OrderIsValid(DateTime OrderDate)
        {   
            DateTime CompanyWhenItWasMade = new DateTime(2010,10,25);
            if (OrderDate < CompanyWhenItWasMade)
            {
                throw new ArgumentException("invalid Date");
            }



        }

    }
}