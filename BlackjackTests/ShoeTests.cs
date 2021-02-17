using Xunit;
using Blackjack.Models;

namespace BlackjackTests
{
  public class ShoeTests
  {
    [Fact]
    public void CheckDefaultDeckCount()
    {
      Shoe shoe = new Shoe();
      Assert.True(shoe.shoeOfCards.Count == 208);
    }

    [Fact]
    public void Check1DeckCount()
    {
      Shoe shoe = new Shoe(1);
      Assert.True(shoe.shoeOfCards.Count == 52);
    }

    [Fact]
    public void Check6DeckCount()
    {
      Shoe shoe = new Shoe(6);
      Assert.True(shoe.shoeOfCards.Count == 312);
    }

    [Fact]
    public void CheckZeroPercentDealt()
    {
      Shoe shoe = new Shoe(1);
      Assert.True(shoe.percentageDealt == 0);
    }

    [Fact]
    public void Check100PercentDealt()
    {
      Shoe shoe = new Shoe(1);
      shoe.shoeOfCards.ForEach(card =>
      {
        card.dealt = true;
      });
      Assert.True(shoe.percentageDealt == 100);
    }

    [Fact]
    public void Check50PercentDealt()
    {
      Shoe shoe = new Shoe(1);
      int i = 0;
      shoe.shoeOfCards.ForEach(card =>
      {
        if (i % 2 == 0)
        {
          card.dealt = true;
        }
        i++;
      });
      Assert.True(shoe.percentageDealt == 50);
    }

    [Fact]
    public void CheckGetCardReturnValue()
    {
      Shoe shoe = new Shoe(1);
      var card = shoe.GetCard();
      Assert.IsType<Card>(card);
    }

    [Fact]
    public void CheckGetCardWhenShoeEmpty()
    {
      Shoe shoe = new Shoe(1);
      shoe.shoeOfCards.ForEach(card =>
      {
        card.dealt = true;
      });
      var card = shoe.GetCard();
      Assert.Null(card);
    }

    [Fact]
    public void CheckReturnedCardIsDealt()
    {
      Shoe shoe = new Shoe(1);
      var card = shoe.GetCard();
      Assert.True(card.dealt);
    }

  }
}
