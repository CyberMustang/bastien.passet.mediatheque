using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using Mediatheque.Core.Model;
using Mediatheque.Core.Service;

namespace Mediatheque.Core.Tests
{
    [TestFixture]
    public class MediathequeServiceTests
    {
        [Test]
        public void PresenterJeux_NoJeux_ReturnsNoJeuxMessage()
        {
            // Arrange
            var notationServiceMock = new Mock<INotationService>();
            var mediathequeService = new MediathequeService(notationServiceMock.Object);

            // Act
            var result = mediathequeService.PresenterJeux();

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Il n'y a rien ici.", result[0]);
        }

        [Test]
        public void PresenterJeux_OneCd_ReturnsCdDescriptionWithNote()
        {
            // Arrange
            var cd = new CD("Nom du CD", "Groupe A", "Editeur A", "Tranche A");
            var notationServiceMock = new Mock<INotationService>();
            notationServiceMock.Setup(x => x.GetNoteJeuxSociete(It.IsAny<string>())).Returns(5);
            var mediathequeService = new MediathequeService(notationServiceMock.Object);
            mediathequeService.AddObjet(cd);

            // Act
            var result = mediathequeService.PresenterJeux();

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Nom du jeu : Nom du CD, Éditeur : Editeur A, Tranches d'âge : Tranche A, Note : 5", result[0]);
        }
    }
}
