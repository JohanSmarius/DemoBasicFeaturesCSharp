namespace ConsoleApp1.Domain;

public class Address
{
    public string StreetName { get; set; }
    public string StreetNumber { get; set; }
    
    public string City { get; set; }

    public string FullAddress => $"{StreetName} {StreetNumber}, {City}";
}