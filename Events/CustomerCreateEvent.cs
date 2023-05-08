using MediatR;

namespace MediatR_CQRS.Events
{
    public class CustomerCreatedEvent:INotification
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public CustomerCreatedEvent(string Fname,string Lname,DateTime registrationDate)
        {
            FName= Fname;
            LName= Lname;
            RegistrationDate= registrationDate;
        }
    }
}
