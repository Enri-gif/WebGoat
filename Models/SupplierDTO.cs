
using System.Diagnostics.CodeAnalysis;

namespace WebGoatCore.Models
{ 
    public class SupplierDTO
    {
        [NotNull]
        public string CompanyName { get; set; }
        [NotNull]
        public string ContactName { get; set; }
        [NotNull]
        public string? ContactTitle { get; set; } // man kan sige at "?" er fordi NUll er okie hvilke betyder dette er en mulighed
        [NotNull]
        public string? Address { get; set; }
        [NotNull]
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? HomePage { get; set; }
    }
}