namespace adapter.pattern
{
    public class Sparrow : IBird
    {
        public string Fly()
        {
            return "Flying";
        }

        public string MakeSound()
        {
            return "Chirp Chirp";
        }
    }
}