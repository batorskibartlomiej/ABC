using ABC.BL;

namespace ABC.BLTest;

[TestClass]
public class KlientRepositoryTest
{
    [TestMethod]
    public void PobierzKlienta()
    {
        var klientRepository = new KlientRepository();
        var oczekiwana = new Klient(1)
        {
            Email = "marcin@dev-hobby.pl",
            Imie = "Marcin",
            Nazwisko = "Nowak"
        };

        var aktualna = klientRepository.Pobierz(1);

        //Assert.AreEqual(oczekiwana, aktualna);
        Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
        Assert.AreEqual(oczekiwana.Email, aktualna.Email);
        Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
        Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

    }
}
