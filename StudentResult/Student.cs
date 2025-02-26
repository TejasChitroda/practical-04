namespace StudentResult
{
    class Student
    {
        public string name;
        public decimal[] marks = new decimal[5];
        public static decimal AverageMarks;

        public void EnterMarks()
        {
            Console.WriteLine("Enter Marks : ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i+1} : ");
                marks[i] = Convert.ToDecimal(Console.ReadLine());
            }
        }

        public decimal CalculateAverageMarks()
        {
            AverageMarks = marks.Average();

            return AverageMarks;
        }

        public string CalculateGrade(decimal marks)
        {
            string grade;

            switch(marks)
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