using System;

namespace WebGoatCore.Models
{

    public class OrderDetail_Quantity
    {

        private short _Quantity;

        public OrderDetail_Quantity(short Quantity)
        {
            QuantityIsValid(Quantity);
            _Quantity = Quantity;
            
        }
         public short getQuantity()
        {
            return _Quantity;

        }
        private void QuantityIsValid(short Quantity)
        {
            if (Quantity < 1 || Quantity > 254)
            {
                throw new ArgumentException("Quantity Number is incorrect");

            }
    


        }

    }




}