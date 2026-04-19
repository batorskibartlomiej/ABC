namespace ABC.BL
{
    public class ZamowienieRepository
    {

        /// <summary>
        /// Pobieramy 1 zamowienie
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            if(zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018,4,14, 10,00,00, new TimeSpan(7,0,0));

            }



            return zamowienie;
        }
        /// <summary>
        /// PObiramy 1 zamowienie do wyswietlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            if(zamowienieId == 10)
            {

                wyswietlanieZamowienia.Imie = "Marcin";
                wyswietlanieZamowienia.Nazwisko = "Nowak";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018,4,14,10,00,00, new TimeSpan(7,0,0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Kosmiczna",
                    Miasto = "Katowice",
                    KodPocztowy = "40-467",
                    Kraj = "Polska"
                };


                    

            }
            wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();


            if(zamowienieId == 10)
            {
                var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Krzesło",
                    IloscZamowienia = 4,
                    CenaZakupu = 119.77M
                    
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Stolik",
                    IloscZamowienia = 6,
                    CenaZakupu = 249M

                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
            }

            return wyswietlanieZamowienia;



        }


        /// <summary>
        /// Zapisujemy biezace zamowienie
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
    }
}
