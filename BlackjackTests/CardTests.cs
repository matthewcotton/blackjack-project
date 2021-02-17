using Xunit;
using Blackjack.Models;

namespace BlackjackTests
{
  public class CardTests
  {
    [Fact]
    public void CheckSuit()
    {
      var card = new Card("10", 'C');
      Assert.True(card.suit == 'C');
    }

    [Fact]
    public void CheckRank()
    {
      var card = new Card("10", 'C');
      Assert.True(card.rank == "10");
    }

    [Fact]
    public void CheckName()
    {
      var card = new Card("10", 'C');
      Assert.True(card.name == "10C");
    }

    [Fact]
    public void CheckDefaultDealt()
    {
      var card = new Card("10", 'C');
      Assert.False(card.dealt);
    }

    [Fact]
    public void CheckChangedDealt()
    {
      var card = new Card("10", 'C');
      card.dealt = true;
      Assert.True(card.dealt);
    }
  }
}
