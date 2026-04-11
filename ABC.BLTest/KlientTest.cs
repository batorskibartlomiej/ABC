using ABC.BL;

namespace ABC.BLTest
{
    [TestClass]
    public sealed class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {

            //Arrange
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Tomasz, Nowak";

            //Act
            string aktualna = klient.ImieNazwisko;

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }

        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {

            //Arrange
            Klient klient = new Klient();
            //klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak";

            //Act
            string aktualna = klient.ImieNazwisko;

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPusteTest()
        {

            //Arrange
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
           
            string oczekiwana = "Tomasz";

            //Act
            string aktualna = klient.ImieNazwisko;

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }

        [TestMethod]
        public void StaticTest()
        {

            //Arrange
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            Klient.Licznik += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Jacek";
            Klient.Licznik += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Marek";
            Klient.Licznik += 1;


            Assert.AreEqual(3, Klient.Licznik);

        }


        [TestMethod]
        public void ZwalidujTest()
        {
            var klient = new Klient();
            klient.Nazwisko = "Nowak";
            klient.Email = "tomek@wp.pl";

            var oczekiwana = true;
            var aktualna = klient.Zwaliduj();

            Assert.AreEqual(oczekiwana, aktualna );

        }

        [TestMethod]
        public void ZwalidujBrakNazwiskaTest()
        {
            var klient = new Klient();
            
            klient.Email = "tomek@wp.pl";

            var oczekiwana = false;
            
            var klient1 = new Klient(100);
            var klient2 = new Klient();

            var aktualna = klient.Zwaliduj();

            Assert.AreEqual(oczekiwana, aktualna);

        }
    }
}
