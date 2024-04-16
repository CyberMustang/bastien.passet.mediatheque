using Mediatheque.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.CoreTests.ModelTests.ObjetDePretTests
{

    [TestClass()]
    public class NewObjetDePretShould
    {
        [TestMethod()]
        public void FillTitre_WhenProvidedInConstructor()
        {
            //Arrange & Act
            var actual = new ObjetDePret("super titre");

            //Assert
            Assert.AreEqual("super titre", actual.TitreDeLObjet);
        }
    }
}