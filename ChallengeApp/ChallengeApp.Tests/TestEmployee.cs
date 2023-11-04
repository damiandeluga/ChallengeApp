namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestMinGradeofTheWorkerFromStatistics()
        {
            var employee = new Employee("Damian", "Domalewski");

            employee.AddGrade(4);
            employee.AddGrade(5);
            employee.AddGrade(9);

            var statistics = employee.GetStatistics();
           
            Assert.AreEqual(4.0f, statistics.Min);
    
        }
        [Test]
        public void TestMaxGradeofTheWorkerFromStatistics()
        {
            var employee = new Employee("Artur", "Durkowski");

            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(8);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(8.0f, statistics.Max);
      
        }
        [Test]
        public void TestAverageGradeofTheWorkerFromStatistics()
        {
            var employee = new Employee("Cyprian", "Lizecki");

            employee.AddGrade(10);
            employee.AddGrade(15);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(10.0F, statistics.Average);



        }
    }
}