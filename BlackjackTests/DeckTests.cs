using Xunit;
using Blackjack.Models;

namespace BlackjackTests
{
  public class DeckTests
  {
    [Fact]
    public void CheckCardCount()
    {
      Deck deck = new Deck();
      var count = deck.deckOfCards.Count;
      Assert.True(deck.deckOfCards.Count == 52);
    }

    [Fact]
    public void Check7S()
    {
      Deck deck = new Deck();
      var result = deck.deckOfCards.Find(card => card.name == "7S");
      Assert.True(result.name == "7S");
    }
  }
}
