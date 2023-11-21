using System.Collections.Generic;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class Supplier
    {
        public SupplierID SupplierId { get; set; }
        public CompanyName CompanyName { get; set; }
        public string ContactName { get; set; }
        public string? ContactTitle { get; set; } // man kan sige at "?" er fordi NUll er okie hvilke betyder dette er en mulighed
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? HomePage { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
