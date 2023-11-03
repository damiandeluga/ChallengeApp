namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareIfTheyAreTheSame()
        {
            string name1 = "Darth Vader";
            string name2 = "Anakin Skywalker";

            Assert.AreNotEqual(name1, name2);
        }

        [Test]
        public void CompareTwoIntegerNumbers()
        {
            float numberA = 25.4f;
            float numberB = 18.7f;

            Assert.AreNotEqual(numberA, numberB);
        }
        [Test]
        public void CompareTwoNumbers()
        {
            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);  
        }
        [Test]
        public void TestGetUserShouldReturnDifference()
        {
            var employee1 = new Employee("Adam", "Pierwszy", 28);
            var employee2 = new Employee("Antoni", "Drugi", 18);

            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

    }

}


  













