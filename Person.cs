using System;

namespace classStudent
{
    partial class Person {
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public int YearOfBirth {get; set; }

        //Constructor
        public Person(string firstname, string lastname, int yearofbirth)
        {
            FirstName = firstname;
            LastName = lastname;
            YearOfBirth = yearofbirth;
        }
        public string getFullName()
        { 
            return $"{FirstName} {LastName}";
        }
        public int getAge()
        {
            return DateTime.Now.Year - this.YearOfBirth;
        }
        public string PersonInfo()
        {
            var personInfo = "Enter name of new person below \n";            
            personInfo += $"First Name: {FirstName}\n";
            personInfo += $"Last Name: {LastName}\n\n";
            personInfo += $"Creating new person record...\n\n";
            personInfo += $"Enter year of birth: {YearOfBirth} \n";  
            return personInfo;
        }
    }
}
