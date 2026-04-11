namespace ABC.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {
            
        }

        public Zamowienie(int zamowienieId)
        {
            this.ZamowienieId= zamowienieId;
        }

        public int ZamowienieId { get; private set; }


        public DateTimeOffset? DataZamowienia { get; set; }




        /// <summary>
        /// Pobieramy 1 zamowienie
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            return new Zamowienie();
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

        /// <summary>
        /// Sprawdzamy dane zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia ==null)
            {
                poprawne = false;
            }

            return poprawne;
        }

    }
}
