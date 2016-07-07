using Xunit;
namespace Scrabble.Objects
{
  public class ScrabbleWordTest
  {
    [Fact]
    public void Scrabble_Word_PointsLength()
    {
      ScrabbleWord newScrabbleWord = new ScrabbleWord ();
      Assert.Equal(5, newScrabbleWord.ScrabbleScore("Cat"));
    }
  }
}
