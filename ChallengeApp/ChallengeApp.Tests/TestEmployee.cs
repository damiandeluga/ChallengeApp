namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestMinGradeofTheWorker()
        {
            var employee = new Employee("Damian", "Domalewski");

            employee.AddGrade('a');
            employee.AddGrade(20);
            employee.AddGrade('B');
            employee.AddGrade("30");


            var statistics = employee.GetStatistics();

            Assert.AreEqual(20.0f, statistics.Min);
    
        }
        [Test]
        public void TestMaxGradeofTheWorker()
        {
            var employee = new Employee("Artur", "Durkowski");

            employee.AddGrade('a');
            employee.AddGrade(20);
            employee.AddGrade(30);
            employee.AddGrade("50");

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100.0f, statistics.Max);
      
        }
        [Test]
        public void TestAverageGradeofTheWorker()
        {
            var employee = new Employee("Cyprian", "Lizecki");

            employee.AddGrade('b');
            employee.AddGrade(20);
            employee.AddGrade(30);
            employee.AddGrade("15");
            employee.AddGrade('A');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(49.0f, statistics.Average); 



        }
    }
}