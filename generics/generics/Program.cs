using generics.Entities;
using generics.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var fpm = new Faculty { Id = 1, Name = "FPM" };

        var kp41 = new Group { Id = 41, Name = "КП-41" };
        var kp42 = new Group { Id = 42, Name = "КП-42" };
        var kp43 = new Group { Id = 43, Name = "КП-43" };

        fpm.AddGroup(kp41);
        fpm.AddGroup(kp42);
        fpm.AddGroup(kp43);

        var s1 = new Student { Id = 1, Name = "Канельський Віталій" };
        var s2 = new Student { Id = 2, Name = "Худащов Богдан" };
        var s3 = new Student { Id = 3, Name = "Голомбаш Олександр" };

        fpm.AddStudentToGroup(41, s1);
        fpm.AddStudentToGroup(41, s2);
        fpm.AddStudentToGroup(41, s3);

        var students = fpm.GetAllStudentsInGroup(41);
        foreach (var student in students)
        {
            Console.WriteLine($"Student in group КП-41: {student.Name}");
        }

        IReadOnlyRepository<Student, int> studRepo = new InMemoryRepository<Student, int>();
        IReadOnlyRepository<Person, int> persRepo = studRepo;  // має компілюватися
    }
}