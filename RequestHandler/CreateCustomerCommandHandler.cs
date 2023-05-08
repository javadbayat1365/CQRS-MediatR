using AutoMapper;
using MediatR;
using MediatR_CQRS.Commands;
using MediatR_CQRS.Data;
using MediatR_CQRS.DTOs;
using MediatR_CQRS.Events;
using MediatR_CQRS.Models;

namespace MediatR_CQRS.RequestHandler
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
    {
        readonly ApplicationDbContext _context;
        readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CreateCustomerCommandHandler(ApplicationDbContext context, IMapper mapper,IMediator mediator)
        {
            _context = context;
            _mapper = mapper;
            this._mediator = mediator;
        }

        public async Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(request);
           var customerAdded =  _context.Customers.Add(customer);
           var save =   _context.SaveChanges();

            //😊🤣❤
            await _mediator.Publish(new CustomerCreatedEvent(customer.FName,customer.LName,customer.RegistrationDate),cancellationToken);

            return  _mapper.Map<CustomerDto>(customer);
        }
    }
}
