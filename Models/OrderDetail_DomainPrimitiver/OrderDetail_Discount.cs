using System;

namespace WebGoatCore.Models
{

    public class OrderDetail_Discount
    {

        private float _Discount;

        public OrderDetail_Discount(float Discount)
        {
            DiscountIsValid(Discount);
            _Discount = Discount;
            
        }
         public float getDiscount()
        {
            return _Discount;

        }
        private void DiscountIsValid(float Discount)
        {
            if (Discount < 1 || Discount > 10000)
            {
                throw new ArgumentException("Discount Number is incorrect");

            }
    


        }

    }




}