using ABC.BL;

namespace ABC.BLTest;

[TestClass]
public class ProduktRepositoryTest
{
    [TestMethod]
    public void PobierzProdukt()
    {

        var produktRepository = new ProduktRepository();
        var oczekiwana = new Produkt(2)
        {
            NazwaProduktu = "Klocki",
            Opis = "Klocki do zabawy powyżej 3 lat",
            AktualnaCena = 119.99M

        };

        var aktualna = produktRepository.Pobierz(2);

        Assert.AreEqual(oczekiwana.NazwaProduktu, aktualna.NazwaProduktu);
        Assert.AreEqual(oczekiwana.Opis, aktualna.Opis);
        Assert.AreEqual(oczekiwana.AktualnaCena, aktualna.AktualnaCena);
        Assert.AreEqual(oczekiwana.ProduktId, aktualna.ProduktId);
    }
}
