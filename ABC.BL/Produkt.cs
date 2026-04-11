

namespace ABC.BL
{
    public class Produkt
    {

        public Produkt()
        {
            
        }

        public Produkt(int produktId)
        {
            this.ProduktId = produktId;
        }

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }

        public string NazwaProduktu { get; set; }


        /// <summary>
        /// Pobieramy 1 produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            return new Produkt();
        }


        /// <summary>
        /// Zapisujemy biezacy produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Sprawdzamy dane produktu
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
            {
                poprawne = false;
            }

            return poprawne;
        }












    }
}
