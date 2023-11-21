using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class Order
    {
        public Order_OrderId OrderId { get; set; } //Done
        public Order_CustomerId CustomerId { get; set; } //Done
        public Order_EmployeeId? EmployeeId { get; set; } //Done 
        public Order_OrderDate OrderDate { get; set; } // Done
        public Order_RequiredDate RequiredDate { get; set; } // Done
        public Order_ShippedDate? ShippedDate { get; set; } // Done
        public Order_ShipVia ShipVia { get; set; } // Done
        public Order_Freight Freight { get; set; } // Done
        public Order_ShipName? ShipName { get; set; } // Done
        public Order_ShipAddress? ShipAddress { get; set; } // Done
        public Order_ShipCity? ShipCity { get; set; } // Done
        public Order_ShipRegion? ShipRegion { get; set; } // Done
        public Order_ShipPostalCode? ShipPostalCode { get; set; } // Done
        public Order_ShipCounty? ShipCountry { get; set; } // Done

        public virtual IList<OrderDetail> OrderDetails { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual IList<OrderPayment> OrderPayments { get; set; }
        public virtual Shipment? Shipment { get; set; }

        public Order_SubTotal SubTotal => OrderDetails.Sum(od => od.ExtendedPrice); // Done
        Order_SubTotal order_SubTotal = new Order_SubTotal(()=> OrderDetails.Sum(od => od.ExtendedPrice));
        public Order_Total Total => Math.Round(SubTotal + Freight, 2); // Done

        public static string GetPackageTrackingUrl(string Carrier, string TrackingNumber)
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
