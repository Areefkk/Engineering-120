using CodeToTest;

namespace UnitTests
{
    public class Classification_Tests
    {
        
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
        [TestCase(3,"No films available")]
        [TestCase(4, "U, PG  films are available.")]
        [TestCase(11, "U, PG  films are available.")]
        [TestCase(12, "U, PG, 12 & 12A films are available.")]
        [TestCase(15, "U, PG, 12, 12A & 15 films are available.")]
        [TestCase(16, "U, PG, 12, 12A & 15 films are available.")]
        [TestCase(18, "All films are available.")]
        [TestCase(19, "All films are available.")]

        public void GivenAnAgeAroundBoundaryValues_AvailableClassifications_ReturnProperClassification(int ageOfViewer, string availableClassification)
        {
            Assert.That(Program.AvailableClassifications(ageOfViewer), Is.EqualTo(availableClassification));
        }
    }
}
