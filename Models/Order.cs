using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class Order
    {

        public Order( Order_OrderId OrderId,
         Order_CustomerId CustomerId,
          Order_EmployeeId? EmployeeId,
           Order_OrderDate OrderDate,
            Order_RequiredDate RequiredDate,
             Order_ShippedDate? ShippedDate,
            Order_ShipVia ShipVia,
            decimal Freight,
            Order_ShipName? ShipName,
             Order_ShipAddress? ShipAddress,
            Order_ShipCity? ShipCity,
            Order_ShipRegion? ShipRegion,
            Order_ShipPostalCode? ShipPostalCode,
            Order_ShipCounty? ShipCountry,
            IList<OrderDetail> OrderDetails,
            Customer Customer,
            IList<OrderPayment> OrderPayments,
            Shipment? Shipment
             )
        {
            
            _OrderId = OrderId;
            _CustomerId = CustomerId;
            _EmployeeId = EmployeeId;
            _OrderDate = OrderDate;
            _RequiredDate = RequiredDate;
            _ShippedDate = ShippedDate;
            _ShipVia = ShipVia;
            _Freight = Freight;
            _ShipName = ShipName;
            _ShipAddress = ShipAddress;
            _ShipCity = ShipCity;
            _ShipRegion = ShipRegion;
            _ShipPostalCode = ShipPostalCode;
            _ShipCountry = ShipCountry;
            _OrderDetails = OrderDetails;
            _Customer = Customer;
            _OrderPayments = OrderPayments;
            _Shipment = Shipment;

            

        }
        private readonly Order_OrderId _OrderId;  //Done
        private readonly Order_CustomerId _CustomerId;  //Done
        private readonly Order_EmployeeId? _EmployeeId;  //Done 
        private readonly Order_OrderDate _OrderDate;  // Done
        private readonly Order_RequiredDate _RequiredDate;  // Done
        private readonly Order_ShippedDate? _ShippedDate;  // Done
        private readonly Order_ShipVia _ShipVia;  // Done
        private readonly decimal _Freight;  // Done
        private readonly Order_ShipName? _ShipName;  // Done
        private readonly Order_ShipAddress? _ShipAddress; // Done
        private readonly Order_ShipCity? _ShipCity;  // Done
        private readonly Order_ShipRegion? _ShipRegion;  // Done
        private readonly Order_ShipPostalCode? _ShipPostalCode;  // Done
        private readonly Order_ShipCounty? _ShipCountry;  // Done

        private readonly  IList<OrderDetail> _OrderDetails;
        private readonly  Customer _Customer; 
        private readonly  IList<OrderPayment> _OrderPayments;
        private readonly  Shipment? _Shipment;

        private  decimal _SubTotal => _OrderDetails.Sum(od => od.ExtendedPrice); // Done
       
        private  decimal Total => Math.Round(_SubTotal + _Freight, 2); // Done

        private  static string GetPackageTrackingUrl(string Carrier, string TrackingNumber)
        {
            string trackingUrl;
            Carrier = Carrier.ToLower();
            switch (Carrier)
            {
                case "fedex":
                case "federalexpress":
                case "federal express":
                    trackingUrl = string.Format("http://www.fedex.com/Tracking?tracknumbers={0}&action=track", TrackingNumber);
                    break;
                case "ups":
                case "unitedpostalservice":
                case "united postal service":
                    //trackingUrl = string.Format("http://wwwapps.ups.com/WebTracking/processInputRequest?InquiryNumber1={0}&tracknums_displayed=1&TypeOfInquiryNumber=T", TrackingNumber);
                    trackingUrl = string.Format("http://wwwapps.ups.com/WebTracking/track?loc=en_US&track.x=Track&trackNums={0}", TrackingNumber);
                    break;
                case "usps":
                case "unitedstatespostalservice":
                case "united states postal service":
                case "postoffice":
                case "post office":
                    trackingUrl = string.Format("http://trkcnfrm1.smi.usps.com/PTSInternetWeb/InterLabelInquiry.do?origTrackNum={0}", TrackingNumber);
                    break;
                default:
                    trackingUrl = string.Format("http://{0}?TrackingNumber={1}", Carrier, TrackingNumber);
                    break;
            }
            return trackingUrl;
        }
    }
}
