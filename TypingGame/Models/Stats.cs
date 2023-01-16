namespace TypingGame.Models
{
    public class Stats
    {
        //inisialisasi variabel secara public
        public int Correct { get; set; }
        public int Missed { get; set; }
        public int Total
        {
            get
            {
                return Correct + Missed;
            }
            set
            {
                { Correct = value; }
            }
        }
        public int Accuaracy;

        //methode menghitung total ketikan
        public void CountTotal()
        {
            Total = Correct + Missed;
        }

        //methode menghitung persentasi
        public void CountAccuaracy() 
        {
            Accuaracy = Correct * 100 / (Correct + Missed);
        }
    }
}
