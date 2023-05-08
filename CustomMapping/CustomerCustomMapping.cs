using AutoMapper;
using MediatR_CQRS.Commands;
using MediatR_CQRS.DTOs;
using MediatR_CQRS.Models;

namespace MediatR_CQRS.CustomMapping
{
    public class CustomerCustomMapping:Profile
    {
        public CustomerCustomMapping()
        {
            CreateMap<CreateCustomerCommand, Customer>()
            .ForMember(c => c.RegistrationDate, opt =>
                opt.MapFrom(_ => DateTime.Now));

            CreateMap<Customer, CustomerDto>()
                .ForMember(cd => cd.RegistrationDate, opt =>
                    opt.MapFrom(c => c.RegistrationDate.ToShortDateString()));
        }
    }
}
