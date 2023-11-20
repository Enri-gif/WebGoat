using System;
using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class OrderDetail
    {
        public Order_OrderId OrderId { get; set; } // Done, Man vægler at bruge den samme dataType fra Order siden de er ens. 
        public OrderDetail_ProductId ProductId { get; set; } // Done
        public OrderDetail_UnitePrice UnitPrice { get; set; } // Done
        public OrderDetail_Quantity Quantity { get; set; } // Done
        public OrderDetail_Discount Discount { get; set; } // Done

        public virtual Order Order { get; set; } // er lavet    
        public virtual Product Product { get; set; } 

        public decimal DecimalUnitPrice => Convert.ToDecimal(this.UnitPrice);
        public decimal ExtendedPrice => DecimalUnitPrice * Convert.ToDecimal(1 - Discount) * Quantity;
    }
}
