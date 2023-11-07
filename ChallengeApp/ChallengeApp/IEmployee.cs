﻿namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name {get;}
        string Surname {get;}
        char Gender { get;}

        void AddGrade(string grade);
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(long grade);
        void AddGrade(char grade);
        Statistics GetStatistics();
    }
}