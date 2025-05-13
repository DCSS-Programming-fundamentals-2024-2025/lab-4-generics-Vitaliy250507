using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Entities
{
    public class Teacher : Person
    {
        public void GradeStudent(Student student)
        {
            Console.WriteLine($"{Name} graded {student.Name}.");
        }

        public void ExpelStudent(Student student)
        {
            Console.WriteLine($"{Name} expelled {student.Name}.");
        }
        public void ShowPresentStudents(List<Student> students)
        {
            Console.WriteLine($"{Name} shows present students:");
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
