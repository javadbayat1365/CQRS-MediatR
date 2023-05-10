using MediatR;

namespace MediatR_CQRS.Events
{
    public class CustomerGetByIdEvent:INotification
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public CustomerGetByIdEvent(int id, string fname, string lName, DateTime registrationDate)
        {
            Id = id;
            Fname = fname;
            LName = lName;
            RegistrationDate = registrationDate;
        }
    }
}
