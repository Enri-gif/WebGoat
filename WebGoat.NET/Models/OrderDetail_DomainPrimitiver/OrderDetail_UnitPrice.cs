using System;

namespace WebGoatCore.Models
{

    public class OrderDetail_UnitePrice
    {

        private double _UnitePrice;

        public OrderDetail_UnitePrice(double UnitePrice)
        {
            UnitePriceIsValid(UnitePrice);
            _UnitePrice = UnitePrice;
            
        }
         public double getUnitePrice()
        {
            return _UnitePrice;

        }
        private void UnitePriceIsValid(double UnitePrice)
        {
            if (UnitePrice < 1 || UnitePrice > 100)
            {
                throw new ArgumentException("UnitePrice Number is incorrect");

            }
    


        }

    }




}