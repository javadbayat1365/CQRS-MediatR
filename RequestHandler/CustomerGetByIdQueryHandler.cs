using AutoMapper;
using MediatR;
using MediatR_CQRS.Data;
using MediatR_CQRS.DTOs;
using MediatR_CQRS.Events;
using MediatR_CQRS.Events.CustomerGetByIdEventHadler;
using MediatR_CQRS.Queries;
using Microsoft.EntityFrameworkCore;

namespace MediatR_CQRS.RequestHandler
{
    public class CustomerGetByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CustomerGetByIdQueryHandler(ApplicationDbContext context, IMapper mapper, IMediator mediator)
        {
            this._context = context;
            this._mediator = mediator;
            this._mapper = mapper;
        }
        public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.Where(w => w.Id == request.Id).SingleOrDefaultAsync();
            if (customer == null)
            {
                var dto = _mapper.Map<CustomerDto>(customer);

               await _mediator.Publish(new CustomerGetByIdEvent(customer.Id,customer.FName,customer.LName,customer.RegistrationDate) { });

                return dto;
            }
            return new();
        }
    }
}
