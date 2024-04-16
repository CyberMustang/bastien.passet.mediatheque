using Mediatheque.Core.Model;

namespace Mediatheque.CoreTests.ModelTests.JeuxDeSocieteTests
{
    [TestClass]
    public class NewJeuxDeSocieteShould
    {
        [TestMethod]
        public void FillProperties()
        {
            //Arrange & Act
            var jeux = new JeuxDeSociete("Cascadia",10,99, "Lucky Duck Games", TypeJeuxDeSociete.Tuile);

            //Assert
            Assert.AreEqual(10, jeux.AgeMinimum);
            Assert.AreEqual(99, jeux.AgeMaximum);
            Assert.AreEqual("Lucky Duck Games", jeux.Editeur);
            Assert.AreEqual(TypeJeuxDeSociete.Tuile, jeux.TypeJeux);
        }
    }
}
