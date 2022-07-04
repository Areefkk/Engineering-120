using CodeToTest;

namespace UnitTests
{
    public class Tests
    {

        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            //Arrange
            //var time = 21;
            //var expectedGreeting = "Good evening!";
            //Act
            //var result = Program.Greeting(time);
            //Assert
            //Assert.That(result, Is.EqualTo(expectedGreeting));

            Assert.That(Program.Greeting(21), Is.EqualTo("Good evening!"));
        }

        [Test]
        public void GivenATimeOf15_Greeting_ReturnsGoodEvening()
        {
            Assert.That(Program.Greeting(15), Is.EqualTo("Good evening!"));
        }
        [Test]
        public void GivenATimeOf2_Greeting_ReturnsGoodEvening()
        {
            Assert.That(Program.Greeting(2), Is.EqualTo("Good morning!"));
        }
        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void GivenATimeOfBetween5and12Inclusive_Greeting_ReturnGoodMorning(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good morning!"));
        }

        [TestCase(13)]
        [TestCase(15)]
        [TestCase(16)]

        public void GivenATimeOfBetween12and18Inclusive_Greeting_ReturnGoodAfternoon(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good afternoon!"));
        }

        [TestCase(19)]
        [TestCase(23)]
        [TestCase(3)]

        public void GivenATimeOfBetween19and4Inclusive_Greeting_ReturnGoodEvening(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good evening!"));
        }

        [TestCase(7, "Good morning!")]
        [TestCase(15, "Good afternoon!")]
        [TestCase(22, "Good evening!")]
        public void GivenTimeBoundaryValues_Greeting_ReturnsAppropriateGreeting(int time, string greet)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(greet));
        }

        [TestCase(3)]
        public void GivenAgeIsLessThan4(int age)
        {
            Assert.That(film.AvailableClassifications(age), Is.EqualTo("No films available"));
        }
        [TestCase(10)]
        public void GivenAgeIsLessThan12(int age)
        {
            Assert.That(film.AvailableClassifications(age), Is.EqualTo("U, PG  films are available."));
        }
        [TestCase(14)]
        public void GivenAgeIsLessThan15(int age)
        {
            Assert.That(film.AvailableClassifications(age), Is.EqualTo("U, PG & 12 & 12A films are available."));
        }
        [TestCase(16)]
        public void GivenAgeIsLessThan18(int age)
        {
            Assert.That(film.AvailableClassifications(age), Is.EqualTo("U, PG, 12 & 12A & 15 films are available."));
        }

        [TestCase(21)]
        public void GivenAgeIsAnythingELse(int age)
        {
            Assert.That(film.AvailableClassifications(age), Is.EqualTo("All films are available."));
        }


    }
}