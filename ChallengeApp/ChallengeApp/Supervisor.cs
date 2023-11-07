namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {     
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, char gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }


        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else throw new Exception($"Wrong grade range: Grade {grade} value must be in the range 0-100");
           
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                AddGrade(100);
                    break;
                case "6-" or "-6":
                    AddGrade(95);
                    break;
                case "5+" or "+5":
                    AddGrade(90);
                    break;
                case "5":
                    AddGrade(85);
                    break;
                case "5-" or "-5":
                    AddGrade(80);
                    break;
                case "4+" or "+4":
                    AddGrade(75);
                    break;
                case "4":
                    AddGrade(70);
                    break;
                case "4-" or "-4":
                    AddGrade(65);
                    break;
                case "3+" or "+3":
                    AddGrade(60);
                    break;
                case "3":
                    AddGrade(55);
                    break;
                case "3-" or "-3":
                    AddGrade(50);
                    break;
                case "2+" or "+2":
                    AddGrade(45);
                    break;
                case "2":
                    AddGrade(30);
                    break;
                case "2-" or "-2":
                    AddGrade(15);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Invalid grade");
            }                      
        }
        public void AddGrade(double grade)
        {
            float gradeInDouble = (float)grade;
            AddGrade(gradeInDouble);
        }
        public void AddGrade(int grade)
        {
            float gradeInInt = (float)grade;
            AddGrade(gradeInInt);
        }
        public void AddGrade(long grade)
        {
            float gradeInLong = (float)grade;
            AddGrade(gradeInLong);
        }
        public void AddGrade(char grade)
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
        public Statistics GetStatistics()
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
            switch (statistics.Average)
            {
                case var average when average >= 90:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 70:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 50:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }

    }
}




