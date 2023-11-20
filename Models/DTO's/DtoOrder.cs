using System;
using System.Collections.Generic;

namespace WebGoatCore.Models
{

    class DtoOrder
    {
        public int ShipVia {get; set;}
        public string ShipName {get; set;}
        public string ShipAddress {get; set;}
        public string ShipCity {get; set;}
        public string ShipRegion {get; set;}
        public string ShipPostalCode {get; set;}
        public string ShipCountry {get; set;}
        public IList<OrderDetail> OrderDetails {get; set;}
        public string CustomerId {get; set;}
        public DateTime OrderDate {get; set;}
        public DateTime RequiredDate {get; set;}
        public decimal Freight {get; set;}
        public int EmployeeId {get; set;}

      
    }


}