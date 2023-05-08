namespace MediatR_CQRS.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
