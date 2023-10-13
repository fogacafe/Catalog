using Catalog.Domain.Common.SeedOfWork;

namespace Catalog.Domain.Costumers.Entities
{
    public class Address : Entity
    {
        public Address(Guid id, string name, string zipCode, string city, string state, string country, string number, string street, string neighborhood, bool @default)
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

        public string Name { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string Number { get; private set; }
        public string Street { get; private set; }
        public string Neighborhood { get; private set; }
        public bool Default { get; private set; }

        public void SetDefault(bool @default) => Default = @default;
    }
}
