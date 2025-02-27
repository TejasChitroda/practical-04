namespace StudentResult
{
    // Student class That contains some properties like name , marks , avrageMarks
    class Student
    {
        // Feild of Student class
        public string name;
        public decimal[] marks = new decimal[5];
        public static decimal AverageMarks;

        // EnterMarks : This Method is fo taking marks from user 
        public void EnterMarks()
        {


            Console.WriteLine("Enter Marks : ");
            for (int i = 0; i < marks.Length; i++)
            {
            MarksValidation:
                Console.Write($"Subject {i + 1} : ");

                string Marks = Console.ReadLine();

                if (decimal.TryParse(Marks, out _))
                {
                    marks[i] = Convert.ToDecimal(Marks);

                    if (marks[i] < 0 || marks[i] > 100)
                    {
                        Console.WriteLine("Enter Valid Marks");
                        goto MarksValidation;
                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid Marks");
                    goto MarksValidation;
                }
            }
        }

        // CalculateAvrageMarks : This method is calculate average marks of every subject
        public decimal CalculateAverageMarks()
        {
            AverageMarks = marks.Average();

            return AverageMarks;
        }

        // CalculateGrade : This Method is calculagte grade of student according to its average marks and return grade(string)
        public string CalculateGrade(decimal marks)
        {
            string grade;

            switch (marks)
            {
                case > 90:
                    grade = "A";
                    break;

                case > 80:
                    grade = "B";
                    break;

                case > 70:
                    grade = "C";
                    break;

                case < 70:
                    grade = "D";
                    break;

                default:
                    grade = "";
                    break;

            }

            return grade;
        }


    }
}