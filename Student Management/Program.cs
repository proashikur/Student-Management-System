using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


 public class Student
{
  

    public string Name {
        get;
        private set;
    }

    public DateTime DateOfBirth {

        get;
         private set; 
    }

    public string RollNumber {

        get;
         private set;
    }

    public Student (string name, DateTime dateOfBirth, string rollNumber)

    {
        ValidateInputs(name, dateOfBirth, rollNumber);
        
        Name = name;
        DateOfBirth = dateOfBirth;
        RollNumber = rollNumber;
    }

        private static void ValidateInputs( string name, DateTime dateOfBirth,string rollNumber) {
        if (dateOfBirth > DateTime.Now)
        {
            // Console.WriteLine($"hellow i am date setter");
            throw new ArgumentException("Date of birth can not be in the future.");
        }
        if (string.IsNullOrWhiteSpace(name))
        {

            throw new ArgumentException("Name can't be null or empty.");
        }
        if (string.IsNullOrWhiteSpace(rollNumber))
        {

            throw new ArgumentException("RollNumber can't be null or empty.");
        }
        if (dateOfBirth == default)
        {

            throw new ArgumentException("Date of birth can't be null or empty.");
        }
    }

    private int CalculateAge()


    {

        int age = DateTime.Now.Year - DateOfBirth.Year;

        //check if the birthday for this year has occurred yet
        //if the birthday hasnot occurred yet, decrement the age by 1

        return DateTime.Now < DateOfBirth.AddYears(age) ?
            age -1 : age;

          }

    public int age =>  CalculateAge();

      public void PrintDetails() 
    {
       
        Console.WriteLine($"Name: {Name}, Date of Birth: {DateOfBirth.ToShortDateString()},RoolNumber: {RollNumber}, Age : {age}");
    }





}


public class myclass
{
    public static void Main(string[] args)
    {
        try
        {
            Student student1 = new Student("ashik", new DateTime(1990,3,30),"CSE101");
            Student student2 = new Student("trima", new DateTime(2000,4,15), "CSE102");
        

            // Display student details
            Console.WriteLine($"Student Details: ");
            Console.WriteLine($"-------------------");
            //Console.WriteLine($"Name: {student1.Name}, Date of Birth: {student1.DateOfBirth.ToShortDateString()}, RoolNumber: {student1.RollNumber}, Age : {student1.age}"); printdetails method er jonno comnt kora hyse
            //Console.WriteLine($"Name: {student2.Name}, Date of Birth: {student2.DateOfBirth.ToShortDateString()}, RoolNumber: {student2.RollNumber}, Age : {student2.age}"); printdetails method er jonno comnt kora hyse

            student1.PrintDetails();
            student2.PrintDetails();
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Eroro : {ex.Message}");
          
        }
    }
}
