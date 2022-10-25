using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Trainee_Project
{
    internal class Student : Person
    {
        public Student(int Age) : base(Age)
        {
        }

        public void Study()
        {
            Console.WriteLine("I'm studying");
        }


        public new void Print()
        {
            base.Print();
        }

    }
}
