namespace WestcoastBank;

public class Customer
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public List<Address> Addresses { get; } = [];

    
}
