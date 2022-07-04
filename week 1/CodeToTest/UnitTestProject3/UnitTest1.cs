using CodeToTest;

namespace GreetingTest
{
    public class Tests
    {

        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            //Arrange
            var time = 21;
            //var expectedGreeting = "Good evening!";
            //ActTes
            //var result = Program.Greeting(time);
            //Assert
            //Assert.That(result, Is.EqualTo(expectedGreeting));

            Assert.That(Program.Greeting(21), Is.EqualTo("Good evening!"));
        }

        [Test]
        public void GivenATimeOf15_Greeting_ReturnsGoodAfternoon()
        {
            Assert.That(Program.Greeting(15), Is.EqualTo("Good afternoon!"));
        }

        [Test]
        public void GivenATimeOf2_Greeting_ReturnsGoodEvening()
        {
            Assert.That(Program.Greeting(2), Is.EqualTo("Good evening!"));
        }

        [Test]
        public void GivenATimeOf8_Greeting_ReturnsGoodMorning()
        {
            Assert.That(Program.Greeting(8), Is.EqualTo("Good morning!"));
        }
    }
}