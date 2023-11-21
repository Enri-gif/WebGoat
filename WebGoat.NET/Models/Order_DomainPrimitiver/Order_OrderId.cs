using System;

namespace WebGoatCore.Models
{

    public class Order_OrderId
    {

        private int _OrderId;

        public Order_OrderId(int OrderId)
        {
            OrderIsValid(OrderId);
            _OrderId = OrderId;
            
        }
         public int getOrderId()
        {
            return _OrderId;

        }
        private void OrderIsValid(int OrderId)
        {
            if (OrderId < 1 || OrderId > 100)
            {
                throw new ArgumentException("Order Number is incorrect");

            }
    


        }

    }




}