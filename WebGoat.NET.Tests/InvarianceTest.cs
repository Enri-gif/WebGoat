using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using NuGet.Common;
using WebGoatCore.Models;

namespace WebGoat.NET.Tests;




public class InvarianceTest
{
    [Theory] // Dette noget man skal ha
    [InlineData("kage")]
    
    public void InvarianceOrderTest(Order order) // tester man invariance i Order Klassen. 
    {
        Assert.ThrowsAny<Exception>
        (
            Order _order = new Order 
            (
                new Order_OrderId (300 ),
                new Order_CustomerId("99"),
                new Order_EmployeeId(88),
                new Order_OrderDate(DateTime.Now),
                new Order_RequiredDate(DateTime.Now),
                new Order_ShippedDate(DateTime.Now),
                new Order_ShipVia(12),
                23, // Decimal
                new Order_ShipName("Tobia>>\\//>s"),
                new Order_ShipAddress("UCL"),
                new Order_ShipCity("Odense"),
                new Order_ShipRegion("Fyn"),
                new Order_ShipPostalCode("5592"),
                new Order_ShipCounty("Denmark"),
                // skal ha en liste af orderdetails
                _Customer,
                // skal ha en liste af orderpayments
                new Shipment()

            ); 
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
            Shipment _Shipment = new Shipment
            (
                300,
                300,
                50,
                DateTime.Now,
                "TrackingNumber",
                _


            );
        );

    }




}
