using System;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class Shipment
    {   

        public Shipment(int ShipmentId,
        int OrderId,
        int ShipperId,
        DateTime ShipmentDate,
        string TrackingNumber,
        Order Order,
        Shipper Shipper)
        {
            this.ShipmentId = ShipmentId;
            this.OrderId = OrderId;
            this.ShipmentId = ShipmentId;
            this.ShipmentDate = ShipmentDate;
            this.TrackingNumber = TrackingNumber;
            this.Order = Order;
            this.Shipper = Shipper;

        }
        public Shipment()
        {

        }
        public Shipment
        (DateTime ShipmentDate,
        int ShipperId,
        string TrackingNumber)
        {
            this.ShipmentDate = ShipmentDate;
            this.ShipperId = ShipperId;
            this.TrackingNumber = TrackingNumber;
        }
        public int ShipmentId { get; set; } // Her kunne man også inplatmentere DomainPrimitiver!! :) 
        public int OrderId { get; set; }
        public int ShipperId { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string TrackingNumber { get; set; }

        public virtual Order Order { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
