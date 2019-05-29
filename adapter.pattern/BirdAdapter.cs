namespace adapter.pattern
{
    public class BirdAdapter : IToyDuck
    {
        private readonly IBird _bird;

        public BirdAdapter(IBird bird)
        {
            _bird = bird;
        }

        public string Squeak()
        {
            // translate the method appropriately
            return _bird.MakeSound();
        }
    }
}