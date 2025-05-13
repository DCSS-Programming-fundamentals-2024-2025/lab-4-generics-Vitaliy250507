using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Entities
{
    public class Student : Person
    {
        public void SubmitWork()
        {
            Console.WriteLine($"{Name} submitted the work");
        }

        public void SayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

    }
}
