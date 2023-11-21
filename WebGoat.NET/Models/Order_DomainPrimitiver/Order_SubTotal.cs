using System;

namespace WebGoatCore.Models
{

    public class Order_SubTotal
    {

        private decimal _SubTotal;

        public Order_SubTotal(decimal SubTotal)
        {
            SubTotalIsValid(SubTotal);
            _SubTotal = SubTotal;
            
        }
         public decimal getSubTotal()
        {
            return _SubTotal;

        }
        private void SubTotalIsValid(decimal SubTotal)
        {
            if (SubTotal < 1 || SubTotal > 10000)
            {
                throw new ArgumentException("SubTotal Number is incorrect");

            }
    


        }

    }




}