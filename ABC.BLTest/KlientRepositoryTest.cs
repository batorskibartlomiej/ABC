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

    [TestMethod]
    public void PobierzKlientaZAdresami()
    {
        var klientRepository = new KlientRepository();
        var oczekiwana = new Klient(1)
        {
            Email = "marcin@dev-hobby.pl",
            Imie = "Marcin",
            Nazwisko = "Nowak",
            ListaAdresow = new List<Adres>()
            {

                new Adres(1)
                {

                AdresTyp = 1,
                Ulica = "Goscinna",
                Miasto = "Katowice",
                KodPocztowy = "40-476",
                Kraj = "Polska"
                },
                new Adres(2)
                {

                AdresTyp = 2,
                Ulica = "Kosmiczna",
                Miasto = "Kraków",
                KodPocztowy = "41-333",
                Kraj = "Polska"


                }
            }
        };

        var aktualna = klientRepository.Pobierz(1);

        //Assert.AreEqual(oczekiwana, aktualna);
        Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
        Assert.AreEqual(oczekiwana.Email, aktualna.Email);
        Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
        Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

        for (int i = 0; i < 1; i++)
        {
            Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow [i].AdresTyp);
            Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
            Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
            Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);
            Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);

        }

    }
}
