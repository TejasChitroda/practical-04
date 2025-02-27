using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult
{
    // Options : This is an "enum" that contains some available options in menu
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }

    // Class Program
    class Program
    {
        // This is Main method
        public static void Main(string[] args)
        {
            // st : this is an Object of Student class so we can access all properties of student class (exclude : private and static properties)
            Student st = new Student();

            int choice;

            Console.WriteLine("Enter Student Name : ");

        NameInput:
            // Taking input from user (name);
            st.name = Console.ReadLine();
            if(st.name == "")
            {
                Console.WriteLine("Enter valid Name : ");
                goto NameInput;
            }

            // Here we are calling EnterMarks() Method of student clas that it take input as a marks(integer)
            st.EnterMarks();

            // This is do..while Loop 
            do
            {
                Console.WriteLine("1 - Aggregate: Displays the Name: Average marks \r\n2 - MinMark: Displays the minimum marks of the student\r\n3 - MaximumMark: Displays the maximum mark\r\n4 - Grade: Displays grade\r\n0 - Termination");
                // Here we are taking input from user about there choice of operation
                choice = Convert.ToInt32(Console.ReadLine());

                // Switch case Statment according to users choice we are giving output
                switch ((Options)choice)
                {
                    // For Aggregate (calculate average Marks of student)
                    case Options.Aggregate:
                        Console.WriteLine($"{st.name} : {st.CalculateAverageMarks()}");
                        break;
                    // For Minimum Marks
                    case Options.MinMark:
                        Console.WriteLine($"MinMark : {st.marks.Min()}");
                        break;
                    // For Maximum Marks
                    case Options.MaximumMark:
                        Console.WriteLine($"Maximum Mark : {st.marks.Max()}");
                        break;
                    // For calculating Grade (according to student's average marks)
                    case Options.Grade:
                        Console.WriteLine($"Grade : {st.CalculateGrade(st.CalculateAverageMarks())}");
                        break;
                    // This is default case for handling false and wrong choice
                    default:
                        if(choice !=0)
                            Console.WriteLine("wrong option chosen");
                        break;
                }
            } while (choice != 0);
        }
    }
}
