﻿

using System.ComponentModel.Design;

namespace ChallengeApp
{
    public class Employee
    {
        public List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            
            if(grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else 
            {
                Console.WriteLine("Incorrect data entered");

            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);

            }
            else
            {
                Console.WriteLine("String is not float");

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
        public Statistics GetStatistics()
        { 
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades) 
            { 
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
            
        }

    }
}
