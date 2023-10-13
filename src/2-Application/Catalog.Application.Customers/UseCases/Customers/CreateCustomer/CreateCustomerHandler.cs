using AutoMapper;
using Catalog.Application.Customers.Repositories;
using Catalog.Domain.Common.Repos;
using Catalog.Domain.Costumers.Entities;
using Catalog.Domain.Costumers.Enums;
using Catalog.Logs.Contract;
using MediatR;

namespace Catalog.Application.Customers.UseCases.Customers.CreateCustomer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public CreateCustomerHandler(IUnitOfWork unitOfWork, ICustomerRepository customerRepository, ILogger logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<CreateCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                _logger.Info("[CreateCustomerHandler][Handle] - start create customer");

                await _unitOfWork.BeginTransaction();

                var addresses = new List<Address>();

                var customer = new Customer(Guid.NewGuid(), request.Name, request.FantasyName, request.Tax, Status.Active, addresses);

                await _customerRepository.SaveAsync(customer);

                await _unitOfWork.CommitAsync();

                var response = _mapper.Map<CreateCustomerResponse>(customer);

                _logger.Info("[CreateCustomerHandler][Handle] - customer created");

                return response;
            }
            catch(Exception ex)
            {
                await _unitOfWork.Rollback();
                _logger.Error(ex, "[CreateCustomerHandler][Handle] - erro on create customer {@Request}", request);
                throw;
            }
        }
    }
}
