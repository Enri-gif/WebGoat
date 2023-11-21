#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class Customer
    {
        public Customer(
        string CustomerId,
        string CompanyName,
        string ContactName,
        string? ContactTitle,
        string? Address,
        string? City,
        string? Region,
        string? PostalCode,
        string? Country,
        string? Phone,
        string? Fax
        )
        {
            this.CustomerId = CustomerId;
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.ContactTitle = ContactTitle;
            this.Address = Address;
            this.City = City;
            this.Region = Region;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.Phone =Phone;
            this.Fax = Fax;


        }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
    }
}
