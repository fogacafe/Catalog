namespace Catalog.Application.Customers.UseCases.Customers.Commom
{
    public class AddressResponse
    {
        public AddressResponse(Guid id, string name, string zipCode, string city, string state, string country, string number, string street, string neighborhood, bool @default)
        {
            Id = id;
            Name = name;
            ZipCode = zipCode;
            City = city;
            State = state;
            Country = country;
            Number = number;
            Street = street;
            Neighborhood = neighborhood;
            Default = @default;
        }

        public AddressResponse()
        {
            Id = Guid.Empty;
            Name = string.Empty;
            ZipCode = string.Empty;
            City = string.Empty;
            State = string.Empty;
            Country = string.Empty;
            Number = string.Empty;
            Street = string.Empty;
            Neighborhood = string.Empty;
            Default = default;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public bool Default { get; set; }
    }
}
