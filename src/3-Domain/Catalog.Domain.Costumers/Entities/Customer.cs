using Catalog.Domain.Common.SeedOfWork;
using Catalog.Domain.Costumers.Enums;

namespace Catalog.Domain.Costumers.Entities
{
    public class Customer : AggregateRoot
    {
        public Customer(Guid id, string name, string fantasyName, string tax, Status status, List<Address> addresses)
        {
            Id = id;
            Name = name;
            FantasyName = fantasyName;
            Tax = tax;
            Status = status;
            _addresses = addresses ?? new List<Address>();
        }

        public string Name { get; private set; }
        public string FantasyName { get; private set; }
        public string Tax { get; private set; }
        public Status Status { get; private set; }
        private List<Address> _addresses { get; set; }
        public IReadOnlyList<Address> Addresses { get => _addresses; }


        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public void RemoveAddress(Address address)
        {
            _addresses.Remove(address);
        }

        public void SetAsDefault(Address address)
        {
            _addresses.ForEach((item) =>
            {
                item.SetDefault(false);
            });

            address.SetDefault(true);
        }

        public void Update(string name, string fantasyName, string tax, Status status)
        {
            Name = name;
            FantasyName = fantasyName;
            Tax = tax;
            Status = status;
        }

        public void Update(string name, string fantasyName, string tax)
        {
            Name = name;
            FantasyName = fantasyName;
            Tax = tax;
        }

        public void UpdateStatus(Status status)
        {
            Status = status;
        }
    }
}
