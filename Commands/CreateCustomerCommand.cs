using MediatR;
using MediatR_CQRS.DTOs;

namespace MediatR_CQRS.Commands
{
    public class CreateCustomerCommand:IRequest<CustomerDto>
    {
        public string FName { get; }
        public string LName { get; }
        public CreateCustomerCommand(string fName,string lName)
        {
            FName = fName;
            LName = lName;
        }
    }
}
