

namespace ABC.BL
{
    public class AdresRepository
    {
        public Adres Pobierz(int adresId)
        {
            Adres adres = new Adres(adresId);


            if(adresId == 1)
            {

                adres.AdresTyp = 1;
                adres.Ulica = "Goscinna";
                adres.Miasto = "Katowice";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "4-=467";
            }
            return adres;
        }
        /// <summary>
        /// Pobieramy wszystkie adresy dla klienta
        /// </summary>
        /// <param name="klientID"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int klientID)
        {
            var adresList = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Goscinna",
                Miasto = "Katowice",
                KodPocztowy = "40-476",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 2,
                Ulica = "Kosmiczna",
                Miasto = "Kraków",
                KodPocztowy = "41-333",
                Kraj = "Polska"


            };
            adresList.Add(adres);
            return adresList;

        }


        public bool Zapisz(Adres adres)
        {

            return true;
        }

    }
}
