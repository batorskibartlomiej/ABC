namespace ABC.BL
{
    public class ProduktRepository
    {

        /// <summary>
        /// Pobieramy 1 produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            Produkt produkt = new Produkt(produktId);
            Object mojObiekt = new object();
            Console.WriteLine("Obiekt : "+mojObiekt.ToString());
            Console.WriteLine("Produkt : " + produkt.ToString());

            if (produktId == 2)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki do zabawy powyżej 3 lat";
                produkt.AktualnaCena = 119.99M;
            }

            return produkt;
        }


        /// <summary>
        /// Zapisujemy biezacy produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public bool Zapisz(Produkt produkt)
        {
            var sukces = true;

            if(produkt.MaZmiany && produkt.DaneSaPrawidlowe)
            {
                if(produkt.JestNowy)
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
    }
}
