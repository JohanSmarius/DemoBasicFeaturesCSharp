namespace ConsoleApp1.Domain;

public class Address
{
    public string StreetName { get; set; }

    public string StreetNumber
    {
        get;
        init
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Street number cannot be null or whitespace", nameof(value));
            }
            
            field = value;
        }
    }

    public string City { get; set; }

    public string FullAddress => $"{StreetName} {StreetNumber}, {City}";
}