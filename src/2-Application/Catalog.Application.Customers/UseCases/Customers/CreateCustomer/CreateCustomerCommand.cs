using MediatR;

namespace Catalog.Application.Customers.UseCases.Customers.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string FantasyName { get; set; }
        public string Tax { get; set; }

        public CreateCustomerCommand(string name, string fantasyName, string tax)
        {
            Name = name;
            FantasyName = fantasyName;
            Tax = tax;
        }
        public CreateCustomerCommand()
        {
            Name = string.Empty;
            FantasyName = string.Empty;
            Tax = string.Empty;
        }

        
    }
}
