namespace EmployeeAPI.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Department { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public Int32 PostalCode { get; set; }
        public string Country { get; set; }
        public long Salary { get; set; }

    }
}
