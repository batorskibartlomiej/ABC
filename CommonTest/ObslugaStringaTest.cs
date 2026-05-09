using Common;

namespace CommonTest
{
    [TestClass]
    public sealed class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {

            //Arrange
            var zrodlo = "KlockiLego";
            var oczekiwana = "Klocki Lego";
            //var obslugaStringa = new ObslugaStringa();bo klasa static

            //Act

            var aktualna = zrodlo.WstawSpacje();//tu metoda rozszerzenia

            //Assert

            Assert.AreEqual(oczekiwana, aktualna);

        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {

            //Arrange
            var zrodlo = "Klocki Lego";
            var oczekiwana = "Klocki Lego";
            //var obslugaStringa = new ObslugaStringa();

            //Act

            var aktualna = ObslugaStringa.WstawSpacje(zrodlo);//tu jako metoda statyczna

            //Assert

            Assert.AreEqual(oczekiwana, aktualna);

        }
    }
}
