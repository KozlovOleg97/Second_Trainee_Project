using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Trainee_Project
{
    internal class Person
    {
        protected int _age;

        public void Greet()
        {
            Console.WriteLine($"Hello");
        }

        public Person(int Age)
        {
            _age = Age;
        }

        public int Age { get { return _age; } }

        public void Print()
        {
            Console.WriteLine("age: {0}", Age);
        }

        
    }
}
