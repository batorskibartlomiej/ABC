namespace ABC.BL
{
    public class Zamowienie: KlasaBazowa
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

        public List<PozycjaZamowienia> pozycjaZamowienias { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }





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
        public bool Zapisz(Zamowienie zamowienie)
        {
            var sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DaneSaPrawidlowe)
            {
                if (zamowienie.JestNowy)
                {
                    //wywolujemy procedure skladowana insert
                }
                else
                {
                    //wywolujemy procedure skladowana update

                }
            }
            return sukces;
        }

        /// <summary>
        /// Sprawdzamy dane zamowienia
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia ==null)
            {
                poprawne = false;
            }

            return poprawne;
        }

        public override string ToString()
        {
            return DataZamowienia.Value.Date + "(" + ZamowienieId + ")";
        }

    }
}
