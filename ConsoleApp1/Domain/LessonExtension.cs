namespace ConsoleApp1.Domain;

public static class LessonExtension
{
    extension(Lesson lesson)
    {
        public void PrintAttendance()
        {
            foreach (var lessonMember in lesson.Members)
            {
                Console.WriteLine($"{lessonMember.NameToUpper} - {lessonMember.Email} - {lessonMember.Birthdate} - {lessonMember.Address?.FullAddress ?? "No address on file"}");
            }
        }
    }
}