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
