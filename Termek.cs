namespace WebaruhazApp
{
    public class Termek
    {
        private static int osszesTermekSzama = 0;

        protected static readonly double AFA_KULCS = 0.27;

        private int nettoAr;

        public string Nev { get; set; }
        public int NettoAr
        {
            get { return nettoAr; }
            set
            {
                if (value > 0) nettoAr = value;
            }
        }
        public static int OsszesTermekSzama
        {
            get { return osszesTermekSzama; }
        }

        public Termek(string _nev, int _nettoAr)
        {
            Nev = _nev;
            NettoAr = _nettoAr;

            osszesTermekSzama++;
        }

        public virtual int BruttoArKiszamitas()
        {
            return (int)(NettoAr * (1 + AFA_KULCS));
        }

        public override string ToString()
        {
            return $"Termék: {Nev} | Nettó: {NettoAr} Ft | Bruttó: {BruttoArKiszamitas()} Ft";
        }
    }
}
