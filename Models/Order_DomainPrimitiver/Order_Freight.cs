using System;

namespace WebGoatCore.Models
{

    public class Order_Freight
    {

        private decimal _Freight;

        public Order_Freight(decimal Freight)
        {
            FreightIsValid(Freight);
            _Freight = Freight;
            
        }
         public decimal getFreight()
        {
            return _Freight;

        }
        private void FreightIsValid(decimal Freight)
        {
            if (Freight < 1 || Freight > 100)
            {
                throw new ArgumentException("Freight Number is incorrect");

            }
    


        }

    }




}