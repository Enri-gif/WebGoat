using System;

namespace WebGoatCore.Models
{

    public class Order_ShipVia
    {

        private int _ShipVia;

        public Order_ShipVia(int ShipVia)
        {
            ShipViaIsValid(ShipVia);
            _ShipVia = ShipVia;
            
        }
         public int getShipVia()
        {
            return _ShipVia;

        }
        private void ShipViaIsValid(int ShipVia)
        {
            if (ShipVia < 1 || ShipVia > 100)
            {
                throw new ArgumentException("Order Number is incorrect");

            }
    


        }

    }




}