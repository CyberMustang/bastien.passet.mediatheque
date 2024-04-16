using Mediatheque.Core.Model;

namespace Mediatheque.CoreTests.ModelTests.CDTests
{
    [TestClass()]
    public class NewCDShould
    {
        [TestMethod()]
        public void FillAuteur_WhenProvidedInConstructor()
        {
            //Arrange & Act
            var actual = new CD("Smell like teen spirit", "Nirvana");

            //Assert
            Assert.AreEqual("Nirvana", actual.Groupe);
        }
    }
}