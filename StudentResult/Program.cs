using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult
{
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student st = new Student();

            Console.WriteLine("Enter Student Name : ");
            st.name = Console.ReadLine();

            st.EnterMarks();
            int choice;

            do
            {
                Console.WriteLine("1 - Aggregate: Displays the Name: Average marks \r\n2 - MinMark: Displays the minimum marks of the student\r\n3 - MaximumMark: Displays the maximum mark\r\n4 - Grade: Displays grade\r\n0 - Termination");
                choice = Convert.ToInt32(Console.ReadLine());

                switch ((Options)choice)
                {
                    case Options.Aggregate:
                        Console.WriteLine($"{st.name} : {st.CalculateAverageMarks()}");
                        break;
                    case Options.MinMark:
                        Console.WriteLine($"MinMark : {st.marks.Min()}");
                        break;
                    case Options.MaximumMark:
                        Console.WriteLine($"Maximum Mark : {st.marks.Max()}");
                        break;
                    case Options.Grade:
                        Console.WriteLine($"Grade : {st.CalculateGrade(st.CalculateAverageMarks())}");
                        break;
                    default:
                        if(choice !=0)
                            Console.WriteLine("wrong option chosen");
                        break;
                }
            } while (choice != 0);
        }
    }
}
