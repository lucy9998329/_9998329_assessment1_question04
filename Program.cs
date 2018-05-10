using System;

namespace classStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Star the program with Clear()
            Console.Clear();
           
            Student student = new Student ("Mokoia", "Sam", "Smith", 2002);
            Console.WriteLine(student.StudentInfo());
            Console.WriteLine($"{student.getFullName()} of Mokoia campus has a student ID of {student.EnrollStudent()} \n");
            Console.ReadKey();  
        }
    }
}
