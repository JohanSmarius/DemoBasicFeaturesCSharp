namespace ConsoleApp1.Domain;

public class Instructor
{
    public string Name { get; init; }

    public int EmployeeNumber { get; init; }

    public Instructor(string name, int employeeNumber)
    {
        Name = name;
        EmployeeNumber = employeeNumber;
    }
}