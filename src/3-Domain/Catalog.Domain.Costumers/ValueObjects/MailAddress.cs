using Catalog.Domain.Common.SeedOfWork;

namespace Catalog.Domain.Costumers.ValueObjects
{
    public class MailAddress : ValueObject
    {
        public MailAddress(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }
    }
}
