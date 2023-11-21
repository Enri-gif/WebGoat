using System;

namespace WebGoatCore.Models
{

    public class Order_Total
    {

        private decimal _Total;

        public Order_Total(decimal Total)
        {
            TotalIsValid(Total);
            _Total = Total;
            
        }
         public decimal getTotal()
        {
            return _Total;

        }
        private void TotalIsValid(decimal Total)
        {
            if (Total < 1 || Total > 10000)
            {
                throw new ArgumentException("Total Number is incorrect");

            }
    


        }

    }




}