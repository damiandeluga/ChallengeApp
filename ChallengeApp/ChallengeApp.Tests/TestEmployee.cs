namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestMinMaxAverageGradeofTheWorkerFromStatistics()
        {
            var employee = new Employee("Damian", "Domalewski");

            employee.AddGrade(4);
            employee.AddGrade(5);
            employee.AddGrade(9);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(9.0f, statistics.Max);
            Assert.AreEqual(4.0f, statistics.Min);
            Assert.AreEqual(6.0F, statistics.Average);



        }

    }
}