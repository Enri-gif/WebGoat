using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using NuGet.Common;
using WebGoatCore.Models;

namespace WebGoat.NET.Tests;




public class InvarianceTest
{
    
    
    public void InvarianceOrderTest() // tester man invariance i Order Klassen. 
    {   
        
        Assert.ThrowsAny<Exception> // Hvis der IKKE kommer en fejl ensses det som en fejl
        ( () =>
        {
            Customer _Customer = new Customer
            (
                "20",
                "Arla",
                "Erik",
                "CEO",
                "UCL",
                "Odense",
                "Fyn",
                "5500",
                "Denmark",
                "8888888",
                "Fax"

    
            ); 
            IList<OrderDetail> orderDetails = new List<OrderDetail>();
            orderDetails.Add(new OrderDetail());
            IList<OrderPayment> orderPayments = new List<OrderPayment>();
            orderPayments.Add(new OrderPayment());

            Order _order = new Order 
            (
                new Order_OrderId (30000000 ),
                new Order_CustomerId("922222222222222222229"),
                new Order_EmployeeId(8822555),
                new Order_OrderDate(DateTime.MinValue),
                new Order_RequiredDate(DateTime.MinValue),
                new Order_ShippedDate(DateTime.MinValue),
                new Order_ShipVia(12),
                23, // Decimal
                new Order_ShipName("Tobia>>\\//>s"),
                new Order_ShipAddress("UC6521561L"),
                new Order_ShipCity("Od555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555ense"),
                new Order_ShipRegion("\\"),
                new Order_ShipPostalCode("5592<>//"),
                new Order_ShipCounty("<<>>>"),
                orderDetails,
                _Customer,
                orderPayments,
                new Shipment()

            ); 
            Shipment _Shipment = new Shipment
            (
                300,
                300,
                50,
                DateTime.Now,
                "TrackingNumber",
                _order,
                new Shipper
                (123,
                "Firma Navn",
                "Service name",
                1232,
                "Mobil Nummer")

            );
        });

    }




}
