using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Trainee_Project
{
    internal class Teacher : Person
    {
        public Teacher(int Age) : base(Age)
        {
        }

        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }

        public new void Print()
        {
            base.Print();
        }
    }
}
