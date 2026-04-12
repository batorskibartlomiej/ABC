using ABC.BL;

namespace ABC.BLTest;

[TestClass]
public class ZamowienieRepositoryTest
{
    [TestMethod]
    public void PobierzZamowienie()
    {
        var zamowienieRepository = new ZamowienieRepository();
        var oczekiwana = new Zamowienie(10)
        {

            DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))

        };

        var aktualna = zamowienieRepository.Pobierz(10);
        Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
        Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
    }
}
