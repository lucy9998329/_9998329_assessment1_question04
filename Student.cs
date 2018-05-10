using System;

namespace classStudent
{
        class Student : Person {
        public string Campus {get; set; }
        public int StudentID {get; set; }

            //Constructor
            public Student(string campus, string FirstName, string LastName, int yearofbirth ): base (FirstName, LastName, yearofbirth){
                Campus = campus;
            }
            public int EnrollStudent()
        {
        int _min = 1000;
        int _max = 9999;
        Random _rdm = new Random();
        return _rdm.Next(_min, _max);

        }
        public string StudentInfo()
        {
            var studentInfo = "Enter name of new student below \n";            
            studentInfo += $"Enter first name: {FirstName}\n";
            studentInfo += $"Enter last name: {LastName}\n";
            studentInfo += $"Enter campus: {Campus}\n\n";
            studentInfo += $"Creating new person record...\n\n";
            studentInfo += $"Adding new student to {Campus} campus... \n";  
            return studentInfo;
        }
        public override string ToString(){
            return "";
        }
    }
}
