namespace ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, char gender) 
            : base(name, surname, gender)
        {
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Invalid grade");
            }
        }

        public override void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Incorrect data entered");

            }
        }
        public override void AddGrade(double grade)
        {
            float gradeInDouble = (float)grade;
            AddGrade(gradeInDouble);
        }

        public override void AddGrade(int grade)
        {
            float gradeInInt = (float)grade;
            AddGrade(gradeInInt);
        }

        public override void AddGrade(long grade)
        {
            float gradeInLong = (float)grade;
            AddGrade(gradeInLong);
        }

        public override void AddGrade(char grade)
       {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(50);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(40);
                    break;
                case 'F':
                case 'f':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("This letter isn't correct form of rating");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average = statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
