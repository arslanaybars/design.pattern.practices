using Xunit;

namespace adapter.pattern
{
    public class Test
    {
        [Fact]
        public void AdapterTest()
        {
            // Arrange 
            Sparrow Sparrow = new Sparrow();
            IToyDuck toyDuck = new PlasticToyDuck();

            // Wrap a bird in a birdAdapter so 
            // it behaves like a toy duck
            IToyDuck birdAdapter = new BirdAdapter(Sparrow);
            
            // Act
            

            // Assert
            Assert.Equal("Flying", Sparrow.Fly());
            Assert.Equal("Chirp Chirp", Sparrow.MakeSound());

            Assert.Equal("Squeak", toyDuck.Squeak());
            
            Assert.Equal("Chirp Chirp", birdAdapter.Squeak());
        }
    }
}