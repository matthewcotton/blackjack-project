using Xunit;
using Blackjack.Models;

namespace BlackjackTests
{
  public class TableTests
  {
    [Fact]
    public void CheckTableHasId()
    {
      Table table = new Table(3, 15);
      Assert.NotNull(table.tableId);
    }

    [Fact]
    public void CheckDefaultMinBet()
    {
      Table table = new Table(3);
      Assert.True(table.minBet == 10);
    }

    [Fact]
    public void CheckChangedMinBet()
    {
      Table table = new Table(3, 15);
      Assert.True(table.minBet == 15);
    }

    [Fact]
    public void CheckNumOfDecks()
    {
      Table table = new Table(3, 15);
      Assert.True(table.shoe.shoeOfCards.Count == 156);
    }
  }
}
