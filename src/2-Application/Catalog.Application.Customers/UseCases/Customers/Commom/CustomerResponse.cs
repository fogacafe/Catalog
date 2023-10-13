namespace Catalog.Application.Customers.UseCases.Customers.Commom
{
    public class CustomerResponse
    {
        public CustomerResponse(Guid id, string name, string fantasyName, string tax)
        {
            Id = id;
            Name = name;
            FantasyName = fantasyName;
            Tax = tax;
        }

        public CustomerResponse()
        {
            Id = Guid.Empty;
            Name = string.Empty;
            FantasyName = string.Empty;
            Tax = string.Empty;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FantasyName { get; set; }
        public string Tax { get; set; }
    }
}
