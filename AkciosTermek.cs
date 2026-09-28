namespace WebaruhazApp
{
    public class AkciosTermek : Termek
    {
        public int KedvezmenySzazalek
        {
            get; 
            set
            {
                if (value < 1 || value > 90) value = 10;
                field = value;
            }
        }

        public AkciosTermek(string _nev, int _nettoAr, int _kedvSzazealek) : base(_nev, _nettoAr)
        {
            KedvezmenySzazalek = _kedvSzazealek;
        }

        public override int BruttoArKiszamitas()
        {
            return base.BruttoArKiszamitas() * (1 - KedvezmenySzazalek / 100);
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Kedvezmény: {KedvezmenySzazalek})%";
        }
    }
}
