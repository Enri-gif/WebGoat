using System;

namespace WebGoatCore.Models
{

    public class Order_EmployeeId
    {

        private int _EmployeeId;

        public Order_EmployeeId(int EmployeeId)
        {
            EmployeeIdIsValid(EmployeeId);
            _EmployeeId = EmployeeId;
            
        }
         public int getEmployeeId()
        {
            return _EmployeeId;

        }
        private void EmployeeIdIsValid(int EmployeeId)
        {
            if (EmployeeId < 1 || EmployeeId > 100)
            {
                throw new ArgumentException("EmployeeId is incorrect");

            }
    


        }

    }




}