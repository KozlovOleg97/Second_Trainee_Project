// See https://aka.ms/new-console-template for more information


using Second_Trainee_Project;

Person person = new Person(36);
person.Greet();
Console.WriteLine("____________smb Person_____________");

Student student = new Student(21);
student.Greet();
student.Study();
student.Print();
Console.WriteLine("-------------Student--------------");


Teacher teacher = new Teacher(45);
teacher.Greet();
teacher.Explain();
teacher.Print();
Console.WriteLine("---------Teacher---------");

