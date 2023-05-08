namespace MediatR_CQRS.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
