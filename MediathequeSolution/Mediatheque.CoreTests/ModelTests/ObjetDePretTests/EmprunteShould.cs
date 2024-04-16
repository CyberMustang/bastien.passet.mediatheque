using Mediatheque.Core.Model;

namespace Mediatheque.CoreTests.ModelTests.ObjetDePretTests
{
    [TestClass()]
    public class EmprunteShould()
    {
        [TestMethod()]
        public void FillEmprunteur()
        {
            //Arrange
            var objetDePret = new ObjetDePret("Scie sauteuse");

            //Act
            objetDePret.Emprunte("bernard");

            //Assert
            Assert.Equals("bernard", objetDePret.Emprunteur);
        }

        [TestMethod()]
        public void ReturnTrue_IfObjetIsAvailable()
        {
            //Arrange
            var objetDePret = new ObjetDePret("chaise");

            //Act
            var actual = objetDePret.Emprunte("albert");

            //Assert
            bool expected = true;
            Assert.Equals(expected, actual);
        }

        [TestMethod()]
        public void ReturnFalse_IfObjetIsNotAvailable()
        {
            //Arrange
            var objetDePret = new ObjetDePret("chaise");
            objetDePret.Emprunteur = "Alain";

            //Act
            var actual = objetDePret.Emprunte("albert");

            //Assert
            bool expected = false;
            Assert.Equals(expected, actual);
        }
    }
}