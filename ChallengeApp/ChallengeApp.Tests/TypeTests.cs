namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenCompareTwoSatring_ShouldNotBeEqual()
        {
            string name1 = "Darth Vader";
            string name2 = "Anakin Skywalker";

            Assert.AreNotEqual(name1, name2);
        }

        [Test]
        public void WhenCompareTwoNumbers_ShouldNotBeEqual()
        {
            float numberA = 25.4f;
            float numberB = 18.7f;

            Assert.AreNotEqual(numberA, numberB);
        }
        [Test]
        public void WhenCompareTwoNumbers_ShouldBeEqual()
        {
            int number1 = 121;
            int number2 = 121;

            Assert.AreEqual(number1, number2);  
        }
        [Test]
        public void Employeetest_ShouldReturnNotEqual()
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


  













