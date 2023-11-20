using System;

namespace WebGoatCore.Models
{

    public class OrderDetail_ProductId
    {

        private int _ProductId;

        public OrderDetail_ProductId(int ProductId)
        {
            ProductIdIsValid(ProductId);
            _ProductId = ProductId;
            
        }
         public int getProductId()
        {
            return _ProductId;

        }
        private void ProductIdIsValid(int ProductId)
        {
            if (ProductId < 1 || ProductId > 100)
            {
                throw new ArgumentException("ProductId Number is incorrect");

            }
    


        }

    }




}