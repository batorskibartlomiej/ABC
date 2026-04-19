namespace ABC.BL
{
    public class Klient
    {

        public Klient(): this(0)
        {
            
        }


        public Klient(int klientId)
        {
            this.KlientId = klientId;
            ListaAdresow = new List<Adres> ();
        }

        public List<Adres> ListaAdresow { get; set; }
        

        public static int Licznik { get; set; }

        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }
        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            
            
            get
            {
                string imieNazwisko = Imie;
                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if(!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko +=", ";
                    }
                    imieNazwisko += Nazwisko;

                }
                return imieNazwisko;
            }

        }


        public bool Zwaliduj()
        {
            var poprawne = true;
            
            if(string.IsNullOrWhiteSpace(Nazwisko))
            {
                poprawne = false;
            }
            if(string.IsNullOrWhiteSpace(Email))
            {
                poprawne = false;
            }
            return poprawne;


        }

        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {

            return true;

        }

        /// <summary>
        /// PObieramy 1 klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {

            return new Klient();

        }
        /// <summary>
        /// PObieramy liste klientow
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            return new List<Klient>();
        }





    }
}
