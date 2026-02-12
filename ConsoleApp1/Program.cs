// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

var member = new Member("Iris Classon", new DateTime(2000, 1, 1), "iris@example.com")
{
    Address = new Address()
    {
        City = "Breda",
        StreetName = "Hogeschoollaan",
        StreetNumber = "1"
    }
};

var member2 = new Member("Jane Doe", 
    new DateTime(1990, 05, 20, 10, 0, 0), "jane.doe@example.com");
Console.WriteLine(member2.Name);

var instructor = new Instructor("John Doe", 12345);

var lesson = new Lesson(1, new DateTime(2020, 05, 20), 2);
lesson.Instructor = instructor;

try
{
    lesson.AddMember(member2);
    lesson.AddMember(member);
}
catch (DomainException e)
{
    Console.WriteLine(e);
    throw;
}

lesson.PrintAttendance();

lesson.Members.First().Address?.City = "Breda";

Console.WriteLine("Press any key");
Console.ReadLine();