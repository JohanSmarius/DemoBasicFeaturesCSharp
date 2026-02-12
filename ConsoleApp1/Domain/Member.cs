namespace ConsoleApp1.Domain;

public class Member(string name, DateTime birthdate, string email)
{
    public string Name { get; set; } = name;

    public DateTime Birthdate { get; set; } = birthdate;

    public Address? Address { get; set; }

    public string Email { get; set; } = email;

    public string NameToUpper =>  Name.ToUpper();
}