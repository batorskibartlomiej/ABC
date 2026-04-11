namespace ABC.BL
{
    public class PozycjaZamowienia
    {

        public PozycjaZamowienia()
        {
            
        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            this.PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }



        /// <summary>
        /// Pobieramy 1 pozycjeZamowienia
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            return new PozycjaZamowienia();
        }


        /// <summary>
        /// Zapisujemy biezaca pozycjeZamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Sprawdzamy dane pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if(Ilosc <=0)
                poprawne = false;
            if(ProduktId <=0)
                poprawne = false;
            if (CenaZakupu == null)
                poprawne = false;

            return poprawne;
        }

    }
}
